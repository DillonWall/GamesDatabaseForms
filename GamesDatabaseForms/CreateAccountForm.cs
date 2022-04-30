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
    public partial class CreateAccountForm : Form
    {
        frm_main main;

        public CreateAccountForm(frm_main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btn_create_account_Click(object sender, EventArgs e)
        {
            if (txt_gender_accountform.Text.Length > 1)
                lbl_statusmsg.Text = "Gender must only be 1 character (M/F)";
            else if (txt_name_accountform.Text.Length == 0)
                lbl_statusmsg.Text = "You must include a name";
            else if (txt_handle_accountform.Text.Length == 0)
                lbl_statusmsg.Text = "You must include a display name";
            else if (txt_email_accountform.Text.Length == 0)
                lbl_statusmsg.Text = "You must include a email";
            else if (txt_phone_accountform.Text.Length == 0)
                lbl_statusmsg.Text = "You must include a phone number";
            else
            {
                try
                {
                    ///Get next profile id
                    string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
                    string query = "SELECT MAX(profile_id) FROM dillonwall.profiles";

                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();

                    int largestProfId = (int)cmd.ExecuteScalar();
                    //int largestProfId = 0;

                    con.Close();

                    ///Insert data into table
                    query = "INSERT INTO dillonwall.profiles(profile_id, real_name, handle, email, phone_number, age, gender, profile_description, street_address) VALUES("
                        + (largestProfId + 1) + ", "
                        + ("'" + txt_name_accountform.Text + "'") + ", "
                        + ("'" + txt_handle_accountform.Text + "'") + ", "
                        + ("'" + txt_email_accountform.Text + "'") + ", "
                        + ("'" + txt_phone_accountform.Text + "'") + ", "
                        + (txt_age_accountform.Text.Length == 0 ? "NULL" : txt_age_accountform.Text) + ", "
                        + (txt_gender_accountform.Text.Length == 0 ? "NULL" : ("'" + txt_gender_accountform.Text + "'")) + ", "
                        + (rtxt_description_accountform.Text.Length == 0 ? "NULL" : ("'" + rtxt_description_accountform.Text + "'")) + ", "
                        + (txt_address_accountform.Text.Length == 0 ? "NULL" : ("'" + txt_address_accountform.Text + "'")) + ");";

                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    main.UpdateUser(txt_handle_accountform.Text);

                    con.Close();

                    this.Close();
                }
                catch (Exception except)
                {
                    Console.WriteLine(except.Message);
                }
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
