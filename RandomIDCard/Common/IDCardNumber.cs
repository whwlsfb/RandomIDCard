using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Linq;

namespace RandomIDCard.Common
{
    /// <summary>
    /// 身份证号码解析与生成
    /// </summary>
    public class IdCardNumber
    {
        #region 身份证信息属性

        /// <summary>
        /// 所在省份信息
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 所在地区信息
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 所在区县信息
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 性别，0为女，1为男
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CardNumber { get; set; }

        #endregion

        #region 静态方法
        /// <summary>
        /// 
        /// </summary>
        public static readonly List<Area> AllAreas = new List<Area>();
        /// <summary>
        /// 获取区域信息
        /// </summary>
        public static void FillAreas()
        {
            AllAreas.Clear();
            XmlDocument docXml = new XmlDocument();
            docXml.LoadXml(Properties.Resources.AreaCodeInfo);
            XmlNodeList nodelist = docXml.GetElementsByTagName("area");
            var areas = new Dictionary<string, string>();
            foreach (XmlNode node in nodelist)
            {
                string code = node.Attributes["code"].Value;
                string name = node.Attributes["name"].Value;
                areas.Add(code, name);
            }
            foreach (var area in areas)
            {
                var isProv = area.Key.EndsWith("0000");
                var isArea = !isProv && area.Key.EndsWith("00");
                var isCity = !isProv && !isArea;
                AllAreas.Add(new Area()
                {
                    Code = area.Key,
                    ProvName = areas[area.Key.Substring(0, 2).PadRight(6, '0')],
                    AreaName = areas[area.Key.Substring(0, 4).PadRight(6, '0')],
                    CityName = area.Value,
                    IsProv = isProv,
                    IsArea = isArea,
                    IsCity = isCity
                });
            }
        }
        /// <summary>
        /// 解析身份证信息
        /// </summary>
        /// <param name="idCardNumber"></param>
        /// <example>
        ///  IDCardNumber card = IDCardNumber.Get(code);
        /// </example>
        /// <returns>IDCardNumber</returns>
        public static IdCardNumber Get(string idCardNumber)
        {
            if (IdCardNumber.AllAreas.Count < 1)
                IdCardNumber.FillAreas();
            if (!IdCardNumber.CheckIDCardNumber(idCardNumber))
                throw new Exception("非法的身份证号码");
            //
            IdCardNumber cardInfo = new IdCardNumber(idCardNumber);
            return cardInfo;
        }
        /// <summary>
        /// 校验身份证号码是否合法
        /// </summary>
        /// <param name="idCardNumber"></param>
        /// <returns></returns>
        public static bool CheckIDCardNumber(string idCardNumber)
        {
            //正则验证
            Regex rg = new Regex(@"^\d{17}(\d|X)$");
            Match mc = rg.Match(idCardNumber);
            if (!mc.Success) return false;
            //加权码
            string code = idCardNumber.Substring(17, 1);
            double sum = 0;
            string checkCode = null;
            for (int i = 2; i <= 18; i++)
            {
                sum += int.Parse(idCardNumber[18 - i].ToString(), NumberStyles.HexNumber) * (Math.Pow(2, i - 1) % 11);
            }
            string[] checkCodes = { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
            checkCode = checkCodes[(int)sum % 11];
            if (checkCode != code) return false;
            //
            return true;
        }

        /// <summary>
        /// 批量生成身份证
        /// </summary>
        /// <param name="count"></param>
        /// <example> 
        /// List<IDCardNumber> list = IDCardNumber.Radom(number);
        /// </example>
        /// <returns></returns>
        public static List<IdCardNumber> Random(int count,
            string provName = null,
            string areaName = null,
            string cityName = null,
            int? year = null,
            int? month = null,
            int? day = null,
            string sex = null)
        {
            List<IdCardNumber> list = new List<IdCardNumber>();
            string cardNumber;
            bool isExits;
            for (int i = 0; i < count; i++)
            {
                do
                {
                    isExits = false;
                    int tick = (int)DateTime.Now.Ticks;
                    cardNumber = IdCardNumber._randomCardNumber(tick * (i + 1), provName, areaName, cityName, year, month, day, sex);
                    foreach (IdCardNumber c in list)
                    {
                        if (c.CardNumber == cardNumber)
                        {
                            isExits = true;
                            break;
                        }
                    }

                } while (isExits);
                list.Add(new IdCardNumber(cardNumber));
            }
            return list;
        }
        /// <summary>
        /// 生成随身份证号
        /// </summary>
        /// <param name="seed">随机数种子</param>
        /// <returns></returns>
        private static string _randomCardNumber(int seed,
            string provName = null,
            string areaName = null,
            string cityName = null,
            int? year = null,
            int? month = null,
            int? day = null,
            string sex = null)
        {
            if (AllAreas.Count < 1)
                FillAreas();
            Random rd = new Random(seed);
            //随机生成发证地
            string area = "";
            var result = AllAreas.Where(c => c.IsCity).ToArray();
            if (provName != null)
                result = result.Where(c => c.ProvName == provName && c.IsCity).ToArray();
            if (areaName != null)
                result = result.Where(c => c.AreaName == areaName && c.IsCity).ToArray();
            if (cityName != null)
                result = result.Where(c => c.CityName == cityName && c.IsCity).ToArray();
            area = result[rd.Next(0, result.Length - 1)].Code;
            //随机出生日期

            DateTime birthday = DateTime.Now;
            var rbirthday = birthday.AddYears(-rd.Next(16, 60));
            rbirthday = rbirthday.AddMonths(-rd.Next(0, 12));
            rbirthday = rbirthday.AddDays(-rd.Next(0, 31));
            birthday = new DateTime(
                year != null ? Convert.ToInt32(year) : rbirthday.Year,
                month != null ? Convert.ToInt32(month) : rbirthday.Month,
                day != null ? Convert.ToInt32(day) : rbirthday.Day);
            //随机码
            string code = rd.Next(10, 99).ToString("##");
            if (sex != null)
                code = code + (sex == "男" ? getNumber(true) : getNumber(false));
            else
                code = code + rd.Next(0, 9).ToString();
            code = code + rd.Next(0, 9).ToString();
            //生成完整身份证号
            string codeNumber = area + birthday.ToString("yyyyMMdd") + code;
            double sum = 0;
            string checkCode = null;
            for (int i = 2; i <= 18; i++)
            {
                sum += int.Parse(codeNumber[18 - i].ToString(), NumberStyles.HexNumber) * (Math.Pow(2, i - 1) % 11);
            }
            string[] checkCodes = { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
            checkCode = checkCodes[(int)sum % 11];
            codeNumber = codeNumber.Substring(0, 17) + checkCode;
            //
            return codeNumber;
        }
        private static string getNumber(bool s)
        {
            var num = 0;
            Random rd = new Random();
            do
            {
                num = rd.Next(0, 9);
            } while (s ? num % 2 == 0 : num % 2 != 0);
            return num.ToString();
        }
        #endregion

        #region 身份证解析方法

        private IdCardNumber(string idCardNumber)
        {
            this.CardNumber = idCardNumber;
            _analysis();
        }
        /// <summary>
        /// 解析身份证
        /// </summary>
        private void _analysis()
        {
            //取省份，地区，区县
            string cityCode = CardNumber.Substring(0, 6).PadRight(6, '0');
            var city = AllAreas.Find(c => c.Code == cityCode);
            this.Province = city.ProvName;
            this.Area = city.AreaName;
            this.City = city.CityName;
            //取年龄
            string ageCode = CardNumber.Substring(6, 8);
            try
            {
                int year = Convert.ToInt16(ageCode.Substring(0, 4));
                int month = Convert.ToInt16(ageCode.Substring(4, 2));
                int day = Convert.ToInt16(ageCode.Substring(6, 2));
                Birthday = new DateTime(year, month, day);
            }
            catch
            {
                throw new Exception("非法的出生日期");
            }
            //取性别
            string orderCode = CardNumber.Substring(14, 3);
            this.Sex = Convert.ToInt16(orderCode) % 2 == 0 ? 0 : 1;
        }
        #endregion
    }

}
