namespace FinalProject.Forms
{
    partial class AdminForm
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
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.grbx_stats = new System.Windows.Forms.GroupBox();
            this.link_users = new System.Windows.Forms.LinkLabel();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.grbx_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_logout.Location = new System.Drawing.Point(720, 31);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(68, 20);
            this.link_logout.TabIndex = 6;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "LogOut";
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // grbx_stats
            // 
            this.grbx_stats.Controls.Add(this.link_users);
            this.grbx_stats.Location = new System.Drawing.Point(0, 0);
            this.grbx_stats.Name = "grbx_stats";
            this.grbx_stats.Size = new System.Drawing.Size(700, 100);
            this.grbx_stats.TabIndex = 7;
            this.grbx_stats.TabStop = false;
            this.grbx_stats.Text = "Statistics";
            // 
            // link_users
            // 
            this.link_users.AutoSize = true;
            this.link_users.Location = new System.Drawing.Point(34, 38);
            this.link_users.Name = "link_users";
            this.link_users.Size = new System.Drawing.Size(34, 13);
            this.link_users.TabIndex = 0;
            this.link_users.TabStop = true;
            this.link_users.Text = "Users";
            this.link_users.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_users_LinkClicked);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 130);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(763, 293);
            this.dgv_data.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.grbx_stats);
            this.Controls.Add(this.link_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.grbx_stats.ResumeLayout(false);
            this.grbx_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.GroupBox grbx_stats;
        private System.Windows.Forms.LinkLabel link_users;
        private System.Windows.Forms.DataGridView dgv_data;
    }
}