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
    public partial class Update_form : Form
    {
        public string assetId;

        public Update_form()
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
                string query = "UPDATE dbo.Assets SET name = @name, model = @model, manufacturer = @man, type = @type, ip = @ip, purchaseDate = @pd, notes = @notes WHERE id = " + assetId;
                                
                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(query);

                // link the command to the open connection created earlier
                command.Connection = conn;

                // set command parameters
                command.Parameters.AddWithValue("@name", txt_name.Text);
                command.Parameters.AddWithValue("@model", txt_model.Text);
                command.Parameters.AddWithValue("@man", txt_man.Text);
                command.Parameters.AddWithValue("@type", txt_type.Text);
                command.Parameters.AddWithValue("@ip", txt_ip.Text);
                command.Parameters.AddWithValue("@pd", txt_pd.Text);
                command.Parameters.AddWithValue("@notes", txt_notes.Text);

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
