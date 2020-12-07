using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MainForm.Close();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminForm = Session.AdminForm ?? this;
            Session.MainForm.Show();
            Hide();
        }

        private void link_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgv_data.DataSource = Session.Data.GetUsers();
        }
    }
}
