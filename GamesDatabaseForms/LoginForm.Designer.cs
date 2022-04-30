namespace GamesDatabaseForms
{
    partial class LoginForm
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
            this.btn_login_loginform = new System.Windows.Forms.Button();
            this.lab_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_statusmsg = new System.Windows.Forms.Label();
            this.llbl_createaccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_login_loginform
            // 
            this.btn_login_loginform.Location = new System.Drawing.Point(239, 60);
            this.btn_login_loginform.Name = "btn_login_loginform";
            this.btn_login_loginform.Size = new System.Drawing.Size(75, 23);
            this.btn_login_loginform.TabIndex = 2;
            this.btn_login_loginform.Text = "Login";
            this.btn_login_loginform.UseVisualStyleBackColor = true;
            this.btn_login_loginform.Click += new System.EventHandler(this.btn_login_loginform_Click);
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(12, 65);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(58, 13);
            this.lab_username.TabIndex = 1;
            this.lab_username.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(76, 62);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(157, 20);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_statusmsg
            // 
            this.lbl_statusmsg.AutoSize = true;
            this.lbl_statusmsg.Location = new System.Drawing.Point(12, 26);
            this.lbl_statusmsg.Name = "lbl_statusmsg";
            this.lbl_statusmsg.Size = new System.Drawing.Size(119, 13);
            this.lbl_statusmsg.TabIndex = 3;
            this.lbl_statusmsg.Text = "Currently Not Logged In";
            // 
            // llbl_createaccount
            // 
            this.llbl_createaccount.AutoSize = true;
            this.llbl_createaccount.Location = new System.Drawing.Point(73, 104);
            this.llbl_createaccount.Name = "llbl_createaccount";
            this.llbl_createaccount.Size = new System.Drawing.Size(106, 13);
            this.llbl_createaccount.TabIndex = 3;
            this.llbl_createaccount.TabStop = true;
            this.llbl_createaccount.Text = "Create New Account";
            this.llbl_createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_createaccount_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 140);
            this.Controls.Add(this.llbl_createaccount);
            this.Controls.Add(this.lbl_statusmsg);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.btn_login_loginform);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login_loginform;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_statusmsg;
        private System.Windows.Forms.LinkLabel llbl_createaccount;
    }
}