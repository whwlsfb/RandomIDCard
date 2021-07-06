
namespace RandomIDCard
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.prov_list = new System.Windows.Forms.ComboBox();
            this.area_list = new System.Windows.Forms.ComboBox();
            this.city_list = new System.Windows.Forms.ComboBox();
            this.sex_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_year = new System.Windows.Forms.NumericUpDown();
            this.date_month = new System.Windows.Forms.NumericUpDown();
            this.date_day = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_random_year = new System.Windows.Forms.CheckBox();
            this.date_random_month = new System.Windows.Forms.CheckBox();
            this.date_random_day = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result_list = new System.Windows.Forms.ListView();
            this.id_number_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prov_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.area_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.date_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_day)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.list_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prov_list
            // 
            this.prov_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prov_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prov_list.FormattingEnabled = true;
            this.prov_list.Location = new System.Drawing.Point(90, 20);
            this.prov_list.Name = "prov_list";
            this.prov_list.Size = new System.Drawing.Size(149, 20);
            this.prov_list.TabIndex = 1;
            this.prov_list.SelectedIndexChanged += new System.EventHandler(this.prov_list_SelectedIndexChanged);
            // 
            // area_list
            // 
            this.area_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.area_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_list.FormattingEnabled = true;
            this.area_list.Location = new System.Drawing.Point(90, 46);
            this.area_list.Name = "area_list";
            this.area_list.Size = new System.Drawing.Size(149, 20);
            this.area_list.TabIndex = 2;
            this.area_list.SelectedIndexChanged += new System.EventHandler(this.area_list_SelectedIndexChanged);
            // 
            // city_list
            // 
            this.city_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city_list.FormattingEnabled = true;
            this.city_list.Location = new System.Drawing.Point(90, 72);
            this.city_list.Name = "city_list";
            this.city_list.Size = new System.Drawing.Size(149, 20);
            this.city_list.TabIndex = 2;
            // 
            // sex_list
            // 
            this.sex_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sex_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_list.FormattingEnabled = true;
            this.sex_list.Items.AddRange(new object[] {
            "随机",
            "男",
            "女"});
            this.sex_list.Location = new System.Drawing.Point(90, 98);
            this.sex_list.Name = "sex_list";
            this.sex_list.Size = new System.Drawing.Size(149, 20);
            this.sex_list.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "省：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "市：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "县（区）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // date_year
            // 
            this.date_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_year.Enabled = false;
            this.date_year.Location = new System.Drawing.Point(291, 60);
            this.date_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.date_year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.date_year.Name = "date_year";
            this.date_year.Size = new System.Drawing.Size(47, 21);
            this.date_year.TabIndex = 4;
            this.date_year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // date_month
            // 
            this.date_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_month.Enabled = false;
            this.date_month.Location = new System.Drawing.Point(380, 60);
            this.date_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.date_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.date_month.Name = "date_month";
            this.date_month.Size = new System.Drawing.Size(47, 21);
            this.date_month.TabIndex = 4;
            this.date_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // date_day
            // 
            this.date_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_day.Enabled = false;
            this.date_day.Location = new System.Drawing.Point(470, 60);
            this.date_day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.date_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.date_day.Name = "date_day";
            this.date_day.Size = new System.Drawing.Size(47, 21);
            this.date_day.TabIndex = 4;
            this.date_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "年：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "月：";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "日：";
            // 
            // date_random_year
            // 
            this.date_random_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_random_year.AutoSize = true;
            this.date_random_year.Checked = true;
            this.date_random_year.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_random_year.Location = new System.Drawing.Point(291, 38);
            this.date_random_year.Name = "date_random_year";
            this.date_random_year.Size = new System.Drawing.Size(48, 16);
            this.date_random_year.TabIndex = 6;
            this.date_random_year.Text = "随机";
            this.date_random_year.UseVisualStyleBackColor = true;
            this.date_random_year.CheckedChanged += new System.EventHandler(this.date_random_year_CheckedChanged);
            // 
            // date_random_month
            // 
            this.date_random_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_random_month.AutoSize = true;
            this.date_random_month.Checked = true;
            this.date_random_month.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_random_month.Location = new System.Drawing.Point(380, 38);
            this.date_random_month.Name = "date_random_month";
            this.date_random_month.Size = new System.Drawing.Size(48, 16);
            this.date_random_month.TabIndex = 6;
            this.date_random_month.Text = "随机";
            this.date_random_month.UseVisualStyleBackColor = true;
            this.date_random_month.CheckedChanged += new System.EventHandler(this.date_random_month_CheckedChanged);
            // 
            // date_random_day
            // 
            this.date_random_day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_random_day.AutoSize = true;
            this.date_random_day.Checked = true;
            this.date_random_day.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_random_day.Location = new System.Drawing.Point(469, 38);
            this.date_random_day.Name = "date_random_day";
            this.date_random_day.Size = new System.Drawing.Size(48, 16);
            this.date_random_day.TabIndex = 6;
            this.date_random_day.Text = "随机";
            this.date_random_day.UseVisualStyleBackColor = true;
            this.date_random_day.CheckedChanged += new System.EventHandler(this.date_random_day_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.prov_list);
            this.groupBox1.Controls.Add(this.date_random_day);
            this.groupBox1.Controls.Add(this.area_list);
            this.groupBox1.Controls.Add(this.date_random_month);
            this.groupBox1.Controls.Add(this.city_list);
            this.groupBox1.Controls.Add(this.date_random_year);
            this.groupBox1.Controls.Add(this.sex_list);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_day);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_month);
            this.groupBox1.Controls.Add(this.date_year);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "随机设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(548, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // result_list
            // 
            this.result_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_number_col,
            this.prov_col,
            this.area_col,
            this.city_col,
            this.birthday_col,
            this.sex_col});
            this.result_list.ContextMenuStrip = this.list_menu;
            this.result_list.FullRowSelect = true;
            this.result_list.HideSelection = false;
            this.result_list.Location = new System.Drawing.Point(12, 152);
            this.result_list.Name = "result_list";
            this.result_list.Size = new System.Drawing.Size(619, 233);
            this.result_list.TabIndex = 9;
            this.result_list.UseCompatibleStateImageBehavior = false;
            this.result_list.View = System.Windows.Forms.View.Details;
            // 
            // id_number_col
            // 
            this.id_number_col.Text = "身份证号码";
            this.id_number_col.Width = 122;
            // 
            // prov_col
            // 
            this.prov_col.Text = "省";
            this.prov_col.Width = 110;
            // 
            // area_col
            // 
            this.area_col.Text = "市";
            // 
            // city_col
            // 
            this.city_col.Text = "县（区）";
            this.city_col.Width = 132;
            // 
            // birthday_col
            // 
            this.birthday_col.Text = "出生年月日";
            this.birthday_col.Width = 126;
            // 
            // sex_col
            // 
            this.sex_col.Text = "性别";
            this.sex_col.Width = 52;
            // 
            // list_menu
            // 
            this.list_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_menu,
            this.clear_menu});
            this.list_menu.Name = "list_menu";
            this.list_menu.Size = new System.Drawing.Size(101, 48);
            // 
            // copy_menu
            // 
            this.copy_menu.Name = "copy_menu";
            this.copy_menu.Size = new System.Drawing.Size(100, 22);
            this.copy_menu.Text = "复制";
            this.copy_menu.Click += new System.EventHandler(this.copy_menu_Click);
            // 
            // clear_menu
            // 
            this.clear_menu.Name = "clear_menu";
            this.clear_menu.Size = new System.Drawing.Size(100, 22);
            this.clear_menu.Text = "清空";
            this.clear_menu.Click += new System.EventHandler(this.clear_menu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.result_list);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "随机身份证号码生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_day)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.list_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox prov_list;
        private System.Windows.Forms.ComboBox area_list;
        private System.Windows.Forms.ComboBox city_list;
        private System.Windows.Forms.ComboBox sex_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown date_year;
        private System.Windows.Forms.NumericUpDown date_month;
        private System.Windows.Forms.NumericUpDown date_day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox date_random_year;
        private System.Windows.Forms.CheckBox date_random_month;
        private System.Windows.Forms.CheckBox date_random_day;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView result_list;
        private System.Windows.Forms.ColumnHeader id_number_col;
        private System.Windows.Forms.ColumnHeader prov_col;
        private System.Windows.Forms.ColumnHeader area_col;
        private System.Windows.Forms.ColumnHeader city_col;
        private System.Windows.Forms.ColumnHeader sex_col;
        private System.Windows.Forms.ColumnHeader birthday_col;
        private System.Windows.Forms.ContextMenuStrip list_menu;
        private System.Windows.Forms.ToolStripMenuItem copy_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
    }
}

