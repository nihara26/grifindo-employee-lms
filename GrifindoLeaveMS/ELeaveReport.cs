using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        static string connectionstring = "Data Source=ASUS_NEBULA\\SQLEXPRESS;Initial Catalog=GrifindoLeaveMS;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connectionstring);

        private void btnBack_Click(object sender, EventArgs e)
        {
            E_Dashboard ED = new E_Dashboard();
            this.Hide();
            ED.Show();
        }

        private void ELeaveReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet2.LeaveHistory' table. You can move, or remove it, as needed.
            this.leaveHistoryTableAdapter.Fill(this.grifindoLeaveMSDataSet2.LeaveHistory);

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
