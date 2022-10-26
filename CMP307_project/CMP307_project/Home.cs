using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307_project
{
    public partial class Home : Form
    {
        // - Form Variables -
        Add_form add_form;

        public Home()
        {
            InitializeComponent();
        }

        private void assetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mssql2001921DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2001921DataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2001921DataSet.Assets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add button pressed");

            if(add_form != null) add_form.Close();
            add_form = new Add_form();
            add_form.Show();
        }

        private void Home_Activated(object sender, EventArgs e)
        {       
            this.assetsTableAdapter.Fill(this.mssql2001921DataSet.Assets);
        }

    }
}
