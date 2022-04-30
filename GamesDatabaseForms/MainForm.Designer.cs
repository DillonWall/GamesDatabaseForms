namespace GamesDatabaseForms
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            this.tabctrl_main = new System.Windows.Forms.TabControl();
            this.tab_create = new System.Windows.Forms.TabPage();
            this.btn_modify_host_info = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_host_price = new System.Windows.Forms.TextBox();
            this.lbl_part_price = new System.Windows.Forms.Label();
            this.lbl_spec_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_price_host = new System.Windows.Forms.Label();
            this.txt_participant_price = new System.Windows.Forms.TextBox();
            this.txt_spectator_price = new System.Windows.Forms.TextBox();
            this.lbl_statusmsg_createtab = new System.Windows.Forms.Label();
            this.btn_addnewgame = new System.Windows.Forms.Button();
            this.lbl_createtab_header = new System.Windows.Forms.Label();
            this.tableLayoutPanel_createtab = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_createtab_3 = new System.Windows.Forms.Label();
            this.lbl_createtab_4 = new System.Windows.Forms.Label();
            this.lbl_createtab_2 = new System.Windows.Forms.Label();
            this.lbl_createtab_5 = new System.Windows.Forms.Label();
            this.lbl_createtab_1 = new System.Windows.Forms.Label();
            this.cmb_gameselect = new System.Windows.Forms.ComboBox();
            this.gamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dillonwallDataSet = new GamesDatabaseForms.dillonwallDataSet();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.dateTime_date = new System.Windows.Forms.DateTimePicker();
            this.dateTime_starttime = new System.Windows.Forms.DateTimePicker();
            this.dateTime_endtime = new System.Windows.Forms.DateTimePicker();
            this.btn_create_createtab = new System.Windows.Forms.Button();
            this.tab_find = new System.Windows.Forms.TabPage();
            this.lbl_statusmsg_findtab = new System.Windows.Forms.Label();
            this.btn_joinSpectator = new System.Windows.Forms.Button();
            this.btn_joinParticipant = new System.Windows.Forms.Button();
            this.dataGrid_findtab = new System.Windows.Forms.DataGridView();
            this.lbl_findtab_header = new System.Windows.Forms.Label();
            this.tab_account = new System.Windows.Forms.TabPage();
            this.lbl_accounttab_header = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_address_accounttab = new System.Windows.Forms.TextBox();
            this.txt_gender_accounttab = new System.Windows.Forms.TextBox();
            this.txt_age_accounttab = new System.Windows.Forms.TextBox();
            this.txt_phone_accounttab = new System.Windows.Forms.TextBox();
            this.txt_email_accounttab = new System.Windows.Forms.TextBox();
            this.txt_handle_accounttab = new System.Windows.Forms.TextBox();
            this.btn_edit_phone = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_handle = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_edit_name = new System.Windows.Forms.Button();
            this.btn_edit_handle = new System.Windows.Forms.Button();
            this.btn_edit_email = new System.Windows.Forms.Button();
            this.btn_edit_age = new System.Windows.Forms.Button();
            this.btn_edit_gender = new System.Windows.Forms.Button();
            this.btn_edit_description = new System.Windows.Forms.Button();
            this.btn_edit_address = new System.Windows.Forms.Button();
            this.txt_name_accounttab = new System.Windows.Forms.TextBox();
            this.rtxt_description_accounttab = new System.Windows.Forms.RichTextBox();
            this.tab_history = new System.Windows.Forms.TabPage();
            this.dataGrid_historytab = new System.Windows.Forms.DataGridView();
            this.lbl_historytab_header = new System.Windows.Forms.Label();
            this.tab_people = new System.Windows.Forms.TabPage();
            this.btn_selectGame = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_spect_peopletab = new System.Windows.Forms.DataGridView();
            this.dataGrid_part_peopletab = new System.Windows.Forms.DataGridView();
            this.dataGrid_host_peopletab = new System.Windows.Forms.DataGridView();
            this.lbl_peopletab_header = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new GamesDatabaseForms.dillonwallDataSetTableAdapters.gamesTableAdapter();
            this.tabctrl_main.SuspendLayout();
            this.tab_create.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_createtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dillonwallDataSet)).BeginInit();
            this.tab_find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_findtab)).BeginInit();
            this.tab_account.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_historytab)).BeginInit();
            this.tab_people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_spect_peopletab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_part_peopletab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_host_peopletab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrl_main
            // 
            this.tabctrl_main.Controls.Add(this.tab_create);
            this.tabctrl_main.Controls.Add(this.tab_find);
            this.tabctrl_main.Controls.Add(this.tab_account);
            this.tabctrl_main.Controls.Add(this.tab_history);
            this.tabctrl_main.Controls.Add(this.tab_people);
            this.tabctrl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_main.Location = new System.Drawing.Point(0, 0);
            this.tabctrl_main.Name = "tabctrl_main";
            this.tabctrl_main.SelectedIndex = 0;
            this.tabctrl_main.Size = new System.Drawing.Size(800, 442);
            this.tabctrl_main.TabIndex = 50;
            // 
            // tab_create
            // 
            this.tab_create.Controls.Add(this.btn_modify_host_info);
            this.tab_create.Controls.Add(this.tableLayoutPanel1);
            this.tab_create.Controls.Add(this.lbl_statusmsg_createtab);
            this.tab_create.Controls.Add(this.btn_addnewgame);
            this.tab_create.Controls.Add(this.lbl_createtab_header);
            this.tab_create.Controls.Add(this.tableLayoutPanel_createtab);
            this.tab_create.Controls.Add(this.btn_create_createtab);
            this.tab_create.Location = new System.Drawing.Point(4, 22);
            this.tab_create.Name = "tab_create";
            this.tab_create.Padding = new System.Windows.Forms.Padding(3);
            this.tab_create.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_create.Size = new System.Drawing.Size(792, 416);
            this.tab_create.TabIndex = 0;
            this.tab_create.Text = "Create";
            this.tab_create.UseVisualStyleBackColor = true;
            // 
            // btn_modify_host_info
            // 
            this.btn_modify_host_info.Location = new System.Drawing.Point(656, 77);
            this.btn_modify_host_info.Name = "btn_modify_host_info";
            this.btn_modify_host_info.Size = new System.Drawing.Size(128, 67);
            this.btn_modify_host_info.TabIndex = 56;
            this.btn_modify_host_info.Text = "Modify/Setup Host Information";
            this.btn_modify_host_info.UseVisualStyleBackColor = true;
            this.btn_modify_host_info.Click += new System.EventHandler(this.btn_modify_host_info_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_host_price, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_part_price, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_spec_price, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_price_host, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_participant_price, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_spectator_price, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(447, 208);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 185);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // txt_host_price
            // 
            this.txt_host_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_host_price.Location = new System.Drawing.Point(126, 20);
            this.txt_host_price.Name = "txt_host_price";
            this.txt_host_price.Size = new System.Drawing.Size(119, 20);
            this.txt_host_price.TabIndex = 3;
            // 
            // lbl_part_price
            // 
            this.lbl_part_price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_part_price.AutoSize = true;
            this.lbl_part_price.Location = new System.Drawing.Point(9, 85);
            this.lbl_part_price.Name = "lbl_part_price";
            this.lbl_part_price.Size = new System.Drawing.Size(87, 13);
            this.lbl_part_price.TabIndex = 1;
            this.lbl_part_price.Text = "Participant Price:";
            // 
            // lbl_spec_price
            // 
            this.lbl_spec_price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_spec_price.AutoSize = true;
            this.lbl_spec_price.Location = new System.Drawing.Point(13, 147);
            this.lbl_spec_price.Name = "lbl_spec_price";
            this.lbl_spec_price.Size = new System.Drawing.Size(83, 13);
            this.lbl_spec_price.TabIndex = 2;
            this.lbl_spec_price.Text = "Spectator Price:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // lbl_price_host
            // 
            this.lbl_price_host.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_price_host.AutoSize = true;
            this.lbl_price_host.Location = new System.Drawing.Point(37, 24);
            this.lbl_price_host.Name = "lbl_price_host";
            this.lbl_price_host.Size = new System.Drawing.Size(59, 13);
            this.lbl_price_host.TabIndex = 0;
            this.lbl_price_host.Text = "Host Price:";
            // 
            // txt_participant_price
            // 
            this.txt_participant_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_participant_price.Location = new System.Drawing.Point(126, 81);
            this.txt_participant_price.Name = "txt_participant_price";
            this.txt_participant_price.Size = new System.Drawing.Size(119, 20);
            this.txt_participant_price.TabIndex = 4;
            // 
            // txt_spectator_price
            // 
            this.txt_spectator_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_spectator_price.Location = new System.Drawing.Point(126, 143);
            this.txt_spectator_price.Name = "txt_spectator_price";
            this.txt_spectator_price.Size = new System.Drawing.Size(119, 20);
            this.txt_spectator_price.TabIndex = 5;
            // 
            // lbl_statusmsg_createtab
            // 
            this.lbl_statusmsg_createtab.AutoSize = true;
            this.lbl_statusmsg_createtab.Location = new System.Drawing.Point(577, 30);
            this.lbl_statusmsg_createtab.Name = "lbl_statusmsg_createtab";
            this.lbl_statusmsg_createtab.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusmsg_createtab.TabIndex = 54;
            // 
            // btn_addnewgame
            // 
            this.btn_addnewgame.Location = new System.Drawing.Point(447, 97);
            this.btn_addnewgame.Name = "btn_addnewgame";
            this.btn_addnewgame.Size = new System.Drawing.Size(90, 23);
            this.btn_addnewgame.TabIndex = 53;
            this.btn_addnewgame.Text = "Add New Game";
            this.btn_addnewgame.UseVisualStyleBackColor = true;
            this.btn_addnewgame.Click += new System.EventHandler(this.btn_addnewgame_Click);
            // 
            // lbl_createtab_header
            // 
            this.lbl_createtab_header.AutoSize = true;
            this.lbl_createtab_header.Location = new System.Drawing.Point(28, 30);
            this.lbl_createtab_header.Name = "lbl_createtab_header";
            this.lbl_createtab_header.Size = new System.Drawing.Size(78, 13);
            this.lbl_createtab_header.TabIndex = 6;
            this.lbl_createtab_header.Text = "Create a Game";
            // 
            // tableLayoutPanel_createtab
            // 
            this.tableLayoutPanel_createtab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_createtab.ColumnCount = 2;
            this.tableLayoutPanel_createtab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_createtab.Controls.Add(this.lbl_createtab_3, 0, 2);
            this.tableLayoutPanel_createtab.Controls.Add(this.lbl_createtab_4, 0, 3);
            this.tableLayoutPanel_createtab.Controls.Add(this.lbl_createtab_2, 0, 1);
            this.tableLayoutPanel_createtab.Controls.Add(this.lbl_createtab_5, 0, 4);
            this.tableLayoutPanel_createtab.Controls.Add(this.lbl_createtab_1, 0, 0);
            this.tableLayoutPanel_createtab.Controls.Add(this.cmb_gameselect, 1, 0);
            this.tableLayoutPanel_createtab.Controls.Add(this.txt_location, 1, 1);
            this.tableLayoutPanel_createtab.Controls.Add(this.dateTime_date, 1, 2);
            this.tableLayoutPanel_createtab.Controls.Add(this.dateTime_starttime, 1, 3);
            this.tableLayoutPanel_createtab.Controls.Add(this.dateTime_endtime, 1, 4);
            this.tableLayoutPanel_createtab.Location = new System.Drawing.Point(26, 77);
            this.tableLayoutPanel_createtab.Name = "tableLayoutPanel_createtab";
            this.tableLayoutPanel_createtab.RowCount = 5;
            this.tableLayoutPanel_createtab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_createtab.Size = new System.Drawing.Size(415, 316);
            this.tableLayoutPanel_createtab.TabIndex = 7;
            // 
            // lbl_createtab_3
            // 
            this.lbl_createtab_3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createtab_3.AutoSize = true;
            this.lbl_createtab_3.Location = new System.Drawing.Point(50, 151);
            this.lbl_createtab_3.Name = "lbl_createtab_3";
            this.lbl_createtab_3.Size = new System.Drawing.Size(30, 13);
            this.lbl_createtab_3.TabIndex = 4;
            this.lbl_createtab_3.Text = "Date";
            // 
            // lbl_createtab_4
            // 
            this.lbl_createtab_4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createtab_4.AutoSize = true;
            this.lbl_createtab_4.Location = new System.Drawing.Point(25, 214);
            this.lbl_createtab_4.Name = "lbl_createtab_4";
            this.lbl_createtab_4.Size = new System.Drawing.Size(55, 13);
            this.lbl_createtab_4.TabIndex = 5;
            this.lbl_createtab_4.Text = "Start Time";
            // 
            // lbl_createtab_2
            // 
            this.lbl_createtab_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createtab_2.AutoSize = true;
            this.lbl_createtab_2.Location = new System.Drawing.Point(32, 88);
            this.lbl_createtab_2.Name = "lbl_createtab_2";
            this.lbl_createtab_2.Size = new System.Drawing.Size(48, 13);
            this.lbl_createtab_2.TabIndex = 2;
            this.lbl_createtab_2.Text = "Location";
            // 
            // lbl_createtab_5
            // 
            this.lbl_createtab_5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createtab_5.AutoSize = true;
            this.lbl_createtab_5.Location = new System.Drawing.Point(28, 277);
            this.lbl_createtab_5.Name = "lbl_createtab_5";
            this.lbl_createtab_5.Size = new System.Drawing.Size(52, 13);
            this.lbl_createtab_5.TabIndex = 3;
            this.lbl_createtab_5.Text = "End Time";
            // 
            // lbl_createtab_1
            // 
            this.lbl_createtab_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createtab_1.AutoSize = true;
            this.lbl_createtab_1.Location = new System.Drawing.Point(45, 25);
            this.lbl_createtab_1.Name = "lbl_createtab_1";
            this.lbl_createtab_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_createtab_1.TabIndex = 1;
            this.lbl_createtab_1.Text = "Game";
            // 
            // cmb_gameselect
            // 
            this.cmb_gameselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gameselect.DataSource = this.gamesBindingSource1;
            this.cmb_gameselect.DisplayMember = "game_title";
            this.cmb_gameselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gameselect.FormattingEnabled = true;
            this.cmb_gameselect.Location = new System.Drawing.Point(86, 21);
            this.cmb_gameselect.Name = "cmb_gameselect";
            this.cmb_gameselect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_gameselect.Size = new System.Drawing.Size(326, 21);
            this.cmb_gameselect.TabIndex = 6;
            // 
            // gamesBindingSource1
            // 
            this.gamesBindingSource1.DataMember = "games";
            this.gamesBindingSource1.DataSource = this.dillonwallDataSet;
            // 
            // dillonwallDataSet
            // 
            this.dillonwallDataSet.DataSetName = "dillonwallDataSet";
            this.dillonwallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_location
            // 
            this.txt_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_location.Location = new System.Drawing.Point(86, 84);
            this.txt_location.Name = "txt_location";
            this.txt_location.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_location.Size = new System.Drawing.Size(326, 20);
            this.txt_location.TabIndex = 7;
            // 
            // dateTime_date
            // 
            this.dateTime_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_date.Location = new System.Drawing.Point(86, 147);
            this.dateTime_date.Name = "dateTime_date";
            this.dateTime_date.Size = new System.Drawing.Size(326, 20);
            this.dateTime_date.TabIndex = 8;
            // 
            // dateTime_starttime
            // 
            this.dateTime_starttime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_starttime.Location = new System.Drawing.Point(86, 210);
            this.dateTime_starttime.Name = "dateTime_starttime";
            this.dateTime_starttime.ShowUpDown = true;
            this.dateTime_starttime.Size = new System.Drawing.Size(326, 20);
            this.dateTime_starttime.TabIndex = 9;
            this.dateTime_starttime.Value = new System.DateTime(2019, 11, 19, 13, 0, 0, 0);
            // 
            // dateTime_endtime
            // 
            this.dateTime_endtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_endtime.CustomFormat = "";
            this.dateTime_endtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_endtime.Location = new System.Drawing.Point(86, 274);
            this.dateTime_endtime.Name = "dateTime_endtime";
            this.dateTime_endtime.ShowUpDown = true;
            this.dateTime_endtime.Size = new System.Drawing.Size(326, 20);
            this.dateTime_endtime.TabIndex = 10;
            this.dateTime_endtime.Value = new System.DateTime(2019, 11, 19, 13, 0, 0, 0);
            // 
            // btn_create_createtab
            // 
            this.btn_create_createtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create_createtab.Location = new System.Drawing.Point(709, 343);
            this.btn_create_createtab.Name = "btn_create_createtab";
            this.btn_create_createtab.Size = new System.Drawing.Size(75, 35);
            this.btn_create_createtab.TabIndex = 11;
            this.btn_create_createtab.Text = "Create";
            this.btn_create_createtab.UseVisualStyleBackColor = true;
            this.btn_create_createtab.Click += new System.EventHandler(this.btn_create_createtab_Click);
            // 
            // tab_find
            // 
            this.tab_find.Controls.Add(this.lbl_statusmsg_findtab);
            this.tab_find.Controls.Add(this.btn_joinSpectator);
            this.tab_find.Controls.Add(this.btn_joinParticipant);
            this.tab_find.Controls.Add(this.dataGrid_findtab);
            this.tab_find.Controls.Add(this.lbl_findtab_header);
            this.tab_find.Location = new System.Drawing.Point(4, 22);
            this.tab_find.Name = "tab_find";
            this.tab_find.Padding = new System.Windows.Forms.Padding(3);
            this.tab_find.Size = new System.Drawing.Size(792, 416);
            this.tab_find.TabIndex = 1;
            this.tab_find.Text = "Find";
            this.tab_find.UseVisualStyleBackColor = true;
            // 
            // lbl_statusmsg_findtab
            // 
            this.lbl_statusmsg_findtab.AutoSize = true;
            this.lbl_statusmsg_findtab.Location = new System.Drawing.Point(563, 18);
            this.lbl_statusmsg_findtab.Name = "lbl_statusmsg_findtab";
            this.lbl_statusmsg_findtab.Size = new System.Drawing.Size(0, 13);
            this.lbl_statusmsg_findtab.TabIndex = 5;
            // 
            // btn_joinSpectator
            // 
            this.btn_joinSpectator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_joinSpectator.Location = new System.Drawing.Point(665, 350);
            this.btn_joinSpectator.Name = "btn_joinSpectator";
            this.btn_joinSpectator.Size = new System.Drawing.Size(98, 39);
            this.btn_joinSpectator.TabIndex = 4;
            this.btn_joinSpectator.Text = "Join as Spectator";
            this.btn_joinSpectator.UseVisualStyleBackColor = true;
            this.btn_joinSpectator.Click += new System.EventHandler(this.btn_joinSpectator_Click);
            // 
            // btn_joinParticipant
            // 
            this.btn_joinParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_joinParticipant.Location = new System.Drawing.Point(665, 305);
            this.btn_joinParticipant.Name = "btn_joinParticipant";
            this.btn_joinParticipant.Size = new System.Drawing.Size(98, 39);
            this.btn_joinParticipant.TabIndex = 3;
            this.btn_joinParticipant.Text = "Join as Participant";
            this.btn_joinParticipant.UseVisualStyleBackColor = true;
            this.btn_joinParticipant.Click += new System.EventHandler(this.btn_joinParticipant_Click);
            // 
            // dataGrid_findtab
            // 
            this.dataGrid_findtab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_findtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_findtab.Location = new System.Drawing.Point(29, 51);
            this.dataGrid_findtab.Name = "dataGrid_findtab";
            this.dataGrid_findtab.Size = new System.Drawing.Size(605, 357);
            this.dataGrid_findtab.TabIndex = 1;
            // 
            // lbl_findtab_header
            // 
            this.lbl_findtab_header.AutoSize = true;
            this.lbl_findtab_header.Location = new System.Drawing.Point(26, 18);
            this.lbl_findtab_header.Name = "lbl_findtab_header";
            this.lbl_findtab_header.Size = new System.Drawing.Size(140, 13);
            this.lbl_findtab_header.TabIndex = 0;
            this.lbl_findtab_header.Text = "Find upcoming game events";
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.lbl_accounttab_header);
            this.tab_account.Controls.Add(this.tableLayoutPanel2);
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Size = new System.Drawing.Size(792, 416);
            this.tab_account.TabIndex = 2;
            this.tab_account.Text = "My Account";
            this.tab_account.UseVisualStyleBackColor = true;
            // 
            // lbl_accounttab_header
            // 
            this.lbl_accounttab_header.AutoSize = true;
            this.lbl_accounttab_header.Location = new System.Drawing.Point(40, 33);
            this.lbl_accounttab_header.Name = "lbl_accounttab_header";
            this.lbl_accounttab_header.Size = new System.Drawing.Size(144, 13);
            this.lbl_accounttab_header.TabIndex = 1;
            this.lbl_accounttab_header.Text = "Account Details and Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txt_address_accounttab, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_gender_accounttab, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_age_accounttab, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_phone_accounttab, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_email_accounttab, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_handle_accounttab, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_phone, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_handle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_email, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_phone, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_age, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_gender, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_description, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbl_address, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_name, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_handle, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_email, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_age, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_gender, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_description, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_edit_address, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_name_accounttab, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rtxt_description_accounttab, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 325);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_address_accounttab
            // 
            this.txt_address_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address_accounttab.Enabled = false;
            this.txt_address_accounttab.Location = new System.Drawing.Point(80, 281);
            this.txt_address_accounttab.Name = "txt_address_accounttab";
            this.txt_address_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_address_accounttab.TabIndex = 8;
            this.txt_address_accounttab.Text = "N/A";
            // 
            // txt_gender_accounttab
            // 
            this.txt_gender_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_gender_accounttab.Enabled = false;
            this.txt_gender_accounttab.Location = new System.Drawing.Point(80, 166);
            this.txt_gender_accounttab.Name = "txt_gender_accounttab";
            this.txt_gender_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_gender_accounttab.TabIndex = 6;
            this.txt_gender_accounttab.Text = "N/A";
            // 
            // txt_age_accounttab
            // 
            this.txt_age_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_age_accounttab.Enabled = false;
            this.txt_age_accounttab.Location = new System.Drawing.Point(80, 134);
            this.txt_age_accounttab.Name = "txt_age_accounttab";
            this.txt_age_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_age_accounttab.TabIndex = 5;
            this.txt_age_accounttab.Text = "N/A";
            // 
            // txt_phone_accounttab
            // 
            this.txt_phone_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone_accounttab.Enabled = false;
            this.txt_phone_accounttab.Location = new System.Drawing.Point(80, 102);
            this.txt_phone_accounttab.Name = "txt_phone_accounttab";
            this.txt_phone_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_phone_accounttab.TabIndex = 4;
            this.txt_phone_accounttab.Text = "N/A";
            // 
            // txt_email_accounttab
            // 
            this.txt_email_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email_accounttab.Enabled = false;
            this.txt_email_accounttab.Location = new System.Drawing.Point(80, 70);
            this.txt_email_accounttab.Name = "txt_email_accounttab";
            this.txt_email_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_email_accounttab.TabIndex = 3;
            this.txt_email_accounttab.Text = "N/A";
            // 
            // txt_handle_accounttab
            // 
            this.txt_handle_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_handle_accounttab.Enabled = false;
            this.txt_handle_accounttab.Location = new System.Drawing.Point(80, 38);
            this.txt_handle_accounttab.Name = "txt_handle_accounttab";
            this.txt_handle_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_handle_accounttab.TabIndex = 2;
            this.txt_handle_accounttab.Text = "N/A";
            // 
            // btn_edit_phone
            // 
            this.btn_edit_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_phone.Location = new System.Drawing.Point(700, 100);
            this.btn_edit_phone.Name = "btn_edit_phone";
            this.btn_edit_phone.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_phone.TabIndex = 12;
            this.btn_edit_phone.Text = "Edit";
            this.btn_edit_phone.UseVisualStyleBackColor = true;
            this.btn_edit_phone.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(36, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_handle
            // 
            this.lbl_handle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_handle.AutoSize = true;
            this.lbl_handle.Location = new System.Drawing.Point(30, 35);
            this.lbl_handle.Name = "lbl_handle";
            this.lbl_handle.Size = new System.Drawing.Size(44, 26);
            this.lbl_handle.TabIndex = 3;
            this.lbl_handle.Text = "Display Name:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(39, 73);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(27, 99);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(47, 26);
            this.lbl_phone.TabIndex = 5;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // lbl_age
            // 
            this.lbl_age.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(45, 137);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(29, 13);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "Age:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(29, 169);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(45, 13);
            this.lbl_gender.TabIndex = 7;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(11, 218);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(63, 13);
            this.lbl_description.TabIndex = 8;
            this.lbl_description.Text = "Description:";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(26, 284);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Address:";
            // 
            // btn_edit_name
            // 
            this.btn_edit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_name.Location = new System.Drawing.Point(700, 4);
            this.btn_edit_name.Name = "btn_edit_name";
            this.btn_edit_name.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_name.TabIndex = 9;
            this.btn_edit_name.Text = "Edit";
            this.btn_edit_name.UseVisualStyleBackColor = true;
            this.btn_edit_name.Visible = false;
            // 
            // btn_edit_handle
            // 
            this.btn_edit_handle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_handle.Location = new System.Drawing.Point(700, 36);
            this.btn_edit_handle.Name = "btn_edit_handle";
            this.btn_edit_handle.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_handle.TabIndex = 10;
            this.btn_edit_handle.Text = "Edit";
            this.btn_edit_handle.UseVisualStyleBackColor = true;
            this.btn_edit_handle.Visible = false;
            // 
            // btn_edit_email
            // 
            this.btn_edit_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_email.Location = new System.Drawing.Point(700, 68);
            this.btn_edit_email.Name = "btn_edit_email";
            this.btn_edit_email.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_email.TabIndex = 11;
            this.btn_edit_email.Text = "Edit";
            this.btn_edit_email.UseVisualStyleBackColor = true;
            this.btn_edit_email.Visible = false;
            // 
            // btn_edit_age
            // 
            this.btn_edit_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_age.Location = new System.Drawing.Point(700, 132);
            this.btn_edit_age.Name = "btn_edit_age";
            this.btn_edit_age.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_age.TabIndex = 13;
            this.btn_edit_age.Text = "Edit";
            this.btn_edit_age.UseVisualStyleBackColor = true;
            this.btn_edit_age.Visible = false;
            // 
            // btn_edit_gender
            // 
            this.btn_edit_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_gender.Location = new System.Drawing.Point(700, 164);
            this.btn_edit_gender.Name = "btn_edit_gender";
            this.btn_edit_gender.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_gender.TabIndex = 14;
            this.btn_edit_gender.Text = "Edit";
            this.btn_edit_gender.UseVisualStyleBackColor = true;
            this.btn_edit_gender.Visible = false;
            // 
            // btn_edit_description
            // 
            this.btn_edit_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_description.Location = new System.Drawing.Point(700, 213);
            this.btn_edit_description.Name = "btn_edit_description";
            this.btn_edit_description.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_description.TabIndex = 15;
            this.btn_edit_description.Text = "Edit";
            this.btn_edit_description.UseVisualStyleBackColor = true;
            this.btn_edit_description.Visible = false;
            // 
            // btn_edit_address
            // 
            this.btn_edit_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_address.Location = new System.Drawing.Point(700, 279);
            this.btn_edit_address.Name = "btn_edit_address";
            this.btn_edit_address.Size = new System.Drawing.Size(73, 23);
            this.btn_edit_address.TabIndex = 16;
            this.btn_edit_address.Text = "Edit";
            this.btn_edit_address.UseVisualStyleBackColor = true;
            this.btn_edit_address.Visible = false;
            // 
            // txt_name_accounttab
            // 
            this.txt_name_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_accounttab.Enabled = false;
            this.txt_name_accounttab.Location = new System.Drawing.Point(80, 6);
            this.txt_name_accounttab.Name = "txt_name_accounttab";
            this.txt_name_accounttab.Size = new System.Drawing.Size(614, 20);
            this.txt_name_accounttab.TabIndex = 1;
            this.txt_name_accounttab.Text = "N/A";
            // 
            // rtxt_description_accounttab
            // 
            this.rtxt_description_accounttab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt_description_accounttab.Enabled = false;
            this.rtxt_description_accounttab.Location = new System.Drawing.Point(80, 195);
            this.rtxt_description_accounttab.Name = "rtxt_description_accounttab";
            this.rtxt_description_accounttab.Size = new System.Drawing.Size(614, 59);
            this.rtxt_description_accounttab.TabIndex = 7;
            this.rtxt_description_accounttab.Text = "N/A";
            // 
            // tab_history
            // 
            this.tab_history.Controls.Add(this.dataGrid_historytab);
            this.tab_history.Controls.Add(this.lbl_historytab_header);
            this.tab_history.Location = new System.Drawing.Point(4, 22);
            this.tab_history.Name = "tab_history";
            this.tab_history.Size = new System.Drawing.Size(792, 416);
            this.tab_history.TabIndex = 3;
            this.tab_history.Text = "History";
            this.tab_history.UseVisualStyleBackColor = true;
            // 
            // dataGrid_historytab
            // 
            this.dataGrid_historytab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_historytab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_historytab.Location = new System.Drawing.Point(35, 57);
            this.dataGrid_historytab.Name = "dataGrid_historytab";
            this.dataGrid_historytab.Size = new System.Drawing.Size(726, 339);
            this.dataGrid_historytab.TabIndex = 1;
            // 
            // lbl_historytab_header
            // 
            this.lbl_historytab_header.AutoSize = true;
            this.lbl_historytab_header.Location = new System.Drawing.Point(32, 21);
            this.lbl_historytab_header.Name = "lbl_historytab_header";
            this.lbl_historytab_header.Size = new System.Drawing.Size(64, 13);
            this.lbl_historytab_header.TabIndex = 0;
            this.lbl_historytab_header.Text = "Past Games";
            // 
            // tab_people
            // 
            this.tab_people.Controls.Add(this.btn_selectGame);
            this.tab_people.Controls.Add(this.label6);
            this.tab_people.Controls.Add(this.label5);
            this.tab_people.Controls.Add(this.label4);
            this.tab_people.Controls.Add(this.dataGrid_spect_peopletab);
            this.tab_people.Controls.Add(this.dataGrid_part_peopletab);
            this.tab_people.Controls.Add(this.dataGrid_host_peopletab);
            this.tab_people.Controls.Add(this.lbl_peopletab_header);
            this.tab_people.Location = new System.Drawing.Point(4, 22);
            this.tab_people.Name = "tab_people";
            this.tab_people.Size = new System.Drawing.Size(792, 416);
            this.tab_people.TabIndex = 4;
            this.tab_people.Text = "People";
            this.tab_people.UseVisualStyleBackColor = true;
            // 
            // btn_selectGame
            // 
            this.btn_selectGame.Location = new System.Drawing.Point(676, 11);
            this.btn_selectGame.Name = "btn_selectGame";
            this.btn_selectGame.Size = new System.Drawing.Size(108, 36);
            this.btn_selectGame.TabIndex = 17;
            this.btn_selectGame.Text = "Select Game";
            this.btn_selectGame.UseVisualStyleBackColor = true;
            this.btn_selectGame.Click += new System.EventHandler(this.btn_selectGame_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Spectators";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Participants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hosts";
            // 
            // dataGrid_spect_peopletab
            // 
            this.dataGrid_spect_peopletab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_spect_peopletab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_spect_peopletab.Location = new System.Drawing.Point(94, 285);
            this.dataGrid_spect_peopletab.Name = "dataGrid_spect_peopletab";
            this.dataGrid_spect_peopletab.Size = new System.Drawing.Size(605, 116);
            this.dataGrid_spect_peopletab.TabIndex = 13;
            // 
            // dataGrid_part_peopletab
            // 
            this.dataGrid_part_peopletab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_part_peopletab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_part_peopletab.Location = new System.Drawing.Point(94, 152);
            this.dataGrid_part_peopletab.Name = "dataGrid_part_peopletab";
            this.dataGrid_part_peopletab.Size = new System.Drawing.Size(605, 111);
            this.dataGrid_part_peopletab.TabIndex = 12;
            // 
            // dataGrid_host_peopletab
            // 
            this.dataGrid_host_peopletab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_host_peopletab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_host_peopletab.Location = new System.Drawing.Point(94, 53);
            this.dataGrid_host_peopletab.Name = "dataGrid_host_peopletab";
            this.dataGrid_host_peopletab.Size = new System.Drawing.Size(605, 70);
            this.dataGrid_host_peopletab.TabIndex = 11;
            // 
            // lbl_peopletab_header
            // 
            this.lbl_peopletab_header.AutoSize = true;
            this.lbl_peopletab_header.Location = new System.Drawing.Point(32, 21);
            this.lbl_peopletab_header.Name = "lbl_peopletab_header";
            this.lbl_peopletab_header.Size = new System.Drawing.Size(109, 13);
            this.lbl_peopletab_header.TabIndex = 2;
            this.lbl_peopletab_header.Text = "View People In Game";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Location = new System.Drawing.Point(696, 0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 23);
            this.btn_login.TabIndex = 51;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(518, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(79, 13);
            this.lbl_username.TabIndex = 52;
            this.lbl_username.Text = "Not logged in...";
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.dillonwallDataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tabctrl_main);
            this.Name = "frm_main";
            this.Text = "Game Registration System by Dillon Wall";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tabctrl_main.ResumeLayout(false);
            this.tab_create.ResumeLayout(false);
            this.tab_create.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_createtab.ResumeLayout(false);
            this.tableLayoutPanel_createtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dillonwallDataSet)).EndInit();
            this.tab_find.ResumeLayout(false);
            this.tab_find.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_findtab)).EndInit();
            this.tab_account.ResumeLayout(false);
            this.tab_account.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tab_history.ResumeLayout(false);
            this.tab_history.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_historytab)).EndInit();
            this.tab_people.ResumeLayout(false);
            this.tab_people.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_spect_peopletab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_part_peopletab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_host_peopletab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl_main;
        private System.Windows.Forms.TabPage tab_create;
        private System.Windows.Forms.TabPage tab_find;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_createtab_1;
        private System.Windows.Forms.Label lbl_createtab_2;
        private System.Windows.Forms.Label lbl_createtab_5;
        private System.Windows.Forms.Label lbl_createtab_3;
        private System.Windows.Forms.Label lbl_createtab_4;
        private System.Windows.Forms.Button btn_create_createtab;
        private System.Windows.Forms.TabPage tab_account;
        private System.Windows.Forms.TabPage tab_history;
        private System.Windows.Forms.TabPage tab_people;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_createtab;
        private System.Windows.Forms.Label lbl_createtab_header;
        private System.Windows.Forms.DateTimePicker dateTime_endtime;
        private System.Windows.Forms.DateTimePicker dateTime_starttime;
        private System.Windows.Forms.ComboBox cmb_gameselect;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.DateTimePicker dateTime_date;
        private System.Windows.Forms.Button btn_joinSpectator;
        private System.Windows.Forms.Button btn_joinParticipant;
        private System.Windows.Forms.DataGridView dataGrid_findtab;
        private System.Windows.Forms.Label lbl_findtab_header;
        private System.Windows.Forms.Label lbl_accounttab_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_address_accounttab;
        private System.Windows.Forms.TextBox txt_gender_accounttab;
        private System.Windows.Forms.TextBox txt_age_accounttab;
        private System.Windows.Forms.TextBox txt_phone_accounttab;
        private System.Windows.Forms.TextBox txt_email_accounttab;
        private System.Windows.Forms.TextBox txt_handle_accounttab;
        private System.Windows.Forms.Button btn_edit_phone;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_handle;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_edit_name;
        private System.Windows.Forms.Button btn_edit_handle;
        private System.Windows.Forms.Button btn_edit_email;
        private System.Windows.Forms.Button btn_edit_age;
        private System.Windows.Forms.Button btn_edit_gender;
        private System.Windows.Forms.Button btn_edit_description;
        private System.Windows.Forms.Button btn_edit_address;
        private System.Windows.Forms.TextBox txt_name_accounttab;
        private System.Windows.Forms.RichTextBox rtxt_description_accounttab;
        private System.Windows.Forms.DataGridView dataGrid_historytab;
        private System.Windows.Forms.Label lbl_historytab_header;
        private System.Windows.Forms.Label lbl_peopletab_header;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_addnewgame;
        private dillonwallDataSet dillonwallDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private dillonwallDataSetTableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.BindingSource gamesBindingSource1;
        private System.Windows.Forms.Label lbl_statusmsg_createtab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_spectator_price;
        private System.Windows.Forms.TextBox txt_participant_price;
        private System.Windows.Forms.TextBox txt_host_price;
        private System.Windows.Forms.Label lbl_price_host;
        private System.Windows.Forms.Label lbl_part_price;
        private System.Windows.Forms.Label lbl_spec_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modify_host_info;
        private System.Windows.Forms.Label lbl_statusmsg_findtab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrid_spect_peopletab;
        private System.Windows.Forms.DataGridView dataGrid_part_peopletab;
        private System.Windows.Forms.DataGridView dataGrid_host_peopletab;
        private System.Windows.Forms.Button btn_selectGame;
    }
}

