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
    public partial class ELeaveReport : Form
    {
        public ELeaveReport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            E_Dashboard ED = new E_Dashboard();
            this.Hide();
            ED.Show();
        }
    }
}
