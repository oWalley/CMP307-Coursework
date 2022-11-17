﻿using System;
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
        Update_form upd_form;

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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Update button pressed");

            if (upd_form != null) upd_form.Close();
            upd_form = new Update_form();

            // Get asset id
            upd_form.assetId = assetsDataGridView.SelectedCells[0].Value.ToString();

            // Fill textboxes with selected asset info
            upd_form.txt_name.Text = assetsDataGridView.SelectedCells[1].Value.ToString();
            upd_form.txt_model.Text = assetsDataGridView.SelectedCells[2].Value.ToString();
            upd_form.txt_man.Text = assetsDataGridView.SelectedCells[3].Value.ToString();
            upd_form.txt_type.Text = assetsDataGridView.SelectedCells[4].Value.ToString();
            upd_form.txt_ip.Text = assetsDataGridView.SelectedCells[5].Value.ToString();
            upd_form.txt_pd.Text = assetsDataGridView.SelectedCells[6].Value.ToString();
            upd_form.txt_notes.Text = assetsDataGridView.SelectedCells[7].Value.ToString();

            upd_form.Show();
        }
    }
}
