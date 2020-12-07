using FinalProject.Forms;
using FinalProject.Roles;
using System;

using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly Validator validator;
        private readonly UsersData usersData;

        public MainForm()
        {
            InitializeComponent();
            validator = new Validator();
            usersData = new UsersData();
            Session.Data = usersData;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void grbx_register_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click_2(object sender, EventArgs e)
        {
            string
            name = txbx_Name.Text,
            surname = txbx_Surname.Text,
            password = txbx_regPassword.Text,
            email = txbx_regEmail.Text,
            age = txbx_age.Text;

            bool validInput = true;
            if (validator.IsEmpty(name, surname, email, password, age))
            {
                validInput = false;
                MessageBox.Show("Please fill out all fields");
            }
            else
            {


                if (!validator.isValidEmail(email))
                {
                    validInput = false;
                    MessageBox.Show("Your email is worng");
                }
                if (!validator.isValidPassword(password))
                {
                    validInput = false;
                    MessageBox.Show("Your passsword is wrong");
                }
            }
             
            if (validInput)
            {
                User user = new User(name, surname, password, email, byte.Parse(age));
                user.UserType = UserRole.User;
                if (usersData.UserExist(user))
                {
                    MessageBox.Show("This user already exist");
                }
                else
                {
                    usersData.Add(user);
                    MessageBox.Show("You successfully registered!");
                }
            }
            EmptyTextBoxes(txbx_age, txbx_regPassword, txbx_regEmail, txbx_Name, txbx_Surname);
            if (!validator.isValidAgeValue(age))
            {
                validInput = false;
                MessageBox.Show("Given age value is invalid");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void Name_Click(object sender, EventArgs e)
        {

        }
    
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string
                email = txbx_logEmail.Text,
                password = txbx_logPassword.Text;

            bool validInput = true;
            if (validator.IsEmpty(email, password))
            {
                validInput = false;
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                if (!validator.isValidEmail(email))
                {
                    validInput = false;
                    MessageBox.Show("Your email is worng");
                }
                if (!validator.isValidPassword(password))
                {
                    validInput = false;
                    MessageBox.Show("Your passsword is wrong");
                }
            }

            if(validInput)
            {
                if (usersData.UserExist(email, password))
                {
                    User currentUser = usersData.FindUser(email, password);
                    Session.User = currentUser;
                    Session.MainForm = this;
                    if (currentUser.UserType == UserRole.Admin)
                    {
                        AdminForm adminForm = Session.AdminForm ?? new AdminForm();
                        adminForm.Show();
                    }
                    else if(currentUser.UserType == UserRole.User)
                    {
                        UserPageForm userPageForm = Session.UserPage ?? new UserPageForm();
                        userPageForm.ShowDialog();
                    }
                    Hide();
                }
                else
                {
                    MessageBox.Show("User does not exist");
                }
            }
            EmptyTextBoxes(txbx_logEmail, txbx_logPassword);
        }

        private void EmptyTextBoxes(params TextBox[] textboxes)
        {
            foreach (var txbx in textboxes)
            {
                txbx.Text = string.Empty;
            }
        }
    }

 
}
    

