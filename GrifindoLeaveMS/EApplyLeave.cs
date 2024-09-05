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
    public partial class EApplyLeave : Form
    {
        public EApplyLeave()
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

        private void EApplyLeave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindoLeaveMSDataSet.EApplyLeave' table. You can move, or remove it, as needed.
            this.eApplyLeaveTableAdapter.Fill(this.grifindoLeaveMSDataSet.EApplyLeave);

        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the form fields
                string EmployeeID = txtEmpID.Text.Trim();
                string LeaveCategory = cmbLeaveCategory.Text;
                DateTime LeaveDate = dtpLeaveDate.Value;

                // Check if required fields are filled
                if (string.IsNullOrWhiteSpace(EmployeeID) || string.IsNullOrWhiteSpace(LeaveCategory))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TimeSpan StartTime = TimeSpan.Zero;
                TimeSpan EndTime = TimeSpan.Zero;
                TimeSpan shortLeaveMaxDuration = new TimeSpan(1, 30, 0); // 1 hour and 30 minutes

                // Handle StartTime and EndTime only if it's a short leave
                if (LeaveCategory == "Short")
                {
                    // Validate that the start and end times are properly filled
                    if (string.IsNullOrWhiteSpace(mtbStartTimeAL.Text) || string.IsNullOrWhiteSpace(mtbEndTimeAL.Text))
                    {
                        MessageBox.Show("Please provide start and end time for short leave.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Parse the StartTime and EndTime
                    bool isValidStartTime = TimeSpan.TryParse(mtbStartTimeAL.Text, out StartTime);
                    bool isValidEndTime = TimeSpan.TryParse(mtbEndTimeAL.Text, out EndTime);

                    // Ensure valid time inputs
                    if (!isValidStartTime || !isValidEndTime)
                    {
                        MessageBox.Show("Invalid time format. Please enter a valid time for start and end.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    TimeSpan leaveDuration = EndTime - StartTime;

                    if (leaveDuration > shortLeaveMaxDuration)
                    {
                        MessageBox.Show("Short leave duration cannot exceed 1 hour 30 minutes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (LeaveDate.Date == DateTime.Today && StartTime < DateTime.Now.TimeOfDay)
                    {
                        MessageBox.Show("Short leave can only be applied for future time slots.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Annual leave validation: should be applied 7 days in advance
                if (LeaveCategory == "Annual" && (LeaveDate - DateTime.Now).TotalDays < 7)
                {
                    MessageBox.Show("Annual leaves must be applied for at least 7 days in advance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with applying leave
                con.Open();

                // SQL Insert Query for applying leave
                string query = @"INSERT INTO EApplyLeave (EmployeeID, LeaveCategory, LeaveDate, StartTime, EndTime)
                         VALUES (@EmployeeID, @LeaveCategory, @LeaveDate, @StartTime, @EndTime);";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@LeaveCategory", LeaveCategory);
                    cmd.Parameters.AddWithValue("@LeaveDate", LeaveDate);

                    // Handle time for Short leaves, otherwise set it as null for other leave types
                    if (LeaveCategory == "Short")
                    {
                        cmd.Parameters.AddWithValue("@StartTime", StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", EndTime);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@StartTime", DBNull.Value);
                        cmd.Parameters.AddWithValue("@EndTime", DBNull.Value);
                    }

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Leave applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying for leave: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeID = txtEmpID.Text.Trim();

                //Check if EmployeeID is provided
                if (string.IsNullOrWhiteSpace(EmployeeID))
                {
                    MessageBox.Show("Please enter your Employee ID to view your leave records.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.Open();

                string query = @"SELECT EmployeeID, LeaveCategory, LeaveDate, StartTime, EndTime FROM EApplyLeave 
                         WHERE EmployeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Check if any records are found
                        if (dt.Rows.Count > 0)
                        {
                            dataGridApplyleaves.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No leave records found for the provided Employee ID.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridApplyleaves.DataSource = null;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all input fields
            txtEmpID.Clear();
            cmbLeaveCategory.SelectedIndex = -1; // Reset to no selection
            mtbStartTimeAL.Clear();
            mtbEndTimeAL.Clear();

            // Reset the DateTimePicker to today's date
            dtpLeaveDate.Value = DateTime.Today;

            // Optionally, clear any selections in the DataGridView
            dataGridApplyleaves.ClearSelection();
        }

        private void dataGridApplyleaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the clicked cell is within a valid row
                if (e.RowIndex >= 0 && dataGridApplyleaves.SelectedRows.Count > 0)
                {
                    // Retrieve the selected row
                    DataGridViewRow row = dataGridApplyleaves.SelectedRows[0];

                    // Check the actual names of the columns or use column indices
                    txtEmpID.Text = row.Cells[0].Value.ToString();  // Assuming EmployeeID is in the first column
                    cmbLeaveCategory.Text = row.Cells[1].Value.ToString();  // LeaveCategory
                    dtpLeaveDate.Value = Convert.ToDateTime(row.Cells[2].Value);  // LeaveDate

                    // If it's a short leave, populate StartTime and EndTime
                    if (cmbLeaveCategory.Text == "Short")
                    {
                        mtbStartTimeAL.Text = row.Cells[3].Value != DBNull.Value ? row.Cells[3].Value.ToString() : string.Empty;
                        mtbEndTimeAL.Text = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : string.Empty;
                    }
                    else
                    {
                        mtbStartTimeAL.Clear();
                        mtbEndTimeAL.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
