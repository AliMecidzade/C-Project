using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FinalProject.Managers;
using FinalProject.Roles;

namespace FinalProject
{
    public partial class UserPageForm : Form
    {
        private User _currentUser;
        private FileManager _fileManager;
        private string _logsPath;
        public UserPageForm()
        { 
            InitializeComponent();
            _currentUser = Session.User;
            _fileManager = new FileManager();
            _logsPath = _fileManager.GetPath("logs", "logs.txt");

        }
        

        private void UserPageForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome, dear User {_currentUser.Email}";
            lbl_name.Text += _currentUser.Name;
            lbl_surname.Text += _currentUser.Surname;
            lbl_age.Text += _currentUser.Age.ToString();
            if (string.IsNullOrEmpty(_currentUser.PropicPath))
            {
                string propic_path = _fileManager.GetPath("img", "ProfileImg.png");
                _fileManager.ShowMyImage(propic_path, 300, 300, pic_bx);
            }
            else
            {
                _fileManager.ShowMyImage(_currentUser.PropicPath, 300, 300, pic_bx);
            }
            string path = _fileManager.GetPath("logs", "logs.txt");
            _fileManager.WriteLog(_currentUser.Email, LogStatus.LogIn, _logsPath);

                                                    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MainForm.Close();

        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.UserPage = Session.UserPage ?? this;
            Session.MainForm.Show();
            Hide();


            _fileManager.WriteLog(_currentUser.Email, LogStatus.LogOut, _logsPath);
        }

        private void grbx_user_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_surname_Click(object sender, EventArgs e)
        {

        }

        private void link_propic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                if (File.Exists(path))
                {

                    _fileManager.ShowMyImage(path, 300, 300, pic_bx);
                    _currentUser.PropicPath = path;
                }

            }
         
        }

       

        private void grbx_img_Enter(object sender, EventArgs e)
        {

        }
    }
}
