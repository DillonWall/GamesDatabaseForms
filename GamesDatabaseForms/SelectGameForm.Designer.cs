namespace GamesDatabaseForms
{
    partial class SelectGameForm
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
            this.dataGrid_gameEvents = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gameEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_gameEvents
            // 
            this.dataGrid_gameEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_gameEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_gameEvents.Location = new System.Drawing.Point(37, 56);
            this.dataGrid_gameEvents.Name = "dataGrid_gameEvents";
            this.dataGrid_gameEvents.Size = new System.Drawing.Size(726, 325);
            this.dataGrid_gameEvents.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(34, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Select a game event";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(634, 388);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(129, 50);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "Use Selected Game";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // SelectGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dataGrid_gameEvents);
            this.Name = "SelectGameForm";
            this.Text = "SelectGameForm";
            this.Load += new System.EventHandler(this.SelectGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_gameEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_gameEvents;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_select;
    }
}