namespace HR
{
    partial class deductions
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deduction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductiontypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductiontypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negativevalueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deductionsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new HR.HRDataSet();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rule_list = new System.Windows.Forms.ComboBox();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.deduction_type_list = new System.Windows.Forms.ComboBox();
            this.deductiontypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulesTableAdapter = new HR.HRDataSetTableAdapters.rulesTableAdapter();
            this.deduction_typesTableAdapter = new HR.HRDataSetTableAdapters.deduction_typesTableAdapter();
            this.deductions_ViewTableAdapter = new HR.HRDataSetTableAdapters.deductions_ViewTableAdapter();
            this.deductionsTableAdapter = new HR.HRDataSetTableAdapters.deductionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductiontypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(633, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "تعريف الأستقطاعات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HR.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(497, 14);
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
            this.pictureBox1.Location = new System.Drawing.Point(565, 14);
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
            this.edit_btn.Location = new System.Drawing.Point(121, 129);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(92, 32);
            this.edit_btn.TabIndex = 96;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(228, 130);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(92, 32);
            this.add_btn.TabIndex = 95;
            this.add_btn.Text = "أضافة";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(14, 129);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(92, 32);
            this.delete_btn.TabIndex = 94;
            this.delete_btn.Text = "حذف";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(336, 129);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(572, 32);
            this.search_txt.TabIndex = 93;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(914, 130);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(55, 30);
            this.label12.TabIndex = 92;
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
            this.deduction_id,
            this.ruleidDataGridViewTextBoxColumn,
            this.rulenameDataGridViewTextBoxColumn,
            this.deductiontypeidDataGridViewTextBoxColumn,
            this.deductiontypenameDataGridViewTextBoxColumn,
            this.deductionamountDataGridViewTextBoxColumn,
            this.negativevalueDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.deductionsViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(14, 167);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(976, 479);
            this.dataGridView1.TabIndex = 91;
            // 
            // deduction_id
            // 
            this.deduction_id.DataPropertyName = "deduction_id";
            this.deduction_id.HeaderText = "deduction_id";
            this.deduction_id.Name = "deduction_id";
            this.deduction_id.ReadOnly = true;
            this.deduction_id.Visible = false;
            // 
            // ruleidDataGridViewTextBoxColumn
            // 
            this.ruleidDataGridViewTextBoxColumn.DataPropertyName = "rule_id";
            this.ruleidDataGridViewTextBoxColumn.HeaderText = "rule_id";
            this.ruleidDataGridViewTextBoxColumn.Name = "ruleidDataGridViewTextBoxColumn";
            this.ruleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ruleidDataGridViewTextBoxColumn.Visible = false;
            // 
            // rulenameDataGridViewTextBoxColumn
            // 
            this.rulenameDataGridViewTextBoxColumn.DataPropertyName = "rule_name";
            this.rulenameDataGridViewTextBoxColumn.HeaderText = "الوظيفة";
            this.rulenameDataGridViewTextBoxColumn.Name = "rulenameDataGridViewTextBoxColumn";
            this.rulenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductiontypeidDataGridViewTextBoxColumn
            // 
            this.deductiontypeidDataGridViewTextBoxColumn.DataPropertyName = "deduction_type_id";
            this.deductiontypeidDataGridViewTextBoxColumn.HeaderText = "deduction_type_id";
            this.deductiontypeidDataGridViewTextBoxColumn.Name = "deductiontypeidDataGridViewTextBoxColumn";
            this.deductiontypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductiontypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // deductiontypenameDataGridViewTextBoxColumn
            // 
            this.deductiontypenameDataGridViewTextBoxColumn.DataPropertyName = "deduction_type_name";
            this.deductiontypenameDataGridViewTextBoxColumn.HeaderText = "نوع الأستقطاع";
            this.deductiontypenameDataGridViewTextBoxColumn.Name = "deductiontypenameDataGridViewTextBoxColumn";
            this.deductiontypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionamountDataGridViewTextBoxColumn
            // 
            this.deductionamountDataGridViewTextBoxColumn.DataPropertyName = "deduction_amount";
            this.deductionamountDataGridViewTextBoxColumn.HeaderText = "المبلغ أو النسبة";
            this.deductionamountDataGridViewTextBoxColumn.Name = "deductionamountDataGridViewTextBoxColumn";
            this.deductionamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // negativevalueDataGridViewCheckBoxColumn
            // 
            this.negativevalueDataGridViewCheckBoxColumn.DataPropertyName = "negative_value";
            this.negativevalueDataGridViewCheckBoxColumn.HeaderText = "خصم ؟";
            this.negativevalueDataGridViewCheckBoxColumn.Name = "negativevalueDataGridViewCheckBoxColumn";
            this.negativevalueDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deductionsViewBindingSource
            // 
            this.deductionsViewBindingSource.DataMember = "deductions_View";
            this.deductionsViewBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amount_txt
            // 
            this.amount_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amount_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionsViewBindingSource, "deduction_amount", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.amount_txt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_txt.Location = new System.Drawing.Point(14, 91);
            this.amount_txt.Multiline = true;
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(187, 32);
            this.amount_txt.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 92);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 89;
            this.label5.Text = "المبلغ أو النسبة";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 92);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 87;
            this.label6.Text = "نوع الأستقطاع";
            // 
            // rule_list
            // 
            this.rule_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rule_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionsViewBindingSource, "rule_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.rule_list.DataSource = this.rulesBindingSource;
            this.rule_list.DisplayMember = "rule_name";
            this.rule_list.FormattingEnabled = true;
            this.rule_list.Location = new System.Drawing.Point(696, 93);
            this.rule_list.Name = "rule_list";
            this.rule_list.Size = new System.Drawing.Size(212, 28);
            this.rule_list.TabIndex = 98;
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
            this.label3.Location = new System.Drawing.Point(914, 92);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 97;
            this.label3.Text = "الوظيفة";
            // 
            // deduction_type_list
            // 
            this.deduction_type_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deduction_type_list.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionsViewBindingSource, "deduction_type_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.deduction_type_list.DataSource = this.deductiontypesBindingSource;
            this.deduction_type_list.DisplayMember = "deduction_type_name";
            this.deduction_type_list.FormattingEnabled = true;
            this.deduction_type_list.Location = new System.Drawing.Point(336, 93);
            this.deduction_type_list.Name = "deduction_type_list";
            this.deduction_type_list.Size = new System.Drawing.Size(233, 28);
            this.deduction_type_list.TabIndex = 99;
            this.deduction_type_list.ValueMember = "deduction_type_id";
            // 
            // deductiontypesBindingSource
            // 
            this.deductiontypesBindingSource.DataMember = "deduction_types";
            this.deductiontypesBindingSource.DataSource = this.hRDataSet;
            // 
            // rulesTableAdapter
            // 
            this.rulesTableAdapter.ClearBeforeFill = true;
            // 
            // deduction_typesTableAdapter
            // 
            this.deduction_typesTableAdapter.ClearBeforeFill = true;
            // 
            // deductions_ViewTableAdapter
            // 
            this.deductions_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // deductionsTableAdapter
            // 
            this.deductionsTableAdapter.ClearBeforeFill = true;
            // 
            // deductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.deduction_type_list);
            this.Controls.Add(this.rule_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "deductions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأستقطاعات";
            this.Load += new System.EventHandler(this.deductions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductiontypesBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rule_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox deduction_type_list;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private HRDataSetTableAdapters.rulesTableAdapter rulesTableAdapter;
        private System.Windows.Forms.BindingSource deductiontypesBindingSource;
        private HRDataSetTableAdapters.deduction_typesTableAdapter deduction_typesTableAdapter;
        private System.Windows.Forms.BindingSource deductionsViewBindingSource;
        private HRDataSetTableAdapters.deductions_ViewTableAdapter deductions_ViewTableAdapter;
        private HRDataSetTableAdapters.deductionsTableAdapter deductionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rulenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductiontypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductiontypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn negativevalueDataGridViewCheckBoxColumn;
    }
}

