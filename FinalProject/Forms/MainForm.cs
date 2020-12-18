using FinalProject.Forms;
using FinalProject.Roles;
using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using FinalProject.Managers;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        private readonly Validator validator;
        private readonly UsersData usersData;
        private readonly CodeConfirmationForm codeConfirmation;
        public MainForm()
        {
            InitializeComponent();
            validator = new Validator();
            usersData = new UsersData();
            codeConfirmation = new CodeConfirmationForm();
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
            try
            {
                string
           name = txbx_Name.Text,
           surname = txbx_Surname.Text,
           password = txbx_regPassword.Text,
           email = txbx_regEmail.Text,
           age = txbx_age.Text;

                validator.IsEmpty(name, surname, email, password);
                validator.isValidAgeValue(age);
                validator.isValidEmail(email);
                validator.isValidPassword(password);

                User user = new User(name, surname, password, email, byte.Parse(age));
                user.UserType = UserRole.User;
                if (usersData.UserExist(user))
                {
                    MessageBox.Show("This user already exist");
                }
                else
                {
                    AccountManager accountManager = new AccountManager("smtp.gmail.com", 587);

                    Session.User = user;
                    accountManager.SendMail(email, "Confirmation Code");
                    Session.Code = accountManager.ConfirmationCode;
                    codeConfirmation.ShowDialog();
                    if (user.IsConfirmedEmail)
                    {
                        usersData.Add(user);
                        MessageBox.Show("You successfully registered!");
                    }
                    else
                    {
                        MessageBox.Show("You did not confirm your email");
                    }

                }
            }
            catch (ArgumentException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidAgeValueException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                EmptyTextBoxes(txbx_age, txbx_regPassword, txbx_regEmail, txbx_Name, txbx_Surname);
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




            try { 
                string
                      email = txbx_logEmail.Text,
                      password = txbx_logPassword.Text;

                validator.isValidEmail(email);
                validator.isValidPassword(password);
          
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
                        else if (currentUser.UserType == UserRole.User)
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
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (ArgumentException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                EmptyTextBoxes(txbx_logEmail, txbx_logPassword);
            }
         
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
    

