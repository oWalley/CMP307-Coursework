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
    public partial class Home : Form
    {
        // - Form Variables -
        Add_form_h add_form_hard;
        Update_form_h upd_form_hard;
        Add_form_s add_form_soft;
        Update_form_s upd_form_soft;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001921DataSet1.Assets2' table. You can move, or remove it, as needed.
            this.assets2TableAdapter.Fill(this.mssql2001921DataSet1.Assets2);
            // TODO: This line of code loads data into the 'mssql2001921DataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2001921DataSet.Assets);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add button pressed");

            if (tab_assetType.SelectedIndex == 0)
            {
                if (add_form_hard != null) add_form_hard.Close();
                add_form_hard = new Add_form_h();
                add_form_hard.Show();
            }
            else 
            {
                if (add_form_soft != null) add_form_soft.Close();
                add_form_soft = new Add_form_s();
                add_form_soft.Show();
            }
        }

        private void Home_Activated(object sender, EventArgs e)
        {       
            this.assetsTableAdapter.Fill(this.mssql2001921DataSet.Assets);
            this.assets2TableAdapter.Fill(this.mssql2001921DataSet1.Assets2);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Update button pressed");

            if (tab_assetType.SelectedIndex == 0)
            {
                if (upd_form_hard != null) upd_form_hard.Close();
                upd_form_hard = new Update_form_h();

                // Get asset id
                upd_form_hard.assetId = assetsDGV_h.SelectedCells[0].Value.ToString();

                // Fill textboxes with selected asset info
                upd_form_hard.txt_name.Text = assetsDGV_h.SelectedCells[1].Value.ToString();
                upd_form_hard.txt_model.Text = assetsDGV_h.SelectedCells[2].Value.ToString();
                upd_form_hard.txt_man.Text = assetsDGV_h.SelectedCells[3].Value.ToString();
                upd_form_hard.txt_type.Text = assetsDGV_h.SelectedCells[4].Value.ToString();
                upd_form_hard.txt_ip.Text = assetsDGV_h.SelectedCells[5].Value.ToString();
                upd_form_hard.txt_pd.Text = assetsDGV_h.SelectedCells[6].Value.ToString();
                upd_form_hard.txt_notes.Text = assetsDGV_h.SelectedCells[7].Value.ToString();

                upd_form_hard.Show();
            }
            else
            {
                if (upd_form_soft != null) upd_form_soft.Close();
                upd_form_soft = new Update_form_s();

                // Get asset id
                upd_form_soft.assetId = assetsDGV_s.SelectedCells[0].Value.ToString();         

                // Fill textboxes with selected asset info
                upd_form_soft.txt_name.Text = assetsDGV_s.SelectedCells[1].Value.ToString();
                upd_form_soft.txt_version.Text = assetsDGV_s.SelectedCells[2].Value.ToString();
                upd_form_soft.txt_man.Text = assetsDGV_s.SelectedCells[3].Value.ToString();
                upd_form_soft.txt_hid.Text = assetsDGV_s.SelectedCells[4].Value.ToString();

                upd_form_soft.Show();


                upd_form_soft.Show();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete button pressed");

            // Setup Connection
            string connString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            SqlConnection conn = new SqlConnection(connString);
            // create query string
            string query = "";

            if (tab_assetType.SelectedIndex == 0)
            {
                query = "DELETE FROM dbo.Assets WHERE id = " + assetsDGV_h.SelectedCells[0].Value.ToString();
            }
            else
            {
                query = "DELETE FROM dbo.Assets2 WHERE id = " + assetsDGV_s.SelectedCells[0].Value.ToString();
            }

            try
            {
                conn.Open();
                Console.WriteLine("Connection successfully established.\n");

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(query);

                // link the command to the open connection created earlier
                command.Connection = conn;

                // Execute the non query
                int i = command.ExecuteNonQuery();

                Console.WriteLine("SUCCESS! " + i + " Asset deleted");

                // Close connection             
                conn.Close();

                // Update DataGridView
                this.assetsTableAdapter.Fill(this.mssql2001921DataSet.Assets);
                this.assets2TableAdapter.Fill(this.mssql2001921DataSet1.Assets2);
            }
            catch (Exception _e)
            {
                Console.WriteLine(_e.Message);
            }

        }

    }
}
