using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesDatabaseForms
{
    public partial class SelectGameForm : Form
    {
        frm_main main;

        public SelectGameForm(frm_main frm_main)
        {
            InitializeComponent();

            main = frm_main;
        }

        private void SelectGameForm_Load(object sender, EventArgs e)
        {
            string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
            string query = "SELECT e.event_id, g.game_title, g.game_type, event_location, event_date, event_start_time, event_end_time, price_host, price_participant, price_spectator FROM game_events AS e LEFT JOIN games AS g ON e.game_id = g.game_id";
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //listens for extra updates to table
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_gameEvents.DataSource = dt;
            con.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            int eventId = (int)dataGrid_gameEvents.SelectedCells[0].Value;

            //POPULATE main form with the game
            main.UpdateGameSelection(eventId);

            this.Close();
        }
    }
}
