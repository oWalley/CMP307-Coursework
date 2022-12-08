using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Configuration;


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
            string connString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                Console.WriteLine("Connection successfully established.\n");

                // create query string
                string query = "INSERT INTO dbo.Assets (name, model, manufacturer, type, ip, purchaseDate, notes) " +
                                "VALUES (@name, @model, @man, @type, @ip, @pd, @notes);";

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

                Console.WriteLine("SUCCESS! " + i + " Asset added");

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

        private void btn_getInfo_Click(object sender, EventArgs e)
        {

            // Retrieve System Name
            txt_name.Text = System.Environment.MachineName;


            // Reference to original code 
            // link: https://www.section.io/engineering-education/working-with-system-information-in-c-sharp-windows-form-application/

            ManagementClass mng = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection mngObj = mng.GetInstances();

            foreach (ManagementObject _mo in mngObj)
            {
                txt_model.Text = _mo.Properties["Model"].Value.ToString(); // Retrieve System Model
                txt_man.Text = _mo.Properties["Manufacturer"].Value.ToString(); // Retrieve System Manufacturer
                txt_type.Text = _mo.Properties["SystemType"].Value.ToString(); // Retrieve System Type
                break;
            }

            // Retrieve System IP
            // Reference to original code
            // link: https://learn.microsoft.com/en-us/dotnet/api/system.net.dns.gethostaddresses?view=net-7.0
            IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in addresses)
            {
                if(address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    txt_ip.Text = address.ToString();
                    break;
                }
            }

        }
    }
}
