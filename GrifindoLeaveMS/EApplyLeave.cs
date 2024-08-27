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
    public partial class EApplyLeave : Form
    {
        public EApplyLeave()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            E_Dashboard ED = new E_Dashboard();
            this.Hide();
            ED.Show();
        }
    }
}
