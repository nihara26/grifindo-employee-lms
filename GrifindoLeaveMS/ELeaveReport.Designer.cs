namespace GrifindoLeaveMS
{
    partial class ELeaveReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELeaveReport));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemainAL = new System.Windows.Forms.TextBox();
            this.txtRemainCL = new System.Windows.Forms.TextBox();
            this.txtRemainSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridELeaveTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridELeaveTable)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 50;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "Leave Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Remaining Leaves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Annual Leaves:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Casual Leaves:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Short Leaves:";
            // 
            // txtRemainAL
            // 
            this.txtRemainAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemainAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainAL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemainAL.Location = new System.Drawing.Point(271, 257);
            this.txtRemainAL.Name = "txtRemainAL";
            this.txtRemainAL.Size = new System.Drawing.Size(71, 24);
            this.txtRemainAL.TabIndex = 73;
            // 
            // txtRemainCL
            // 
            this.txtRemainCL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemainCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainCL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemainCL.Location = new System.Drawing.Point(271, 303);
            this.txtRemainCL.Name = "txtRemainCL";
            this.txtRemainCL.Size = new System.Drawing.Size(71, 24);
            this.txtRemainCL.TabIndex = 74;
            // 
            // txtRemainSL
            // 
            this.txtRemainSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemainSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainSL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRemainSL.Location = new System.Drawing.Point(271, 349);
            this.txtRemainSL.Name = "txtRemainSL";
            this.txtRemainSL.Size = new System.Drawing.Size(71, 24);
            this.txtRemainSL.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Leave History Table";
            // 
            // dataGridELeaveTable
            // 
            this.dataGridELeaveTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridELeaveTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridELeaveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridELeaveTable.Location = new System.Drawing.Point(406, 179);
            this.dataGridELeaveTable.Name = "dataGridELeaveTable";
            this.dataGridELeaveTable.RowHeadersWidth = 51;
            this.dataGridELeaveTable.RowTemplate.Height = 24;
            this.dataGridELeaveTable.Size = new System.Drawing.Size(703, 234);
            this.dataGridELeaveTable.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Search Emp.No";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsearch.Location = new System.Drawing.Point(50, 127);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(229, 27);
            this.txtsearch.TabIndex = 78;
            // 
            // ELeaveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1150, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridELeaveTable);
            this.Controls.Add(this.txtRemainSL);
            this.Controls.Add(this.txtRemainCL);
            this.Controls.Add(this.txtRemainAL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "ELeaveReport";
            this.Text = "ELeaveReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridELeaveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemainAL;
        private System.Windows.Forms.TextBox txtRemainCL;
        private System.Windows.Forms.TextBox txtRemainSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridELeaveTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
    }
}