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
            string EmployeeID = txtsearch.Text.Trim();
            int annualLeavesTotal = 14;
            int casualLeavesTotal = 7;
            int shortLeavesTotal = 2 * 12; // 2 short leaves per month * 12 months

            // Ensure Employee ID is provided
            if (string.IsNullOrWhiteSpace(EmployeeID))
            {
                MessageBox.Show("Please enter your Employee ID to view your Remaining Leaves.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open connection
                con.Open();

                // Fetch leave history and calculate remaining leaves
                string query = @"SELECT LeaveCategory, COUNT(LeaveCategory) AS UsedLeaves
                                 FROM LeaveHistory 
                                 WHERE EmployeeID = @EmployeeID AND Status = 'Approved'
                                 GROUP BY LeaveCategory";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int usedAnnualLeaves = 0;
                        int usedCasualLeaves = 0;
                        int usedShortLeaves = 0;

                        while (reader.Read())
                        {
                            string leaveCategory = reader["LeaveCategory"].ToString();
                            int usedLeaves = Convert.ToInt32(reader["UsedLeaves"]);

                            // Subtract used leaves from the total for each category
                            if (leaveCategory == "Annual")
                            {
                                usedAnnualLeaves = usedLeaves;
                            }
                            else if (leaveCategory == "Casual")
                            {
                                usedCasualLeaves = usedLeaves;
                            }
                            else if (leaveCategory == "Short")
                            {
                                usedShortLeaves = usedLeaves;
                            }
                        }

                        // Calculate remaining leaves
                        int remainingAnnualLeaves = annualLeavesTotal - usedAnnualLeaves;
                        int remainingCasualLeaves = casualLeavesTotal - usedCasualLeaves;
                        int remainingShortLeaves = shortLeavesTotal - usedShortLeaves;

                        // Display remaining leaves
                        txtRemainAL.Text = remainingAnnualLeaves.ToString();
                        txtRemainCL.Text = remainingCasualLeaves.ToString();
                        txtRemainSL.Text = remainingShortLeaves.ToString();
                    }
                }

                // Fetch leave history to show in DataGridView
                string leaveHistoryQuery = @"SELECT EmployeeID, LeaveCategory, LeaveDate, ActionDate, Status 
                                             FROM LeaveHistory 
                                             WHERE EmployeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(leaveHistoryQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind data to DataGridView
                        dataGridELeaveTable.DataSource = dt;
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching leave records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
    
}
