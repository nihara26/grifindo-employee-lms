using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoLeaveMS
{
    public partial class ELeaveStatus : Form
    {
        public ELeaveStatus()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridDefineR.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a leave record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve the selected row
                DataGridViewRow row = dataGridDefineR.SelectedRows[0];

                // Ensure the Status column exists before referencing it
                if (row.Cells["Status"] != null)
                {
                    string status = row.Cells["Status"].Value?.ToString();
                    if (status != "Pending")
                    {
                        MessageBox.Show("You cannot delete this leave record as it has already been " + status + ".", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the leave is approved or rejected
                    }
                }
                else
                {
                    MessageBox.Show("Status column is missing in the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if the Status column is missing
                }

                string EmployeeID = row.Cells["EmployeeID"].Value.ToString();
                DateTime LeaveDate = Convert.ToDateTime(row.Cells["LeaveDate"].Value);

                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this leave record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    con.Open();

                    // SQL query to delete the selected leave record
                    string query = @"DELETE FROM EApplyLeave WHERE EmployeeID = @EmployeeID AND LeaveDate = @LeaveDate";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        cmd.Parameters.AddWithValue("@LeaveDate", LeaveDate);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Leave record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();

                    // Refresh the DataGridView after deletion
                    btnView_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the leave record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeID = txtEmpID.Text.Trim();  // Assuming txtEmpID is used for input

                // Check if EmployeeID is provided
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter your Employee ID to view your leave records.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();

                // SQL Query to get leave records along with the Status
                string query = @"SELECT E.EmployeeID, E.LeaveCategory, E.LeaveDate, E.StartTime, E.EndTime, 
                                COALESCE(L.Status, 'Pending') AS Status -- Default to 'Pending' if not found
                         FROM EApplyLeave E
                         LEFT JOIN LeaveHistory L ON E.EmployeeID = L.EmployeeID AND E.LeaveDate = L.LeaveDate
                         WHERE E.EmployeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Check if records are found
                        if (dt.Rows.Count > 0)
                        {
                            dataGridDefineR.DataSource = dt;  // Bind the result to dataGridDefineR

                            // Check and add Status column programmatically if not present
                            if (!dataGridDefineR.Columns.Contains("Status"))
                            {
                                dataGridDefineR.Columns.Add("Status", "Status");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No leave records found for the provided Employee ID.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridDefineR.DataSource = null;  // Clear the DataGridView if no records found
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching leave records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ELeaveStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet11.EApplyLeave' table. You can move, or remove it, as needed.
            this.eApplyLeaveTableAdapter1.Fill(this.grifindoLeaveMSDataSet11.EApplyLeave);
        }

        private void dataGridDefineR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
