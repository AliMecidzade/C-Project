using System;

namespace FinalProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.txbx_Surname = new System.Windows.Forms.TextBox();
            this.txbx_age = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbx_regEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_regPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.grbx_register = new System.Windows.Forms.GroupBox();
            this.grbx_login = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txbx_logPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_logEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbx_register.SuspendLayout();
            this.grbx_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Surname";
            // 
            // txbx_Name
            // 
            this.txbx_Name.Location = new System.Drawing.Point(24, 48);
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(293, 20);
            this.txbx_Name.TabIndex = 28;
            // 
            // txbx_Surname
            // 
            this.txbx_Surname.Location = new System.Drawing.Point(24, 121);
            this.txbx_Surname.Name = "txbx_Surname";
            this.txbx_Surname.Size = new System.Drawing.Size(293, 20);
            this.txbx_Surname.TabIndex = 29;
            // 
            // txbx_age
            // 
            this.txbx_age.Location = new System.Drawing.Point(24, 207);
            this.txbx_age.Name = "txbx_age";
            this.txbx_age.Size = new System.Drawing.Size(293, 20);
            this.txbx_age.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(21, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(21, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Name";
            // 
            // txbx_regEmail
            // 
            this.txbx_regEmail.Location = new System.Drawing.Point(25, 278);
            this.txbx_regEmail.Name = "txbx_regEmail";
            this.txbx_regEmail.Size = new System.Drawing.Size(293, 20);
            this.txbx_regEmail.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(22, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Email";
            // 
            // txbx_regPassword
            // 
            this.txbx_regPassword.Location = new System.Drawing.Point(25, 343);
            this.txbx_regPassword.Name = "txbx_regPassword";
            this.txbx_regPassword.Size = new System.Drawing.Size(293, 20);
            this.txbx_regPassword.TabIndex = 36;
            this.txbx_regPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(22, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_register.Location = new System.Drawing.Point(112, 384);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(99, 46);
            this.btn_register.TabIndex = 38;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_2);
            // 
            // grbx_register
            // 
            this.grbx_register.BackColor = System.Drawing.Color.Transparent;
            this.grbx_register.Controls.Add(this.txbx_Surname);
            this.grbx_register.Controls.Add(this.btn_register);
            this.grbx_register.Controls.Add(this.label9);
            this.grbx_register.Controls.Add(this.txbx_regPassword);
            this.grbx_register.Controls.Add(this.txbx_Name);
            this.grbx_register.Controls.Add(this.label2);
            this.grbx_register.Controls.Add(this.label11);
            this.grbx_register.Controls.Add(this.txbx_regEmail);
            this.grbx_register.Controls.Add(this.txbx_age);
            this.grbx_register.Controls.Add(this.label1);
            this.grbx_register.Controls.Add(this.label13);
            this.grbx_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbx_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbx_register.Location = new System.Drawing.Point(33, 12);
            this.grbx_register.Name = "grbx_register";
            this.grbx_register.Size = new System.Drawing.Size(341, 442);
            this.grbx_register.TabIndex = 39;
            this.grbx_register.TabStop = false;
            this.grbx_register.Text = "Register";
            // 
            // grbx_login
            // 
            this.grbx_login.BackColor = System.Drawing.Color.Transparent;
            this.grbx_login.Controls.Add(this.btn_login);
            this.grbx_login.Controls.Add(this.txbx_logPassword);
            this.grbx_login.Controls.Add(this.label4);
            this.grbx_login.Controls.Add(this.txbx_logEmail);
            this.grbx_login.Controls.Add(this.label6);
            this.grbx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grbx_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbx_login.Location = new System.Drawing.Point(431, 12);
            this.grbx_login.Name = "grbx_login";
            this.grbx_login.Size = new System.Drawing.Size(341, 227);
            this.grbx_login.TabIndex = 40;
            this.grbx_login.TabStop = false;
            this.grbx_login.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.Location = new System.Drawing.Point(111, 158);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(99, 46);
            this.btn_login.TabIndex = 38;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txbx_logPassword
            // 
            this.txbx_logPassword.Location = new System.Drawing.Point(15, 113);
            this.txbx_logPassword.Name = "txbx_logPassword";
            this.txbx_logPassword.Size = new System.Drawing.Size(293, 20);
            this.txbx_logPassword.TabIndex = 36;
            this.txbx_logPassword.Text = "12345";
            this.txbx_logPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password";
            // 
            // txbx_logEmail
            // 
            this.txbx_logEmail.Location = new System.Drawing.Point(15, 48);
            this.txbx_logEmail.Name = "txbx_logEmail";
            this.txbx_logEmail.Size = new System.Drawing.Size(293, 20);
            this.txbx_logEmail.TabIndex = 34;
            this.txbx_logEmail.Text = "ali@";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email";
            // 
            // MainForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 478);
            this.Controls.Add(this.grbx_login);
            this.Controls.Add(this.grbx_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "SmartApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbx_register.ResumeLayout(false);
            this.grbx_register.PerformLayout();
            this.grbx_login.ResumeLayout(false);
            this.grbx_login.PerformLayout();
            this.ResumeLayout(false);

        }

     


    

        #endregion
    

      

       
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.TextBox txbx_Surname;
        private System.Windows.Forms.TextBox txbx_age;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbx_regEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_regPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox grbx_register;
        private System.Windows.Forms.GroupBox grbx_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txbx_logPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_logEmail;
        private System.Windows.Forms.Label label6;
    }
}

