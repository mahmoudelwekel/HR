namespace HR
{
    partial class users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.employeesactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usercurrentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HR.HRDataSet();
            this.active_ch = new System.Windows.Forms.CheckBox();
            this.printer_list = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employee_list = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_ViewTableAdapter = new HR.HRDataSetTableAdapters.users_ViewTableAdapter();
            this.usersTableAdapter = new HR.HRDataSetTableAdapters.usersTableAdapter();
            this.employeesTableAdapter = new HR.HRDataSetTableAdapters.employeesTableAdapter();
            this.password_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(592, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "تعريف المستخدمين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HR.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(456, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HR.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(524, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(128, 165);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(108, 32);
            this.edit_btn.TabIndex = 86;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(243, 165);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 32);
            this.add_btn.TabIndex = 85;
            this.add_btn.Text = "أضافة";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(13, 165);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(108, 32);
            this.delete_btn.TabIndex = 84;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(531, 165);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(323, 32);
            this.search_txt.TabIndex = 83;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(860, 166);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(55, 30);
            this.label12.TabIndex = 82;
            this.label12.Text = "البحث";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeridDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userpasswordDataGridViewTextBoxColumn,
            this.printernameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
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
            this.employeesactiveDataGridViewCheckBoxColumn,
            this.usercurrentdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersViewBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(14, 203);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(976, 443);
            this.dataGridView1.TabIndex = 81;
            // 
            // employeridDataGridViewTextBoxColumn
            // 
            this.employeridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeridDataGridViewTextBoxColumn.DataPropertyName = "employer_id";
            this.employeridDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.employeridDataGridViewTextBoxColumn.Name = "employeridDataGridViewTextBoxColumn";
            this.employeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeridDataGridViewTextBoxColumn.Width = 57;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "user_password";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "كلمة المرور";
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printernameDataGridViewTextBoxColumn
            // 
            this.printernameDataGridViewTextBoxColumn.DataPropertyName = "printer_name";
            this.printernameDataGridViewTextBoxColumn.HeaderText = "الطابعة";
            this.printernameDataGridViewTextBoxColumn.Name = "printernameDataGridViewTextBoxColumn";
            this.printernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "التفعيل";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
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
            this.rulenameDataGridViewTextBoxColumn.HeaderText = "rule_name";
            this.rulenameDataGridViewTextBoxColumn.Name = "rulenameDataGridViewTextBoxColumn";
            this.rulenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.rulenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeenationalidDataGridViewTextBoxColumn
            // 
            this.employeenationalidDataGridViewTextBoxColumn.DataPropertyName = "employee_national_id";
            this.employeenationalidDataGridViewTextBoxColumn.HeaderText = "employee_national_id";
            this.employeenationalidDataGridViewTextBoxColumn.Name = "employeenationalidDataGridViewTextBoxColumn";
            this.employeenationalidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeenationalidDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeephoneDataGridViewTextBoxColumn
            // 
            this.employeephoneDataGridViewTextBoxColumn.DataPropertyName = "employee_phone";
            this.employeephoneDataGridViewTextBoxColumn.HeaderText = "employee_phone";
            this.employeephoneDataGridViewTextBoxColumn.Name = "employeephoneDataGridViewTextBoxColumn";
            this.employeephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeephoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeaddressDataGridViewTextBoxColumn
            // 
            this.employeeaddressDataGridViewTextBoxColumn.DataPropertyName = "employee_address";
            this.employeeaddressDataGridViewTextBoxColumn.HeaderText = "employee_address";
            this.employeeaddressDataGridViewTextBoxColumn.Name = "employeeaddressDataGridViewTextBoxColumn";
            this.employeeaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeaddressDataGridViewTextBoxColumn.Visible = false;
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
            this.statusnameDataGridViewTextBoxColumn.HeaderText = "status_name";
            this.statusnameDataGridViewTextBoxColumn.Name = "statusnameDataGridViewTextBoxColumn";
            this.statusnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeesalaryDataGridViewTextBoxColumn
            // 
            this.employeesalaryDataGridViewTextBoxColumn.DataPropertyName = "employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.HeaderText = "employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.Name = "employeesalaryDataGridViewTextBoxColumn";
            this.employeesalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeesalaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeedayhoursDataGridViewTextBoxColumn
            // 
            this.employeedayhoursDataGridViewTextBoxColumn.DataPropertyName = "employee_day_hours";
            this.employeedayhoursDataGridViewTextBoxColumn.HeaderText = "employee_day_hours";
            this.employeedayhoursDataGridViewTextBoxColumn.Name = "employeedayhoursDataGridViewTextBoxColumn";
            this.employeedayhoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeedayhoursDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeehourpriceDataGridViewTextBoxColumn
            // 
            this.employeehourpriceDataGridViewTextBoxColumn.DataPropertyName = "employee_hour_price";
            this.employeehourpriceDataGridViewTextBoxColumn.HeaderText = "employee_hour_price";
            this.employeehourpriceDataGridViewTextBoxColumn.Name = "employeehourpriceDataGridViewTextBoxColumn";
            this.employeehourpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeehourpriceDataGridViewTextBoxColumn.Visible = false;
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
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "department_name";
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            this.departmentnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeesactiveDataGridViewCheckBoxColumn
            // 
            this.employeesactiveDataGridViewCheckBoxColumn.DataPropertyName = "employees_active";
            this.employeesactiveDataGridViewCheckBoxColumn.HeaderText = "employees_active";
            this.employeesactiveDataGridViewCheckBoxColumn.Name = "employeesactiveDataGridViewCheckBoxColumn";
            this.employeesactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.employeesactiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // usercurrentdateDataGridViewTextBoxColumn
            // 
            this.usercurrentdateDataGridViewTextBoxColumn.DataPropertyName = "user_current_date";
            this.usercurrentdateDataGridViewTextBoxColumn.HeaderText = "user_current_date";
            this.usercurrentdateDataGridViewTextBoxColumn.Name = "usercurrentdateDataGridViewTextBoxColumn";
            this.usercurrentdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.usercurrentdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersViewBindingSource
            // 
            this.usersViewBindingSource.DataMember = "users_View";
            this.usersViewBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // active_ch
            // 
            this.active_ch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.active_ch.AutoSize = true;
            this.active_ch.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersViewBindingSource, "active", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.active_ch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_ch.Location = new System.Drawing.Point(13, 90);
            this.active_ch.Name = "active_ch";
            this.active_ch.Size = new System.Drawing.Size(188, 34);
            this.active_ch.TabIndex = 80;
            this.active_ch.Text = "تفعيل / إلغاء التفعيل";
            this.active_ch.UseVisualStyleBackColor = true;
            // 
            // printer_list
            // 
            this.printer_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printer_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersViewBindingSource, "printer_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.printer_list.DisplayMember = "department_name";
            this.printer_list.FormattingEnabled = true;
            this.printer_list.Location = new System.Drawing.Point(207, 93);
            this.printer_list.Name = "printer_list";
            this.printer_list.Size = new System.Drawing.Size(144, 28);
            this.printer_list.TabIndex = 79;
            this.printer_list.ValueMember = "department_id";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(357, 92);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(69, 30);
            this.label11.TabIndex = 78;
            this.label11.Text = "الطابعة";
            // 
            // username_txt
            // 
            this.username_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersViewBindingSource, "user_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.username_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(531, 127);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(323, 32);
            this.username_txt.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 128);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "أسم المستخدم";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(860, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 64;
            this.label6.Text = "الموظف";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "كلمة المرور";
            // 
            // employee_list
            // 
            this.employee_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersViewBindingSource, "employee_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.employee_list.DataSource = this.employeesBindingSource;
            this.employee_list.DisplayMember = "employee_name";
            this.employee_list.FormattingEnabled = true;
            this.employee_list.Location = new System.Drawing.Point(531, 93);
            this.employee_list.Name = "employee_list";
            this.employee_list.Size = new System.Drawing.Size(323, 28);
            this.employee_list.TabIndex = 87;
            this.employee_list.ValueMember = "employee_id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.hRDataSet;
            // 
            // users_ViewTableAdapter
            // 
            this.users_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // password_txt
            // 
            this.password_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersViewBindingSource, "user_password", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.password_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(14, 127);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(337, 32);
            this.password_txt.TabIndex = 67;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.employee_list);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.active_ch);
            this.Controls.Add(this.printer_list);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox active_ch;
        private System.Windows.Forms.ComboBox printer_list;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox employee_list;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource usersViewBindingSource;
        private HRDataSetTableAdapters.users_ViewTableAdapter users_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn employeesactiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercurrentdateDataGridViewTextBoxColumn;
        private HRDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox password_txt;
    }
}

