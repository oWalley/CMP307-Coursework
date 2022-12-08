using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CMP307_project
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked) txt_password.PasswordChar = (char)0;
            else txt_password.PasswordChar = '*';
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";

            // Setup Connection
            string connString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            if (txt_username.Text == "" || txt_password.Text == "")// There is 1 or more blank field
            {
                lbl_error.Text = "Fill in all login fields";
            }
            else
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successfully established.\n");

                    // create query string
                    string query = "SELECT password FROM dbo.CMP307_user WHERE username = @username";

                    // initialise a command variable with this string
                    SqlCommand command = new SqlCommand(query);

                    // link the command to the open connection created earlier
                    command.Connection = conn;

                    // set command parameters
                    command.Parameters.AddWithValue("@username", txt_username.Text);

                    // Execute the query
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //if (txt_password.Text == dataReader.GetString(0))// credentials are valid
                            if(BCrypt.Net.BCrypt.Verify(txt_password.Text, dataReader.GetString(0)))
                            {
                                DialogResult = DialogResult.OK;
                            }
                            else// invalid password
                            {
                                lbl_error.Text = "Invalid login credendtials used";
                            }
                        }
                    }
                    else // invalid username
                    {     
                        lbl_error.Text = "Invalid login credendtials used";                 
                    }

                    // Close connection             
                    conn.Close();

                }
                catch (Exception _e)
                {
                    Console.WriteLine(_e.Message);
                }
            }

             
        }
    }
}
