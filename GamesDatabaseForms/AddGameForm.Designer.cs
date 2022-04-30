namespace GamesDatabaseForms
{
    partial class AddGameForm
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_statusmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(87, 13);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Add a new game";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 52);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(30, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(12, 86);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(34, 13);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(65, 49);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 20);
            this.txt_title.TabIndex = 3;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(65, 83);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 20);
            this.txt_type.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(223, 83);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(88, 32);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_statusmsg
            // 
            this.lbl_statusmsg.AutoSize = true;
            this.lbl_statusmsg.Location = new System.Drawing.Point(174, 9);
            this.lbl_statusmsg.Name = "lbl_statusmsg";
            this.lbl_statusmsg.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusmsg.TabIndex = 6;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 127);
            this.Controls.Add(this.lbl_statusmsg);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_header);
            this.Name = "AddGameForm";
            this.Text = "AddGameForm";
            this.Load += new System.EventHandler(this.AddGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_statusmsg;
    }
}