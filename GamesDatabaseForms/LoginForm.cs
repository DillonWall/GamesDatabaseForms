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
    public partial class LoginForm : Form
    {
        frm_main main;

        public LoginForm(frm_main frm_main)
        {
            InitializeComponent();
            main = frm_main;
        }

        private void btn_login_loginform_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;

            try
            {
                string str = "server=aura.cset.oit.edu, 5433;database=dillonwall;UID=dillonwall;password=dillonwall";
                string query = "SELECT COUNT(*) FROM dillonwall.profiles WHERE handle = '" + username + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    main.UpdateUser(username);
                    this.Close();
                }
                else
                    lbl_statusmsg.Text = "User " + username + " does not exist... Try creating a new account.";

                con.Close();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }

        private void llbl_createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm form = new CreateAccountForm(main);
            form.Show();
            this.Close();
        }
    }
}
