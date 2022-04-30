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
    public partial class AddGameForm : Form
    {
        frm_main main;

        public AddGameForm(frm_main frm_main)
        {
            InitializeComponent();
            main = frm_main;
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_title.Text.Length == 0)
                    lbl_statusmsg.Text = "You must include a title";
                else if (txt_type.Text.Length == 0)
                    lbl_statusmsg.Text = "You must include a type";
                else
                {
                    ///Get next game id
                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
                    string query = "SELECT MAX(game_id) FROM dillonwall.games";

                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int largestGameId = (int)cmd.ExecuteScalar();
                    //int largestGameId = 0;

                    con.Close();

                    ///Insert data into table
                    query = "INSERT INTO dillonwall.games(game_id, game_title, game_type) VALUES("
                        + (largestGameId + 1) + ", "
                        + ("'" + txt_title.Text + "'") + ", "
                        + ("'" + txt_type.Text + "'") + ");";

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    main.RefreshGames();

                    con.Close();

                    this.Close();
                }
            }
            catch(Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }
    }
}
