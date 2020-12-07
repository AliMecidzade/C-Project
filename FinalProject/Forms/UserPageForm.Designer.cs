namespace FinalProject
{
    partial class UserPageForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.grbx_user = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.grbx_img = new System.Windows.Forms.GroupBox();
            this.link_propic = new System.Windows.Forms.LinkLabel();
            this.pic_bx = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbx_user.SuspendLayout();
            this.grbx_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bx)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(17, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 29);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_surname.Location = new System.Drawing.Point(17, 106);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(131, 29);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname: ";
            this.lbl_surname.Click += new System.EventHandler(this.lbl_surname_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_age.Location = new System.Drawing.Point(17, 185);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(73, 29);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "Age: ";
            this.lbl_age.Click += new System.EventHandler(this.label3_Click);
            // 
            // grbx_user
            // 
            this.grbx_user.Controls.Add(this.lbl_surname);
            this.grbx_user.Controls.Add(this.lbl_name);
            this.grbx_user.Controls.Add(this.lbl_age);
            this.grbx_user.Location = new System.Drawing.Point(1, 126);
            this.grbx_user.Name = "grbx_user";
            this.grbx_user.Size = new System.Drawing.Size(275, 329);
            this.grbx_user.TabIndex = 4;
            this.grbx_user.TabStop = false;
            this.grbx_user.Text = "User Info";
            this.grbx_user.Enter += new System.EventHandler(this.grbx_user_Enter);
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_logout.ForeColor = System.Drawing.Color.Brown;
            this.link_logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.link_logout.Location = new System.Drawing.Point(666, 28);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(68, 20);
            this.link_logout.TabIndex = 5;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "LogOut";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // grbx_img
            // 
            this.grbx_img.BackColor = System.Drawing.Color.Transparent;
            this.grbx_img.Controls.Add(this.link_propic);
            this.grbx_img.Controls.Add(this.pic_bx);
            this.grbx_img.Location = new System.Drawing.Point(282, 126);
            this.grbx_img.Name = "grbx_img";
            this.grbx_img.Size = new System.Drawing.Size(470, 394);
            this.grbx_img.TabIndex = 6;
            this.grbx_img.TabStop = false;
            this.grbx_img.Enter += new System.EventHandler(this.grbx_img_Enter);
            // 
            // link_propic
            // 
            this.link_propic.AutoSize = true;
            this.link_propic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_propic.Location = new System.Drawing.Point(181, 356);
            this.link_propic.Name = "link_propic";
            this.link_propic.Size = new System.Drawing.Size(176, 24);
            this.link_propic.TabIndex = 6;
            this.link_propic.TabStop = true;
            this.link_propic.Text = "Set Profile Picture";
            this.link_propic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_propic_LinkClicked);
            // 
            // pic_bx
            // 
            this.pic_bx.Location = new System.Drawing.Point(94, 39);
            this.pic_bx.Name = "pic_bx";
            this.pic_bx.Size = new System.Drawing.Size(300, 300);
            this.pic_bx.TabIndex = 0;
            this.pic_bx.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_welcome);
            this.groupBox2.Controls.Add(this.link_logout);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.Location = new System.Drawing.Point(22, 18);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(142, 31);
            this.lbl_welcome.TabIndex = 7;
            this.lbl_welcome.Text = "Welcome!";
            this.lbl_welcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbx_img);
            this.Controls.Add(this.grbx_user);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPageForm";
            this.Text = " UserPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPageForm_FormClosed);
            this.Load += new System.EventHandler(this.UserPageForm_Load);
            this.grbx_user.ResumeLayout(false);
            this.grbx_user.PerformLayout();
            this.grbx_img.ResumeLayout(false);
            this.grbx_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.GroupBox grbx_user;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.GroupBox grbx_img;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel link_propic;
        private System.Windows.Forms.PictureBox pic_bx;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}