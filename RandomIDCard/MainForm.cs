using RandomIDCard.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomIDCard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = IdCardNumber.Random(1,
                prov_list.Text == "随机" ? null : prov_list.Text,
                area_list.Text == "随机" ? null : area_list.Text,
                city_list.Text == "随机" ? null : city_list.Text,
                date_random_year.Checked ? null : (int?)int.Parse(date_year.Value.ToString()),
                date_random_month.Checked ? null : (int?)int.Parse(date_month.Value.ToString()),
                date_random_day.Checked ? null : (int?)int.Parse(date_day.Value.ToString()),
                sex_list.Text == "随机" ? null : sex_list.Text
            );
            foreach (var item in result)
            {
                var listItem = new ListViewItem();
                listItem.Text = item.CardNumber;
                listItem.SubItems.Add(item.Province);
                listItem.SubItems.Add(item.Area);
                listItem.SubItems.Add(item.City);
                listItem.SubItems.Add(item.Birthday.ToString("yyyy-MM-dd"));
                listItem.SubItems.Add(item.Sex == 1 ? "男" : "女");
                result_list.Items.Add(listItem);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initList();
        }
        private void initList()
        {
            IdCardNumber.FillAreas();
            prov_list.Items.Add("随机");
            var provs = IdCardNumber.AllAreas.Where(c => c.IsProv);
            foreach (var item in provs)
            {
                prov_list.Items.Add(item.ProvName);
            }
            area_list.Items.Add("随机");
            city_list.Items.Add("随机");
            sex_list.Items.Add("随机");
            prov_list.SelectedIndex = 0;
            sex_list.SelectedIndex = 0;
        }

        private void prov_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            area_list.Items.Clear();
            var areas = IdCardNumber.AllAreas.Where(
                        c => c.IsArea &&
                        c.ProvName == prov_list.Text);
            area_list.Items.Add("随机");
            area_list.Items.AddRange(areas.Select(c => c.AreaName).ToArray());
            area_list.SelectedIndex = area_list.Items.Count > 2 ? 1 : 0;
        }

        private void area_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            city_list.Items.Clear();
            var citys = IdCardNumber.AllAreas.Where(
                        c => c.IsCity &&
                        c.AreaName == area_list.Text &&
                        c.ProvName == prov_list.Text);
            city_list.Items.Add("随机");
            city_list.Items.AddRange(citys.Select(c => c.CityName).ToArray());
            city_list.SelectedIndex = city_list.Items.Count > 2 ? 1 : 0;
        }

        private void date_random_year_CheckedChanged(object sender, EventArgs e)
        {
            date_year.Enabled = !date_random_year.Checked;
        }

        private void date_random_month_CheckedChanged(object sender, EventArgs e)
        {
            date_month.Enabled = !date_random_month.Checked;
        }

        private void date_random_day_CheckedChanged(object sender, EventArgs e)
        {
            date_day.Enabled = !date_random_day.Checked;
        }

        private void copy_menu_Click(object sender, EventArgs e)
        {
            if (result_list.SelectedItems.Count > 0)
            {
                Clipboard.SetText(result_list.SelectedItems[0].Text);
            }
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            result_list.Items.Clear();
        }
    }
}
