using ReservationManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationManagement
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void tbxUsername_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            tbxPassword.BackColor = SystemColors.Control;
            panel2.BackColor = Color.White;
            tbxUsername.BackColor = Color.White;
        }

        private void tbxPassword_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            tbxPassword.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            tbxUsername.BackColor = SystemColors.Control;
        }

        private void btnClosedLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        SysManagement SysManagement = new SysManagement();
        User user = new User();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (username == user.userName && password == user.Password)
            {
                SysManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check Your password or Username");
            }


        }

        private void btnClosedManagement_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
