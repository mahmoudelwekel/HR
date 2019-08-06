namespace HR
{
    partial class employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.employeesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HR.HRDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.salary_txt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rule_list = new System.Windows.Forms.ComboBox();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.nationalid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adress_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status_list = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.day_hours = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.hour_price_txt = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.department_list = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.active_ch = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeruleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeestatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeedayhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeehourpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employees_ViewTableAdapter = new HR.HRDataSetTableAdapters.employees_ViewTableAdapter();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.departmentsTableAdapter = new HR.HRDataSetTableAdapters.departmentsTableAdapter();
            this.rulesTableAdapter = new HR.HRDataSetTableAdapters.rulesTableAdapter();
            this.statusTableAdapter = new HR.HRDataSetTableAdapters.statusTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.employeesTableAdapter = new HR.HRDataSetTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_price_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(679, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "تعريف الموظفين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_txt
            // 
            this.name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "employee_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.name_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(529, 91);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(323, 32);
            this.name_txt.TabIndex = 34;
            // 
            // employeesViewBindingSource
            // 
            this.employeesViewBindingSource.DataMember = "employees_View";
            this.employeesViewBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(858, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(53, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "الأسم";
            // 
            // salary_txt
            // 
            this.salary_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salary_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesViewBindingSource, "employee_salary", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.salary_txt.DecimalPlaces = 2;
            this.salary_txt.Font = new System.Drawing.Font("Cairo", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_txt.Location = new System.Drawing.Point(529, 207);
            this.salary_txt.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(323, 29);
            this.salary_txt.TabIndex = 32;
            this.salary_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(858, 206);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(130, 30);
            this.label7.TabIndex = 31;
            this.label7.Text = "المرتب الأساسى";
            // 
            // rule_list
            // 
            this.rule_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rule_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "rule_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rule_list.DataSource = this.rulesBindingSource;
            this.rule_list.DisplayMember = "rule_name";
            this.rule_list.FormattingEnabled = true;
            this.rule_list.Location = new System.Drawing.Point(11, 131);
            this.rule_list.Name = "rule_list";
            this.rule_list.Size = new System.Drawing.Size(338, 28);
            this.rule_list.TabIndex = 30;
            this.rule_list.ValueMember = "rule_id";
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataMember = "rules";
            this.rulesBindingSource.DataSource = this.hRDataSet;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "الوظيفة";
            // 
            // nationalid_txt
            // 
            this.nationalid_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalid_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "employee_national_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nationalid_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalid_txt.Location = new System.Drawing.Point(529, 129);
            this.nationalid_txt.Name = "nationalid_txt";
            this.nationalid_txt.Size = new System.Drawing.Size(323, 32);
            this.nationalid_txt.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(858, 130);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "الرقم القومى";
            // 
            // phone_txt
            // 
            this.phone_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "employee_phone", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.phone_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(11, 167);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(338, 32);
            this.phone_txt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 168);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 37;
            this.label4.Text = "الهاتف";
            // 
            // adress_txt
            // 
            this.adress_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adress_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "employee_address", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.adress_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_txt.Location = new System.Drawing.Point(529, 167);
            this.adress_txt.Name = "adress_txt";
            this.adress_txt.Size = new System.Drawing.Size(323, 32);
            this.adress_txt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(858, 168);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 30);
            this.label5.TabIndex = 39;
            this.label5.Text = "العنوان";
            // 
            // status_list
            // 
            this.status_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "status_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.status_list.DataSource = this.statusBindingSource;
            this.status_list.DisplayMember = "status_name";
            this.status_list.FormattingEnabled = true;
            this.status_list.Location = new System.Drawing.Point(11, 207);
            this.status_list.Name = "status_list";
            this.status_list.Size = new System.Drawing.Size(338, 28);
            this.status_list.TabIndex = 42;
            this.status_list.ValueMember = "status_id";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.hRDataSet;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 206);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "الحالة الأجتماعية";
            // 
            // day_hours
            // 
            this.day_hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day_hours.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesViewBindingSource, "employee_day_hours", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.day_hours.DecimalPlaces = 2;
            this.day_hours.Font = new System.Drawing.Font("Cairo", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_hours.Location = new System.Drawing.Point(11, 245);
            this.day_hours.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.day_hours.Name = "day_hours";
            this.day_hours.Size = new System.Drawing.Size(338, 29);
            this.day_hours.TabIndex = 44;
            this.day_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 244);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(168, 30);
            this.label9.TabIndex = 43;
            this.label9.Text = "ساعات العمل اليومية";
            // 
            // hour_price_txt
            // 
            this.hour_price_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hour_price_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesViewBindingSource, "employee_hour_price", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.hour_price_txt.DecimalPlaces = 2;
            this.hour_price_txt.Font = new System.Drawing.Font("Cairo", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_price_txt.Location = new System.Drawing.Point(529, 245);
            this.hour_price_txt.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.hour_price_txt.Name = "hour_price_txt";
            this.hour_price_txt.Size = new System.Drawing.Size(323, 29);
            this.hour_price_txt.TabIndex = 46;
            this.hour_price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(858, 244);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(98, 30);
            this.label10.TabIndex = 45;
            this.label10.Text = "سعر الساعة";
            // 
            // department_list
            // 
            this.department_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.department_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesViewBindingSource, "department_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.department_list.DataSource = this.departmentsBindingSource;
            this.department_list.DisplayMember = "department_name";
            this.department_list.FormattingEnabled = true;
            this.department_list.Location = new System.Drawing.Point(205, 93);
            this.department_list.Name = "department_list";
            this.department_list.Size = new System.Drawing.Size(144, 28);
            this.department_list.TabIndex = 48;
            this.department_list.ValueMember = "department_id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.hRDataSet;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 92);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(58, 30);
            this.label11.TabIndex = 47;
            this.label11.Text = "القسم";
            // 
            // active_ch
            // 
            this.active_ch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.active_ch.AutoSize = true;
            this.active_ch.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesViewBindingSource, "active", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.active_ch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_ch.Location = new System.Drawing.Point(11, 90);
            this.active_ch.Name = "active_ch";
            this.active_ch.Size = new System.Drawing.Size(188, 34);
            this.active_ch.TabIndex = 49;
            this.active_ch.Text = "تفعيل / إلغاء التفعيل";
            this.active_ch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.employeeruleidDataGridViewTextBoxColumn,
            this.rulenameDataGridViewTextBoxColumn,
            this.employeenationalidDataGridViewTextBoxColumn,
            this.employeephoneDataGridViewTextBoxColumn,
            this.employeeaddressDataGridViewTextBoxColumn,
            this.employeestatusidDataGridViewTextBoxColumn,
            this.statusnameDataGridViewTextBoxColumn,
            this.employeesalaryDataGridViewTextBoxColumn,
            this.employeedayhoursDataGridViewTextBoxColumn,
            this.employeehourpriceDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.employeesViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(976, 325);
            this.dataGridView1.TabIndex = 50;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeruleidDataGridViewTextBoxColumn
            // 
            this.employeeruleidDataGridViewTextBoxColumn.DataPropertyName = "employee_rule_id";
            this.employeeruleidDataGridViewTextBoxColumn.HeaderText = "employee_rule_id";
            this.employeeruleidDataGridViewTextBoxColumn.Name = "employeeruleidDataGridViewTextBoxColumn";
            this.employeeruleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeruleidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rulenameDataGridViewTextBoxColumn
            // 
            this.rulenameDataGridViewTextBoxColumn.DataPropertyName = "rule_name";
            this.rulenameDataGridViewTextBoxColumn.HeaderText = "الوظيفة";
            this.rulenameDataGridViewTextBoxColumn.Name = "rulenameDataGridViewTextBoxColumn";
            this.rulenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenationalidDataGridViewTextBoxColumn
            // 
            this.employeenationalidDataGridViewTextBoxColumn.DataPropertyName = "employee_national_id";
            this.employeenationalidDataGridViewTextBoxColumn.HeaderText = "رقم الهوية";
            this.employeenationalidDataGridViewTextBoxColumn.Name = "employeenationalidDataGridViewTextBoxColumn";
            this.employeenationalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeephoneDataGridViewTextBoxColumn
            // 
            this.employeephoneDataGridViewTextBoxColumn.DataPropertyName = "employee_phone";
            this.employeephoneDataGridViewTextBoxColumn.HeaderText = "الهاتف";
            this.employeephoneDataGridViewTextBoxColumn.Name = "employeephoneDataGridViewTextBoxColumn";
            this.employeephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeaddressDataGridViewTextBoxColumn
            // 
            this.employeeaddressDataGridViewTextBoxColumn.DataPropertyName = "employee_address";
            this.employeeaddressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.employeeaddressDataGridViewTextBoxColumn.Name = "employeeaddressDataGridViewTextBoxColumn";
            this.employeeaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeestatusidDataGridViewTextBoxColumn
            // 
            this.employeestatusidDataGridViewTextBoxColumn.DataPropertyName = "employee_status_id";
            this.employeestatusidDataGridViewTextBoxColumn.HeaderText = "employee_status_id";
            this.employeestatusidDataGridViewTextBoxColumn.Name = "employeestatusidDataGridViewTextBoxColumn";
            this.employeestatusidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeestatusidDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusnameDataGridViewTextBoxColumn
            // 
            this.statusnameDataGridViewTextBoxColumn.DataPropertyName = "status_name";
            this.statusnameDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.statusnameDataGridViewTextBoxColumn.Name = "statusnameDataGridViewTextBoxColumn";
            this.statusnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesalaryDataGridViewTextBoxColumn
            // 
            this.employeesalaryDataGridViewTextBoxColumn.DataPropertyName = "employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.HeaderText = "الراتب";
            this.employeesalaryDataGridViewTextBoxColumn.Name = "employeesalaryDataGridViewTextBoxColumn";
            this.employeesalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeedayhoursDataGridViewTextBoxColumn
            // 
            this.employeedayhoursDataGridViewTextBoxColumn.DataPropertyName = "employee_day_hours";
            this.employeedayhoursDataGridViewTextBoxColumn.HeaderText = "ساعات العمل ";
            this.employeedayhoursDataGridViewTextBoxColumn.Name = "employeedayhoursDataGridViewTextBoxColumn";
            this.employeedayhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeehourpriceDataGridViewTextBoxColumn
            // 
            this.employeehourpriceDataGridViewTextBoxColumn.DataPropertyName = "employee_hour_price";
            this.employeehourpriceDataGridViewTextBoxColumn.HeaderText = "سعر الساعة";
            this.employeehourpriceDataGridViewTextBoxColumn.Name = "employeehourpriceDataGridViewTextBoxColumn";
            this.employeehourpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            this.departmentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "القسم";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            this.departmentnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "التفعيل";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // employees_ViewTableAdapter
            // 
            this.employees_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(126, 281);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(108, 32);
            this.edit_btn.TabIndex = 55;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(241, 281);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 32);
            this.add_btn.TabIndex = 54;
            this.add_btn.Text = "أضافة";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(11, 281);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(108, 32);
            this.delete_btn.TabIndex = 53;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(529, 281);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(323, 32);
            this.search_txt.TabIndex = 52;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(858, 282);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(55, 30);
            this.label12.TabIndex = 51;
            this.label12.Text = "البحث";
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // rulesTableAdapter
            // 
            this.rulesTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HR.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(612, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::HR.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(544, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.active_ch);
            this.Controls.Add(this.department_list);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hour_price_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.day_hours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.status_list);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adress_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nationalid_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salary_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rule_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "employees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعريف الموظفين";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_price_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown salary_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rule_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nationalid_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adress_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status_list;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown day_hours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown hour_price_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox department_list;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox active_ch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource employeesViewBindingSource;
        private HRDataSetTableAdapters.employees_ViewTableAdapter employees_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeruleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rulenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeestatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeedayhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeehourpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private HRDataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private HRDataSetTableAdapters.rulesTableAdapter rulesTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private HRDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private HRDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}

