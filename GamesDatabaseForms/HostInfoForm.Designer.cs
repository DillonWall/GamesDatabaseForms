namespace GamesDatabaseForms
{
    partial class HostInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_minpart = new System.Windows.Forms.Label();
            this.lbl_maxpart = new System.Windows.Forms.Label();
            this.lbl_minspec = new System.Windows.Forms.Label();
            this.lbl_maxspec = new System.Windows.Forms.Label();
            this.lbl_foodavail = new System.Windows.Forms.Label();
            this.txt_minpart = new System.Windows.Forms.TextBox();
            this.txt_maxpart = new System.Windows.Forms.TextBox();
            this.txt_minspec = new System.Windows.Forms.TextBox();
            this.txt_maxspec = new System.Windows.Forms.TextBox();
            this.chk_food = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify and Setup Host Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_maxspec, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_minspec, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_maxpart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_minpart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_maxpart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_minspec, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_foodavail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_maxspec, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_minpart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chk_food, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 348);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(337, 347);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 75);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_minpart
            // 
            this.lbl_minpart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_minpart.AutoSize = true;
            this.lbl_minpart.Location = new System.Drawing.Point(15, 28);
            this.lbl_minpart.Name = "lbl_minpart";
            this.lbl_minpart.Size = new System.Drawing.Size(109, 13);
            this.lbl_minpart.TabIndex = 0;
            this.lbl_minpart.Text = "Minimum Participants:";
            // 
            // lbl_maxpart
            // 
            this.lbl_maxpart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_maxpart.AutoSize = true;
            this.lbl_maxpart.Location = new System.Drawing.Point(12, 97);
            this.lbl_maxpart.Name = "lbl_maxpart";
            this.lbl_maxpart.Size = new System.Drawing.Size(112, 13);
            this.lbl_maxpart.TabIndex = 1;
            this.lbl_maxpart.Text = "Maximum Participants:";
            // 
            // lbl_minspec
            // 
            this.lbl_minspec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_minspec.AutoSize = true;
            this.lbl_minspec.Location = new System.Drawing.Point(19, 166);
            this.lbl_minspec.Name = "lbl_minspec";
            this.lbl_minspec.Size = new System.Drawing.Size(105, 13);
            this.lbl_minspec.TabIndex = 2;
            this.lbl_minspec.Text = "Minimum Spectators:";
            // 
            // lbl_maxspec
            // 
            this.lbl_maxspec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_maxspec.AutoSize = true;
            this.lbl_maxspec.Location = new System.Drawing.Point(16, 235);
            this.lbl_maxspec.Name = "lbl_maxspec";
            this.lbl_maxspec.Size = new System.Drawing.Size(108, 13);
            this.lbl_maxspec.TabIndex = 3;
            this.lbl_maxspec.Text = "Maximum Spectators:";
            // 
            // lbl_foodavail
            // 
            this.lbl_foodavail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_foodavail.AutoSize = true;
            this.lbl_foodavail.Location = new System.Drawing.Point(42, 305);
            this.lbl_foodavail.Name = "lbl_foodavail";
            this.lbl_foodavail.Size = new System.Drawing.Size(82, 13);
            this.lbl_foodavail.TabIndex = 4;
            this.lbl_foodavail.Text = "Food available?";
            // 
            // txt_minpart
            // 
            this.txt_minpart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_minpart.Location = new System.Drawing.Point(130, 24);
            this.txt_minpart.Name = "txt_minpart";
            this.txt_minpart.Size = new System.Drawing.Size(53, 20);
            this.txt_minpart.TabIndex = 5;
            // 
            // txt_maxpart
            // 
            this.txt_maxpart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_maxpart.Location = new System.Drawing.Point(130, 93);
            this.txt_maxpart.Name = "txt_maxpart";
            this.txt_maxpart.Size = new System.Drawing.Size(53, 20);
            this.txt_maxpart.TabIndex = 6;
            // 
            // txt_minspec
            // 
            this.txt_minspec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_minspec.Location = new System.Drawing.Point(130, 162);
            this.txt_minspec.Name = "txt_minspec";
            this.txt_minspec.Size = new System.Drawing.Size(53, 20);
            this.txt_minspec.TabIndex = 7;
            // 
            // txt_maxspec
            // 
            this.txt_maxspec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_maxspec.Location = new System.Drawing.Point(130, 231);
            this.txt_maxspec.Name = "txt_maxspec";
            this.txt_maxspec.Size = new System.Drawing.Size(53, 20);
            this.txt_maxspec.TabIndex = 8;
            // 
            // chk_food
            // 
            this.chk_food.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_food.AutoSize = true;
            this.chk_food.Location = new System.Drawing.Point(130, 305);
            this.chk_food.Name = "chk_food";
            this.chk_food.Size = new System.Drawing.Size(15, 14);
            this.chk_food.TabIndex = 9;
            this.chk_food.UseVisualStyleBackColor = true;
            // 
            // HostInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "HostInfoForm";
            this.Text = "Host Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_maxspec;
        private System.Windows.Forms.TextBox txt_minspec;
        private System.Windows.Forms.TextBox txt_maxpart;
        private System.Windows.Forms.Label lbl_minpart;
        private System.Windows.Forms.Label lbl_maxpart;
        private System.Windows.Forms.Label lbl_minspec;
        private System.Windows.Forms.Label lbl_foodavail;
        private System.Windows.Forms.Label lbl_maxspec;
        private System.Windows.Forms.TextBox txt_minpart;
        private System.Windows.Forms.CheckBox chk_food;
    }
}