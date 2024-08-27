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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin U = new UserLogin();
            this.Hide();
            U.Show();
        }

        private void btnELogin_Click(object sender, EventArgs e)
        {
            // Check if username or password text boxes are empty
            if (string.IsNullOrWhiteSpace(txtEuser.Text) || string.IsNullOrWhiteSpace(txtEpw.Text))
            {
                MessageBox.Show("Username and password are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // Valid username and password
            string username = "employee";
            string password = "12345";

            if (username == txtEuser.Text && password == txtEpw.Text)
            {
                MessageBox.Show("Login successful. Welcome!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                E_Dashboard ED = new E_Dashboard();
                this.Hide();
                ED.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
