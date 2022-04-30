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
    public partial class HostInfoForm : Form
    {
        string username;

        public HostInfoForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_minpart.Text.Length == 0)
                txt_minpart.Text = "0";
            else if (txt_maxpart.Text.Length == 0)
                txt_maxpart.Text = "0";
            else if (txt_minspec.Text.Length == 0)
                txt_minspec.Text = "0";
            else if (txt_maxspec.Text.Length == 0)
                txt_maxspec.Text = "0";
            else
            {
                try
                {
                    ///Get profile id
                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
                    string query = "SELECT profile_id FROM dillonwall.profiles WHERE handle = '" + username + "'";
                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int profileId = (int)cmd.ExecuteScalar();

                    con.Close();

                    ///Check if profile id in host id
                    query = "SELECT COUNT(*) FROM dillonwall.hosts WHERE profile_id = " + profileId;
                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    int userCount = (int)cmd.ExecuteScalar();

                    con.Close();

                    if (userCount == 0)
                    {
                        ///Get largest host id
                        query = "SELECT MAX(hosts_id) FROM dillonwall.hosts";

                        con = new SqlConnection(str);
                        cmd = new SqlCommand(query, con);
                        con.Open();

                        int largestHostId = (int)cmd.ExecuteScalar();

                        con.Close();

                        ///Insert data into table
                        query = "INSERT INTO dillonwall.hosts(hosts_id, profile_id, min_participants, max_participants, min_spectators, max_spectators, is_food_available) VALUES("
                            + (largestHostId + 1) + ", "
                            + (profileId) + ", "
                            + (txt_minpart.Text) + ", "
                            + (txt_maxpart.Text) + ", "
                            + (txt_minspec.Text) + ", "
                            + (txt_maxspec.Text) + ", "
                            + (chk_food.Checked ? 1 : 0) + ");";

                        con = new SqlConnection(str);
                        cmd = new SqlCommand(query, con);
                        con.Open();

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    else
                    {
                        ///Update existing
                        query = "UPDATE hosts SET " +
                            "min_participants = '" + (txt_minpart.Text) + "'" +
                            ", max_participants = '" + (txt_maxpart.Text) + "'" +
                            ", min_spectators = '" + (txt_minspec.Text) + "'" +
                            ", max_spectators = '" + (txt_maxspec.Text)  + "'" +
                            ", is_food_available = " + (chk_food.Checked ? 1 : 0) +
                            " WHERE profile_id = " + (profileId) + ";";

                        con = new SqlConnection(str);
                        cmd = new SqlCommand(query, con);
                        con.Open();

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }

                    this.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
        }
    }
}
