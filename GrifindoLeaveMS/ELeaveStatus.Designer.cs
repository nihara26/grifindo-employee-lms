namespace GrifindoLeaveMS
{
    partial class ELeaveStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELeaveStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridDefineR = new System.Windows.Forms.DataGridView();
            this.btnapply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Leave Status";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Your Leave Table";
            // 
            // dataGridDefineR
            // 
            this.dataGridDefineR.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridDefineR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDefineR.Location = new System.Drawing.Point(106, 150);
            this.dataGridDefineR.Name = "dataGridDefineR";
            this.dataGridDefineR.RowHeadersWidth = 51;
            this.dataGridDefineR.RowTemplate.Height = 24;
            this.dataGridDefineR.Size = new System.Drawing.Size(898, 255);
            this.dataGridDefineR.TabIndex = 70;
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.Color.White;
            this.btnapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnapply.Location = new System.Drawing.Point(472, 443);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(147, 48);
            this.btnapply.TabIndex = 72;
            this.btnapply.Text = "Delete Leave";
            this.btnapply.UseVisualStyleBackColor = false;
            // 
            // ELeaveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1106, 532);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridDefineR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "ELeaveStatus";
            this.Text = "ELeaveStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDefineR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridDefineR;
        private System.Windows.Forms.Button btnapply;
    }
}