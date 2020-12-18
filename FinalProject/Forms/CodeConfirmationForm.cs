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
    public partial class CodeConfirmationForm : Form
    {
        public CodeConfirmationForm()
        {
            InitializeComponent();
            label1.Text = "We have sent a code to your email\nPlease, enter this code to confirm your email";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            short originalCode = Session.Code;
            string givencode = txbx_code.Text;
            User user = Session.User;

            if (originalCode.ToString() == givencode.Trim())
            {
                user.IsConfirmedEmail = true;
            }
            else
            {
                MessageBox.Show("Code confirmation failed");
            }
        }
    }
}
