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
    public partial class Update_form_s : Form
    {
        public string assetId;

        public Update_form_s()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Setup Connection
            string connString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                Console.WriteLine("Connection successfully established.\n");

                // create query string
                string query = "UPDATE dbo.Assets2 SET name = @name, version = @ver, manufacturer = @man, hardware_id = @hid WHERE id = @id";

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(query);

                // link the command to the open connection created earlier
                command.Connection = conn;

                // set command parameters
                command.Parameters.AddWithValue("@name", txt_name.Text);
                command.Parameters.AddWithValue("@ver", txt_version.Text);
                command.Parameters.AddWithValue("@man", txt_man.Text);
                command.Parameters.AddWithValue("@hid", txt_hid.Text);   
                command.Parameters.AddWithValue("@id", assetId);

                // Execute the non query
                int i = command.ExecuteNonQuery();

                Console.WriteLine("SUCCESS! " + i + " Asset updated");

                // Close connection             
                conn.Close();

                // close window
                Close();
            }
            catch (Exception _e)
            {
                Console.WriteLine(_e.Message);
            }
        }
    }
}
