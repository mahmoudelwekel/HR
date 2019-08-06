namespace HR
{
    partial class holidays
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(holidays));
            this.label1 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.holidaysViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HR.HRDataSet();
            this.delete_btn = new System.Windows.Forms.Button();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.day_amount_txt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.holiday_type_list = new System.Windows.Forms.ComboBox();
            this.holidaytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.employee_list = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.holidays_ViewTableAdapter = new HR.HRDataSetTableAdapters.holidays_ViewTableAdapter();
            this.employeesTableAdapter = new HR.HRDataSetTableAdapters.employeesTableAdapter();
            this.holiday_typeTableAdapter = new HR.HRDataSetTableAdapters.holiday_typeTableAdapter();
            this.holidaysTableAdapter = new HR.HRDataSetTableAdapters.holidaysTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useremployeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidaytypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidaytypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidaydayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidaydescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedornotDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day_amount_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(752, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "الأجازات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(148, 216);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(127, 32);
            this.edit_btn.TabIndex = 51;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Visible = false;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(284, 216);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(127, 32);
            this.add_btn.TabIndex = 50;
            this.add_btn.Text = "أضافة";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.useremployeenameDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.holidaytypeidDataGridViewTextBoxColumn,
            this.holidaytypenameDataGridViewTextBoxColumn,
            this.numofdaysDataGridViewTextBoxColumn,
            this.holidaydayDataGridViewTextBoxColumn,
            this.holidaydescriptionDataGridViewTextBoxColumn,
            this.payedornotDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.holidaysViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(968, 388);
            this.dataGridView1.TabIndex = 49;
            // 
            // holidaysViewBindingSource
            // 
            this.holidaysViewBindingSource.DataMember = "holidays_View";
            this.holidaysViewBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 215);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(127, 32);
            this.delete_btn.TabIndex = 48;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            // 
            // date_txt
            // 
            this.date_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_txt.Location = new System.Drawing.Point(12, 134);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(400, 32);
            this.date_txt.TabIndex = 47;
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(481, 215);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(396, 32);
            this.search_txt.TabIndex = 46;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(876, 216);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "البحث";
            // 
            // comment_txt
            // 
            this.comment_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comment_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_txt.Location = new System.Drawing.Point(12, 173);
            this.comment_txt.Multiline = true;
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(865, 32);
            this.comment_txt.TabIndex = 44;
            // 
            // day_amount_txt
            // 
            this.day_amount_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day_amount_txt.Font = new System.Drawing.Font("Cairo", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_amount_txt.Location = new System.Drawing.Point(481, 136);
            this.day_amount_txt.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day_amount_txt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day_amount_txt.Name = "day_amount_txt";
            this.day_amount_txt.Size = new System.Drawing.Size(396, 29);
            this.day_amount_txt.TabIndex = 43;
            this.day_amount_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.day_amount_txt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 135);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 42;
            this.label7.Text = "عدد الأيام";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 174);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "الكومنت";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 135);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "عن يوم";
            // 
            // holiday_type_list
            // 
            this.holiday_type_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.holiday_type_list.DataSource = this.holidaytypeBindingSource;
            this.holiday_type_list.DisplayMember = "holiday_type_name";
            this.holiday_type_list.FormattingEnabled = true;
            this.holiday_type_list.Location = new System.Drawing.Point(12, 100);
            this.holiday_type_list.Name = "holiday_type_list";
            this.holiday_type_list.Size = new System.Drawing.Size(399, 28);
            this.holiday_type_list.TabIndex = 39;
            this.holiday_type_list.ValueMember = "holiday_type_id";
            // 
            // holidaytypeBindingSource
            // 
            this.holidaytypeBindingSource.DataMember = "holiday_type";
            this.holidaytypeBindingSource.DataSource = this.hRDataSet;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 99);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "النوع";
            // 
            // employee_list
            // 
            this.employee_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_list.DataSource = this.employeesBindingSource;
            this.employee_list.DisplayMember = "employee_name";
            this.employee_list.FormattingEnabled = true;
            this.employee_list.Location = new System.Drawing.Point(481, 100);
            this.employee_list.Name = "employee_list";
            this.employee_list.Size = new System.Drawing.Size(396, 28);
            this.employee_list.TabIndex = 37;
            this.employee_list.ValueMember = "employee_id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.hRDataSet;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(876, 99);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "أسم الموظف";
            // 
            // holidays_ViewTableAdapter
            // 
            this.holidays_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // holiday_typeTableAdapter
            // 
            this.holiday_typeTableAdapter.ClearBeforeFill = true;
            // 
            // holidaysTableAdapter
            // 
            this.holidaysTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HR.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(616, 14);
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
            this.pictureBox1.Location = new System.Drawing.Point(684, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            // 
            // useremployeenameDataGridViewTextBoxColumn
            // 
            this.useremployeenameDataGridViewTextBoxColumn.DataPropertyName = "user_employee_name";
            this.useremployeenameDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.useremployeenameDataGridViewTextBoxColumn.Name = "useremployeenameDataGridViewTextBoxColumn";
            this.useremployeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeenameDataGridViewTextBoxColumn.Width = 73;
            // 
            // holidaytypeidDataGridViewTextBoxColumn
            // 
            this.holidaytypeidDataGridViewTextBoxColumn.DataPropertyName = "holiday_type_id";
            this.holidaytypeidDataGridViewTextBoxColumn.HeaderText = "holiday_type_id";
            this.holidaytypeidDataGridViewTextBoxColumn.Name = "holidaytypeidDataGridViewTextBoxColumn";
            this.holidaytypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.holidaytypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // holidaytypenameDataGridViewTextBoxColumn
            // 
            this.holidaytypenameDataGridViewTextBoxColumn.DataPropertyName = "holiday_type_name";
            this.holidaytypenameDataGridViewTextBoxColumn.HeaderText = "النوع";
            this.holidaytypenameDataGridViewTextBoxColumn.Name = "holidaytypenameDataGridViewTextBoxColumn";
            this.holidaytypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numofdaysDataGridViewTextBoxColumn
            // 
            this.numofdaysDataGridViewTextBoxColumn.DataPropertyName = "num_of_days";
            this.numofdaysDataGridViewTextBoxColumn.HeaderText = "عدد الأيام";
            this.numofdaysDataGridViewTextBoxColumn.Name = "numofdaysDataGridViewTextBoxColumn";
            this.numofdaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holidaydayDataGridViewTextBoxColumn
            // 
            this.holidaydayDataGridViewTextBoxColumn.DataPropertyName = "holiday_day";
            this.holidaydayDataGridViewTextBoxColumn.HeaderText = "عن يوم";
            this.holidaydayDataGridViewTextBoxColumn.Name = "holidaydayDataGridViewTextBoxColumn";
            this.holidaydayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holidaydescriptionDataGridViewTextBoxColumn
            // 
            this.holidaydescriptionDataGridViewTextBoxColumn.DataPropertyName = "holiday_description";
            this.holidaydescriptionDataGridViewTextBoxColumn.HeaderText = "الكومنت";
            this.holidaydescriptionDataGridViewTextBoxColumn.Name = "holidaydescriptionDataGridViewTextBoxColumn";
            this.holidaydescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payedornotDataGridViewCheckBoxColumn
            // 
            this.payedornotDataGridViewCheckBoxColumn.DataPropertyName = "payed_or_not";
            this.payedornotDataGridViewCheckBoxColumn.HeaderText = "مدفوعة";
            this.payedornotDataGridViewCheckBoxColumn.Name = "payedornotDataGridViewCheckBoxColumn";
            this.payedornotDataGridViewCheckBoxColumn.ReadOnly = true;
            this.payedornotDataGridViewCheckBoxColumn.Visible = false;
            // 
            // holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comment_txt);
            this.Controls.Add(this.day_amount_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.holiday_type_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employee_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "holidays";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.holidays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day_amount_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox comment_txt;
        private System.Windows.Forms.NumericUpDown day_amount_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox holiday_type_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox employee_list;
        private System.Windows.Forms.Label label3;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource holidaysViewBindingSource;
        private HRDataSetTableAdapters.holidays_ViewTableAdapter holidays_ViewTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource holidaytypeBindingSource;
        private HRDataSetTableAdapters.holiday_typeTableAdapter holiday_typeTableAdapter;
        private HRDataSetTableAdapters.holidaysTableAdapter holidaysTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useremployeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidaytypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidaytypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidaydayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidaydescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedornotDataGridViewCheckBoxColumn;
    }
}

