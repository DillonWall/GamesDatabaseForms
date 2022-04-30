using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GamesDatabaseForms
{
    public partial class frm_main : Form
    {
        private string current_user;
        private int current_event_id;

        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(this);
            form.Show();
        }

        public void UpdateUser(string username)
        {
            lbl_username.Text = "Logged in as " + username;
            current_user = username;

            UpdateHistory();
            UpdateAccountTab();
        }

        private void UpdateAccountTab()
        {
            ///Get profile id
            string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
            string query = "SELECT TOP (1) profile_id FROM dillonwall.profiles WHERE handle = '" + current_user + "'";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int profileId = (int)cmd.ExecuteScalar();
            con.Close();

            //Populate
            query = "SELECT real_name, handle, email, phone_number, age, gender, profile_description, street_address FROM profiles WHERE profile_id = " + profileId;
            con = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            txt_name_accounttab.Text = dt.Rows[0][0].ToString();
            txt_handle_accounttab.Text = dt.Rows[0][1].ToString();
            txt_email_accounttab.Text = dt.Rows[0][2].ToString();
            txt_phone_accounttab.Text = dt.Rows[0][3].ToString();
            txt_age_accounttab.Text = dt.Rows[0][4].ToString();
            txt_gender_accounttab.Text = dt.Rows[0][5].ToString();
            rtxt_description_accounttab.Text = dt.Rows[0][6].ToString();
            txt_address_accounttab.Text = dt.Rows[0][7].ToString();

            con.Close();
        }

        private void UpdateHistory()
        {
            ///Get profile id
            string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
            string query = "SELECT TOP (1) profile_id FROM dillonwall.profiles WHERE handle = '" + current_user + "'";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            int profileId = (int)cmd.ExecuteScalar();

            con.Close();

            query = "SELECT g.game_title, g.game_type, event_location, event_date, event_start_time, event_end_time, price_host, price_participant, price_spectator, p.handle AS host_handle FROM game_events AS e LEFT JOIN games AS g ON e.game_id = g.game_id LEFT JOIN game_event_attendees AS a ON e.event_id = a.event_id LEFT JOIN hosts AS h ON e.host_id = h.hosts_id LEFT JOIN profiles AS p ON p.profile_id = h.profile_id WHERE event_date < getdate() AND a.profile_id = " + profileId;
            con = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_historytab.DataSource = dt;
            con.Close();
        }

        public void UpdateGameSelection(int eventId)
        {
            current_event_id = eventId;

            //Update people tab hosts
            string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
            string query = "SELECT * FROM game_event_attendees AS a LEFT JOIN profiles AS p ON p.profile_id = a.profile_id WHERE a.event_id = " + current_event_id + " AND attendee_role_id = 1";
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_host_peopletab.DataSource = dt;
            con.Close();

            //Update people tab participants
            query = "SELECT * FROM game_event_attendees AS a LEFT JOIN profiles AS p ON p.profile_id = a.profile_id WHERE a.event_id = " + current_event_id + " AND attendee_role_id = 2";
            con = new SqlConnection(str);
            adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            sqlBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_part_peopletab.DataSource = dt;
            con.Close();

            //Update people tab spectators
            query = "SELECT * FROM game_event_attendees AS a LEFT JOIN profiles AS p ON p.profile_id = a.profile_id WHERE a.event_id = " + current_event_id + " AND attendee_role_id = 3";
            con = new SqlConnection(str);
            adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            sqlBuilder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_spect_peopletab.DataSource = dt;
            con.Close();
        }

        private void btn_addnewgame_Click(object sender, EventArgs e)
        {
            AddGameForm form = new AddGameForm(this);
            form.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            RefreshGames();

            RefreshFind();
        }

        private void RefreshFind()
        {
            ///Find tab data grid
            string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
            string query = "SELECT e.event_id, g.game_title, g.game_type, event_location, event_date, event_start_time, event_end_time, price_host, price_participant, price_spectator FROM game_events AS e LEFT JOIN games AS g ON e.game_id = g.game_id WHERE event_date >= getdate()";
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_findtab.DataSource = dt;
            con.Close();
        }

        internal void RefreshGames()
        {
            this.gamesTableAdapter.Fill(this.dillonwallDataSet.games);
        }

        private void btn_create_createtab_Click(object sender, EventArgs e)
        {
            if (current_user == null)
                lbl_statusmsg_createtab.Text = "You must login first";
            else if (cmb_gameselect.Text.Length == 0)
                lbl_statusmsg_createtab.Text = "You must have a game selected";
            else if (txt_location.Text.Length == 0)
                lbl_statusmsg_createtab.Text = "You must include a location";
            else if (dateTime_starttime.Value >= dateTime_endtime.Value)
                lbl_statusmsg_createtab.Text = "End time must be after start time";
            else
            {
                try
                {
                    if (txt_host_price.Text.Length == 0) 
                        txt_host_price.Text = "0.00";
                    if (txt_participant_price.Text.Length == 0)
                        txt_participant_price.Text = "0.00";
                    if (txt_spectator_price.Text.Length == 0)
                        txt_spectator_price.Text = "0.00";

                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
                    
                    ///Get profile id
                    string query = "SELECT TOP (1) profile_id FROM dillonwall.profiles WHERE handle = '" + current_user + "'";

                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int profileId = (int)cmd.ExecuteScalar();

                    con.Close();

                    ///Get Host id
                    query = "SELECT TOP (1) hosts_id FROM dillonwall.hosts WHERE profile_id = " + profileId;

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    int hostId = -1;
                    try
                    {
                        hostId = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception)
                    {
                        lbl_statusmsg_createtab.Text = "You must setup your host information first";
                        return;
                    }

                    con.Close();

                    ///Get next event id
                    query = "SELECT MAX(event_id) FROM dillonwall.game_events";

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    int largestEventId = (int)cmd.ExecuteScalar();
                    //int largestEventId = 0;

                    con.Close();

                    ///Get game id
                    query = "SELECT TOP (1) game_id FROM dillonwall.games WHERE game_title = '" + cmb_gameselect.Text + "'";

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    int gameId = (int)cmd.ExecuteScalar();

                    con.Close();

                    string test = dateTime_date.Value.ToShortDateString();
                    string test2 = dateTime_starttime.Value.ToShortTimeString();

                    ///Insert host into attendees
                    query = "INSERT INTO dillonwall.game_event_attendees(event_id, profile_id, attendee_role_id) VALUES("
                        + (largestEventId + 1) + ", "
                        + (profileId) + ", "
                        + (1) + ");"; // 1 is host role

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    con.Close();

                    ///Insert data into table
                    query = "INSERT INTO dillonwall.game_events(event_id, game_id, host_id, event_location, event_date, event_start_time, event_end_time, price_host, price_participant, price_spectator) VALUES("
                        + (largestEventId + 1) + ", "
                        + (gameId) + ", "
                        + (hostId) + ", "
                        + ("'" + txt_location.Text + "'") + ", "
                        + ("'" + dateTime_date.Value.ToShortDateString() + "'") + ", "
                        + ("'" + dateTime_starttime.Value.ToShortTimeString() + "'") + ", "
                        + ("'" + dateTime_endtime.Value.ToShortTimeString() + "'") + ", "
                        + (txt_host_price.Text) + ", "
                        + (txt_participant_price.Text) + ", "
                        + (txt_spectator_price.Text) + ");";

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    RefreshFind();
                    MessageBox.Show("Created new game event!");

                    con.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
        }

        private void btn_modify_host_info_Click(object sender, EventArgs e)
        {
            if (current_user != null)
            {
                HostInfoForm form = new HostInfoForm(current_user);
                form.Show();
            }
            else
                lbl_statusmsg_createtab.Text = "You must login first";
        }

        private void btn_joinParticipant_Click(object sender, EventArgs e)
        {
            if (current_user != null)
            {
                try
                {
                    int eventId = (int)dataGrid_findtab.SelectedCells[0].Value;
                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";

                    ///Get profile id
                    string query = "SELECT TOP (1) profile_id FROM dillonwall.profiles WHERE handle = '" + current_user + "'";

                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int profileId = (int)cmd.ExecuteScalar();

                    con.Close();

                    ///Insert data into table
                    query = "INSERT INTO dillonwall.game_event_attendees(event_id, profile_id, attendee_role_id) VALUES("
                        + (eventId) + ", "
                        + (profileId) + ", "
                        + (2) + ");"; //2 is participant

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Joined as participant!");

                    con.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
            else
                lbl_statusmsg_findtab.Text = "You must login first";
        }

        private void btn_joinSpectator_Click(object sender, EventArgs e)
        {
            if (current_user != null)
            {
                try
                {
                    int eventId = (int)dataGrid_findtab.SelectedCells[0].Value;
                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";

                    ///Get profile id
                    string query = "SELECT TOP (1) profile_id FROM dillonwall.profiles WHERE handle = '" + current_user + "'";

                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int profileId = (int)cmd.ExecuteScalar();

                    con.Close();

                    ///Insert data into table
                    query = "INSERT INTO dillonwall.game_event_attendees(event_id, profile_id, attendee_role_id) VALUES("
                        + (eventId) + ", "
                        + (profileId) + ", "
                        + (3) + ");"; //3 is spectator

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Joined as participant!");

                    con.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
            else
                lbl_statusmsg_findtab.Text = "You must login first";
        }

        private void btn_selectGame_Click(object sender, EventArgs e)
        {
            SelectGameForm form = new SelectGameForm(this);
            form.Show();
        }
    }
}


/*
    try
    {
        string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
        string query = "SELECT * FROM games";
        SqlConnection con = new SqlConnection(str);
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        //Do stuff
        con.Close();
    }
    catch (Exception except)
    { }
*/
