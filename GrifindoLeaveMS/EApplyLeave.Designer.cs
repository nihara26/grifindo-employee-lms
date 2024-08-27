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
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplyleaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridApplyleaves
            // 
            this.dataGridApplyleaves.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridApplyleaves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridApplyleaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplyleaves.Location = new System.Drawing.Point(115, 382);
            this.dataGridApplyleaves.Name = "dataGridApplyleaves";
            this.dataGridApplyleaves.RowHeadersWidth = 51;
            this.dataGridApplyleaves.RowTemplate.Height = 24;
            this.dataGridApplyleaves.Size = new System.Drawing.Size(904, 147);
            this.dataGridApplyleaves.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(764, 225);
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
            this.label5.Location = new System.Drawing.Point(121, 227);
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
            this.label4.Location = new System.Drawing.Point(441, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Leave Category";
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.Location = new System.Drawing.Point(125, 250);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(229, 22);
            this.dtpLeaveDate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 40);
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
            this.cmbLeaveCategory.Location = new System.Drawing.Point(445, 160);
            this.cmbLeaveCategory.Name = "cmbLeaveCategory";
            this.cmbLeaveCategory.Size = new System.Drawing.Size(229, 28);
            this.cmbLeaveCategory.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Starting Time";
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.White;
            this.btnapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnapply.Location = new System.Drawing.Point(850, 314);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(147, 48);
            this.btnapply.TabIndex = 48;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = false;
            // 
            // mtbStartTimeAL
            // 
            this.mtbStartTimeAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbStartTimeAL.Location = new System.Drawing.Point(445, 248);
            this.mtbStartTimeAL.Name = "mtbStartTimeAL";
            this.mtbStartTimeAL.Size = new System.Drawing.Size(229, 24);
            this.mtbStartTimeAL.TabIndex = 54;
            // 
            // mtbEndTimeAL
            // 
            this.mtbEndTimeAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbEndTimeAL.Location = new System.Drawing.Point(768, 248);
            this.mtbEndTimeAL.Name = "mtbEndTimeAL";
            this.mtbEndTimeAL.Size = new System.Drawing.Size(229, 24);
            this.mtbEndTimeAL.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Search Emp.No";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsearch.Location = new System.Drawing.Point(125, 161);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(229, 27);
            this.txtsearch.TabIndex = 56;
            // 
            // EApplyLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1103, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplyleaves)).EndInit();
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
        private System.Windows.Forms.TextBox txtsearch;
    }
}