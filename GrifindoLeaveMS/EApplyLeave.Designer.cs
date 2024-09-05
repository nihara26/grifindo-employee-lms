namespace GrifindoLeaveMS
{
    partial class EApplyLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EApplyLeave));
            this.dataGridApplyleaves = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbLeaveCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnapply = new System.Windows.Forms.Button();
            this.mtbStartTimeAL = new System.Windows.Forms.MaskedTextBox();
            this.mtbEndTimeAL = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.grifindoLeaveMSDataSet = new GrifindoEmployeeLMS.GrifindoLeaveMSDataSet();
            this.eApplyLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eApplyLeaveTableAdapter = new GrifindoEmployeeLMS.GrifindoLeaveMSDataSetTableAdapters.EApplyLeaveTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplyleaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApplyLeaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridApplyleaves
            // 
            this.dataGridApplyleaves.AutoGenerateColumns = false;
            this.dataGridApplyleaves.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridApplyleaves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridApplyleaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplyleaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.leaveCategoryDataGridViewTextBoxColumn,
            this.leaveDateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridApplyleaves.DataSource = this.eApplyLeaveBindingSource;
            this.dataGridApplyleaves.Location = new System.Drawing.Point(96, 360);
            this.dataGridApplyleaves.Name = "dataGridApplyleaves";
            this.dataGridApplyleaves.RowHeadersWidth = 51;
            this.dataGridApplyleaves.RowTemplate.Height = 24;
            this.dataGridApplyleaves.Size = new System.Drawing.Size(904, 166);
            this.dataGridApplyleaves.TabIndex = 50;
            this.dataGridApplyleaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridApplyleaves_CellContentClick);
            this.dataGridApplyleaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridApplyleaves_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(745, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Leave Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Leave Category";
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.Location = new System.Drawing.Point(106, 228);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(229, 22);
            this.dtpLeaveDate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "Apply Leave";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 44);
            this.btnBack.TabIndex = 49;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbLeaveCategory
            // 
            this.cmbLeaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLeaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeaveCategory.FormattingEnabled = true;
            this.cmbLeaveCategory.Items.AddRange(new object[] {
            "Annual",
            "Casual",
            "Short"});
            this.cmbLeaveCategory.Location = new System.Drawing.Point(426, 138);
            this.cmbLeaveCategory.Name = "cmbLeaveCategory";
            this.cmbLeaveCategory.Size = new System.Drawing.Size(229, 28);
            this.cmbLeaveCategory.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Starting Time";
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.btnapply.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.Color.White;
            this.btnapply.Location = new System.Drawing.Point(106, 295);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(107, 44);
            this.btnapply.TabIndex = 48;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // mtbStartTimeAL
            // 
            this.mtbStartTimeAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbStartTimeAL.Location = new System.Drawing.Point(426, 226);
            this.mtbStartTimeAL.Name = "mtbStartTimeAL";
            this.mtbStartTimeAL.Size = new System.Drawing.Size(229, 24);
            this.mtbStartTimeAL.TabIndex = 54;
            // 
            // mtbEndTimeAL
            // 
            this.mtbEndTimeAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbEndTimeAL.Location = new System.Drawing.Point(749, 226);
            this.mtbEndTimeAL.Name = "mtbEndTimeAL";
            this.mtbEndTimeAL.Size = new System.Drawing.Size(229, 24);
            this.mtbEndTimeAL.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "EmployeeID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmpID.Location = new System.Drawing.Point(106, 139);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(229, 27);
            this.txtEmpID.TabIndex = 56;
            // 
            // grifindoLeaveMSDataSet
            // 
            this.grifindoLeaveMSDataSet.DataSetName = "GrifindoLeaveMSDataSet";
            this.grifindoLeaveMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eApplyLeaveBindingSource
            // 
            this.eApplyLeaveBindingSource.DataMember = "EApplyLeave";
            this.eApplyLeaveBindingSource.DataSource = this.grifindoLeaveMSDataSet;
            // 
            // eApplyLeaveTableAdapter
            // 
            this.eApplyLeaveTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveCategoryDataGridViewTextBoxColumn
            // 
            this.leaveCategoryDataGridViewTextBoxColumn.DataPropertyName = "LeaveCategory";
            this.leaveCategoryDataGridViewTextBoxColumn.HeaderText = "LeaveCategory";
            this.leaveCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveCategoryDataGridViewTextBoxColumn.Name = "leaveCategoryDataGridViewTextBoxColumn";
            this.leaveCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveDateDataGridViewTextBoxColumn
            // 
            this.leaveDateDataGridViewTextBoxColumn.DataPropertyName = "LeaveDate";
            this.leaveDateDataGridViewTextBoxColumn.HeaderText = "LeaveDate";
            this.leaveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveDateDataGridViewTextBoxColumn.Name = "leaveDateDataGridViewTextBoxColumn";
            this.leaveDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(890, 313);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 41);
            this.btnView.TabIndex = 74;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(251, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 44);
            this.btnClear.TabIndex = 75;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EApplyLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1095, 576);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.mtbEndTimeAL);
            this.Controls.Add(this.mtbStartTimeAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLeaveCategory);
            this.Controls.Add(this.dataGridApplyleaves);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpLeaveDate);
            this.Controls.Add(this.label1);
            this.Name = "EApplyLeave";
            this.Text = "EApplyLeave";
            this.Load += new System.EventHandler(this.EApplyLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplyleaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grifindoLeaveMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApplyLeaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridApplyleaves;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLeaveCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.MaskedTextBox mtbStartTimeAL;
        private System.Windows.Forms.MaskedTextBox mtbEndTimeAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpID;
        private GrifindoEmployeeLMS.GrifindoLeaveMSDataSet grifindoLeaveMSDataSet;
        private System.Windows.Forms.BindingSource eApplyLeaveBindingSource;
        private GrifindoEmployeeLMS.GrifindoLeaveMSDataSetTableAdapters.EApplyLeaveTableAdapter eApplyLeaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
    }
}