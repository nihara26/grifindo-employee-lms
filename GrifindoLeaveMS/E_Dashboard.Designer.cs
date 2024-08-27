namespace GrifindoLeaveMS
{
    partial class E_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Dashboard));
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_LeaveReport = new System.Windows.Forms.Button();
            this.btn_LeaveStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ApplyLeave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(-57, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 44);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btn_LeaveReport
            // 
            this.btn_LeaveReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeaveReport.Location = new System.Drawing.Point(554, 161);
            this.btn_LeaveReport.Name = "btn_LeaveReport";
            this.btn_LeaveReport.Size = new System.Drawing.Size(185, 89);
            this.btn_LeaveReport.TabIndex = 22;
            this.btn_LeaveReport.Text = "Leave Report";
            this.btn_LeaveReport.UseVisualStyleBackColor = true;
            this.btn_LeaveReport.Click += new System.EventHandler(this.btn_LeaveReport_Click);
            // 
            // btn_LeaveStatus
            // 
            this.btn_LeaveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeaveStatus.Location = new System.Drawing.Point(317, 161);
            this.btn_LeaveStatus.Name = "btn_LeaveStatus";
            this.btn_LeaveStatus.Size = new System.Drawing.Size(185, 89);
            this.btn_LeaveStatus.TabIndex = 21;
            this.btn_LeaveStatus.Text = "Leave Status";
            this.btn_LeaveStatus.UseVisualStyleBackColor = true;
            this.btn_LeaveStatus.Click += new System.EventHandler(this.btn_LeaveStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee Dashboard";
            // 
            // btn_ApplyLeave
            // 
            this.btn_ApplyLeave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyLeave.Location = new System.Drawing.Point(90, 161);
            this.btn_ApplyLeave.Name = "btn_ApplyLeave";
            this.btn_ApplyLeave.Size = new System.Drawing.Size(185, 89);
            this.btn_ApplyLeave.TabIndex = 19;
            this.btn_ApplyLeave.Text = "Apply Leave";
            this.btn_ApplyLeave.UseVisualStyleBackColor = true;
            this.btn_ApplyLeave.Click += new System.EventHandler(this.btn_ApplyLeave_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(695, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 365);
            this.panel1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // E_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(841, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_LeaveReport);
            this.Controls.Add(this.btn_LeaveStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ApplyLeave);
            this.Controls.Add(this.panel1);
            this.Name = "E_Dashboard";
            this.Text = "Employee Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn_LeaveReport;
        private System.Windows.Forms.Button btn_LeaveStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ApplyLeave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}