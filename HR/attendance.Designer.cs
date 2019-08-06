namespace HR
{
    partial class attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.going_rd = new System.Windows.Forms.RadioButton();
            this.comming_rd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employee_list = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HR.HRDataSet();
            this.submit_btn = new System.Windows.Forms.Button();
            this.employee_id = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancecomingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancegoingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancedayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancemonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workedhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new HR.HRDataSetTableAdapters.employeesTableAdapter();
            this.attendanceTableAdapter = new HR.HRDataSetTableAdapters.attendanceTableAdapter();
            this.attendance_ViewTableAdapter = new HR.HRDataSetTableAdapters.attendance_ViewTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceViewBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(141, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "الحضور و الأنصراف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.going_rd);
            this.groupBox1.Controls.Add(this.comming_rd);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(470, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع التسجيل";
            // 
            // going_rd
            // 
            this.going_rd.AutoSize = true;
            this.going_rd.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.going_rd.Location = new System.Drawing.Point(229, 27);
            this.going_rd.Name = "going_rd";
            this.going_rd.Size = new System.Drawing.Size(120, 30);
            this.going_rd.TabIndex = 1;
            this.going_rd.Text = "تسجيل أنصراف";
            this.going_rd.UseVisualStyleBackColor = true;
            // 
            // comming_rd
            // 
            this.comming_rd.AutoSize = true;
            this.comming_rd.Checked = true;
            this.comming_rd.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comming_rd.Location = new System.Drawing.Point(355, 27);
            this.comming_rd.Name = "comming_rd";
            this.comming_rd.Size = new System.Drawing.Size(109, 30);
            this.comming_rd.TabIndex = 0;
            this.comming_rd.TabStop = true;
            this.comming_rd.Text = "تسجيل حضور";
            this.comming_rd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 146);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقم الموظف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 180);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "أسم الموظف";
            // 
            // employee_list
            // 
            this.employee_list.DataSource = this.employeesBindingSource;
            this.employee_list.DisplayMember = "employee_name";
            this.employee_list.FormattingEnabled = true;
            this.employee_list.Location = new System.Drawing.Point(12, 181);
            this.employee_list.Name = "employee_list";
            this.employee_list.Size = new System.Drawing.Size(365, 28);
            this.employee_list.TabIndex = 13;
            this.employee_list.ValueMember = "employee_id";
            this.employee_list.SelectedIndexChanged += new System.EventHandler(this.employee_list_SelectedIndexChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(12, 215);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(470, 40);
            this.submit_btn.TabIndex = 14;
            this.submit_btn.Text = "تسجيل";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // employee_id
            // 
            this.employee_id.Font = new System.Drawing.Font("Cairo", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id.Location = new System.Drawing.Point(12, 147);
            this.employee_id.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(365, 29);
            this.employee_id.TabIndex = 15;
            this.employee_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.employee_id.ValueChanged += new System.EventHandler(this.employee_id_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.attendancecomingtimeDataGridViewTextBoxColumn,
            this.attendancegoingtimeDataGridViewTextBoxColumn,
            this.attendancedayDataGridViewTextBoxColumn,
            this.attendancemonthDataGridViewTextBoxColumn,
            this.attendanceyearDataGridViewTextBoxColumn,
            this.workedhoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceViewBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(13, 262);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 279);
            this.dataGridView1.TabIndex = 16;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Width = 57;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendancecomingtimeDataGridViewTextBoxColumn
            // 
            this.attendancecomingtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendancecomingtimeDataGridViewTextBoxColumn.DataPropertyName = "attendance_coming_time";
            this.attendancecomingtimeDataGridViewTextBoxColumn.HeaderText = "الحضور";
            this.attendancecomingtimeDataGridViewTextBoxColumn.Name = "attendancecomingtimeDataGridViewTextBoxColumn";
            this.attendancecomingtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendancecomingtimeDataGridViewTextBoxColumn.Width = 66;
            // 
            // attendancegoingtimeDataGridViewTextBoxColumn
            // 
            this.attendancegoingtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attendancegoingtimeDataGridViewTextBoxColumn.DataPropertyName = "attendance_going_time";
            this.attendancegoingtimeDataGridViewTextBoxColumn.HeaderText = "الأنصراف";
            this.attendancegoingtimeDataGridViewTextBoxColumn.Name = "attendancegoingtimeDataGridViewTextBoxColumn";
            this.attendancegoingtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendancegoingtimeDataGridViewTextBoxColumn.Width = 74;
            // 
            // attendancedayDataGridViewTextBoxColumn
            // 
            this.attendancedayDataGridViewTextBoxColumn.DataPropertyName = "attendance_day";
            this.attendancedayDataGridViewTextBoxColumn.HeaderText = "attendance_day";
            this.attendancedayDataGridViewTextBoxColumn.Name = "attendancedayDataGridViewTextBoxColumn";
            this.attendancedayDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendancedayDataGridViewTextBoxColumn.Visible = false;
            // 
            // attendancemonthDataGridViewTextBoxColumn
            // 
            this.attendancemonthDataGridViewTextBoxColumn.DataPropertyName = "attendance_month";
            this.attendancemonthDataGridViewTextBoxColumn.HeaderText = "attendance_month";
            this.attendancemonthDataGridViewTextBoxColumn.Name = "attendancemonthDataGridViewTextBoxColumn";
            this.attendancemonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendancemonthDataGridViewTextBoxColumn.Visible = false;
            // 
            // attendanceyearDataGridViewTextBoxColumn
            // 
            this.attendanceyearDataGridViewTextBoxColumn.DataPropertyName = "attendance_year";
            this.attendanceyearDataGridViewTextBoxColumn.HeaderText = "attendance_year";
            this.attendanceyearDataGridViewTextBoxColumn.Name = "attendanceyearDataGridViewTextBoxColumn";
            this.attendanceyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceyearDataGridViewTextBoxColumn.Visible = false;
            // 
            // workedhoursDataGridViewTextBoxColumn
            // 
            this.workedhoursDataGridViewTextBoxColumn.DataPropertyName = "worked_hours";
            this.workedhoursDataGridViewTextBoxColumn.HeaderText = "ساعات العمل";
            this.workedhoursDataGridViewTextBoxColumn.Name = "workedhoursDataGridViewTextBoxColumn";
            this.workedhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceViewBindingSource
            // 
            this.attendanceViewBindingSource.DataMember = "attendance_View";
            this.attendanceViewBindingSource.DataSource = this.hRDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendance_ViewTableAdapter
            // 
            this.attendance_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HR.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(37, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
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
            this.pictureBox1.Location = new System.Drawing.Point(89, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employee_id);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.employee_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "attendance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحضور و الأنصراف";
            this.Load += new System.EventHandler(this.attendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton going_rd;
        private System.Windows.Forms.RadioButton comming_rd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox employee_list;
        private System.Windows.Forms.Button submit_btn;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HRDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.NumericUpDown employee_id;
        private HRDataSetTableAdapters.attendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource attendanceViewBindingSource;
        private HRDataSetTableAdapters.attendance_ViewTableAdapter attendance_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancecomingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancegoingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancedayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancemonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

