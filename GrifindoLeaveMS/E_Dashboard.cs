using GrifindoEmployeeLMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoLeaveMS
{
    public partial class E_Dashboard : Form
    {
        public E_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_ApplyLeave_Click(object sender, EventArgs e)
        {
            EApplyLeave AL = new EApplyLeave();
            this.Hide();
            AL.Show();
        }

        private void btn_LeaveStatus_Click(object sender, EventArgs e)
        {
            ELeaveStatus LS = new ELeaveStatus();
            this.Hide();
            LS.Show();
        }

        private void btn_LeaveReport_Click(object sender, EventArgs e)
        {
            ELeaveReport LR = new ELeaveReport();
            this.Hide();
            LR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin U = new UserLogin();
            this.Hide();
            U.Show();
        }
    }
}
