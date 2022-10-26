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


namespace CMP307_project
{
    public partial class Add_form : Form
    {
        public Add_form()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Setup Connection
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2001921; User ID = mssql2001921; Password = Ufk77DqHUA";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                Console.WriteLine("Connection successfully established.\n");

                string query = "INSERT INTO dbo.Assets (name, model, manufacturer, type, ip, purchaseDate, notes) VALUES ('"
                                + txt_name.Text + "', '" + txt_model.Text + "', '" + txt_man.Text + "', '" + txt_type.Text + "', '" 
                                + txt_ip.Text + "', '" + txt_pd.Text + "', '" + txt_notes.Text + "');";

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(query);

                // link the command to the open connection created earlier
                command.Connection = conn;

                // Execute the non query
                int i = command.ExecuteNonQuery();

                Console.WriteLine("SUCCESS! " + i + " Asset added");

                //Close connection             
                conn.Close();

                Close();
            }
            catch (Exception _e)
            {
                Console.WriteLine(_e.Message);
            }

        }
    }
}
