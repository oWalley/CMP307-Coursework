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
using System.Management;

namespace CMP307_project
{
    public partial class Add_form_s : Form
    {
        public Add_form_s()
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
                string query = "INSERT INTO dbo.Assets2 (name, version, manufacturer, hardware_id) " +
                                "VALUES (@name, @ver, @man, @hid);";

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(query);

                // link the command to the open connection created earlier
                command.Connection = conn;

                // set command parameters
                command.Parameters.AddWithValue("@name", txt_name.Text);
                command.Parameters.AddWithValue("@ver", txt_version.Text);
                command.Parameters.AddWithValue("@man", txt_man.Text);
                command.Parameters.AddWithValue("@hid", txt_hid.Text);               

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
            ManagementClass mng = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection mngObj = mng.GetInstances();

            foreach (ManagementObject _mo in mngObj)
            {
                txt_name.Text = _mo.Properties["Caption"].Value.ToString();
                txt_version.Text = _mo.Properties["Version"].Value.ToString();
                txt_man.Text = _mo.Properties["Manufacturer"].Value.ToString();              
                break;
            }
        }
    }
}
