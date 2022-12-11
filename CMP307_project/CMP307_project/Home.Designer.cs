
namespace CMP307_project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mssql2001921DataSet = new CMP307_project.mssql2001921DataSet();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTableAdapter = new CMP307_project.mssql2001921DataSetTableAdapters.AssetsTableAdapter();
            this.tableAdapterManager = new CMP307_project.mssql2001921DataSetTableAdapters.TableAdapterManager();
            this.assetsDGV_h = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_assetType = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_linked_software = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_pd = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_man = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assetsDGV_s = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assets2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2001921DataSet1 = new CMP307_project.mssql2001921DataSet1();
            this.assets2TableAdapter = new CMP307_project.mssql2001921DataSet1TableAdapters.Assets2TableAdapter();
            this.tableAdapterManager1 = new CMP307_project.mssql2001921DataSet1TableAdapters.TableAdapterManager();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_nist = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001921DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDGV_h)).BeginInit();
            this.tab_assetType.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_linked_software)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDGV_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001921DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mssql2001921DataSet
            // 
            this.mssql2001921DataSet.DataSetName = "mssql2001921DataSet";
            this.mssql2001921DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.mssql2001921DataSet;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetsTableAdapter = this.assetsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CMP307_project.mssql2001921DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assetsDGV_h
            // 
            this.assetsDGV_h.AllowUserToAddRows = false;
            this.assetsDGV_h.AllowUserToDeleteRows = false;
            this.assetsDGV_h.AllowUserToResizeColumns = false;
            this.assetsDGV_h.AllowUserToResizeRows = false;
            this.assetsDGV_h.AutoGenerateColumns = false;
            this.assetsDGV_h.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDGV_h.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.assetsDGV_h.DataSource = this.assetsBindingSource;
            this.assetsDGV_h.Location = new System.Drawing.Point(15, 29);
            this.assetsDGV_h.MultiSelect = false;
            this.assetsDGV_h.Name = "assetsDGV_h";
            this.assetsDGV_h.ReadOnly = true;
            this.assetsDGV_h.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assetsDGV_h.ShowEditingIcon = false;
            this.assetsDGV_h.Size = new System.Drawing.Size(844, 193);
            this.assetsDGV_h.TabIndex = 1;
            this.assetsDGV_h.SelectionChanged += new System.EventHandler(this.assetsDGV_h_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "manufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "manufacturer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn5.HeaderText = "type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn6.HeaderText = "ip";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "purchaseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "purchaseDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn8.HeaderText = "notes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tab_assetType
            // 
            this.tab_assetType.Controls.Add(this.tabPage1);
            this.tab_assetType.Controls.Add(this.tabPage2);
            this.tab_assetType.Location = new System.Drawing.Point(12, 12);
            this.tab_assetType.Name = "tab_assetType";
            this.tab_assetType.SelectedIndex = 0;
            this.tab_assetType.Size = new System.Drawing.Size(881, 410);
            this.tab_assetType.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_linked_software);
            this.tabPage1.Controls.Add(this.assetsDGV_h);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hardware";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Software Assets Installed";
            // 
            // dgv_linked_software
            // 
            this.dgv_linked_software.AllowUserToAddRows = false;
            this.dgv_linked_software.AllowUserToDeleteRows = false;
            this.dgv_linked_software.AllowUserToOrderColumns = true;
            this.dgv_linked_software.AllowUserToResizeColumns = false;
            this.dgv_linked_software.AllowUserToResizeRows = false;
            this.dgv_linked_software.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_linked_software.Enabled = false;
            this.dgv_linked_software.Location = new System.Drawing.Point(15, 274);
            this.dgv_linked_software.MultiSelect = false;
            this.dgv_linked_software.Name = "dgv_linked_software";
            this.dgv_linked_software.ReadOnly = true;
            this.dgv_linked_software.Size = new System.Drawing.Size(844, 95);
            this.dgv_linked_software.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hardware Assets";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_notes);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.lbl_pd);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.lbl_ip);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.lbl_type);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lbl_man);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbl_model);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbl_name);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.assetsDGV_s);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Software";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(617, 196);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(0, 13);
            this.lbl_notes.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(573, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Notes:";
            // 
            // lbl_pd
            // 
            this.lbl_pd.AutoSize = true;
            this.lbl_pd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pd.Location = new System.Drawing.Point(658, 173);
            this.lbl_pd.Name = "lbl_pd";
            this.lbl_pd.Size = new System.Drawing.Size(0, 13);
            this.lbl_pd.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(573, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Purchase date:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip.Location = new System.Drawing.Point(640, 150);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(0, 13);
            this.lbl_ip.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(573, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "IP Address:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(617, 127);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(0, 13);
            this.lbl_type.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(573, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Type:";
            // 
            // lbl_man
            // 
            this.lbl_man.AutoSize = true;
            this.lbl_man.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_man.Location = new System.Drawing.Point(652, 103);
            this.lbl_man.Name = "lbl_man";
            this.lbl_man.Size = new System.Drawing.Size(0, 13);
            this.lbl_man.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(573, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Manufacturer:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(618, 78);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(0, 13);
            this.lbl_model.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Model:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(617, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hardware Origin info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Software Assets";
            // 
            // assetsDGV_s
            // 
            this.assetsDGV_s.AllowUserToDeleteRows = false;
            this.assetsDGV_s.AllowUserToResizeColumns = false;
            this.assetsDGV_s.AllowUserToResizeRows = false;
            this.assetsDGV_s.AutoGenerateColumns = false;
            this.assetsDGV_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDGV_s.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.assetsDGV_s.DataSource = this.assets2BindingSource;
            this.assetsDGV_s.Location = new System.Drawing.Point(15, 29);
            this.assetsDGV_s.Name = "assetsDGV_s";
            this.assetsDGV_s.ReadOnly = true;
            this.assetsDGV_s.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assetsDGV_s.Size = new System.Drawing.Size(543, 287);
            this.assetsDGV_s.TabIndex = 0;
            this.assetsDGV_s.SelectionChanged += new System.EventHandler(this.assetsDGV_s_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn10.HeaderText = "name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "version";
            this.dataGridViewTextBoxColumn11.HeaderText = "version";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "manufacturer";
            this.dataGridViewTextBoxColumn12.HeaderText = "manufacturer";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "hardware_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "hardware_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // assets2BindingSource
            // 
            this.assets2BindingSource.DataMember = "Assets2";
            this.assets2BindingSource.DataSource = this.mssql2001921DataSet1;
            // 
            // mssql2001921DataSet1
            // 
            this.mssql2001921DataSet1.DataSetName = "mssql2001921DataSet1";
            this.mssql2001921DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assets2TableAdapter
            // 
            this.assets2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.Assets2TableAdapter = this.assets2TableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = CMP307_project.mssql2001921DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 428);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 37);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete Asset";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 428);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 38);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add Asset";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(150, 428);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(132, 37);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit Asset";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_nist
            // 
            this.btn_nist.Location = new System.Drawing.Point(426, 428);
            this.btn_nist.Name = "btn_nist";
            this.btn_nist.Size = new System.Drawing.Size(132, 37);
            this.btn_nist.TabIndex = 11;
            this.btn_nist.Text = "Check for Vulnerabilities";
            this.btn_nist.UseVisualStyleBackColor = true;
            this.btn_nist.Click += new System.EventHandler(this.btn_nist_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(757, 429);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 37);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 477);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_nist);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tab_assetType);
            this.Name = "Home";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001921DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDGV_h)).EndInit();
            this.tab_assetType.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_linked_software)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDGV_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2001921DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mssql2001921DataSet mssql2001921DataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2001921DataSetTableAdapters.AssetsTableAdapter assetsTableAdapter;
        private mssql2001921DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView assetsDGV_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabControl tab_assetType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private mssql2001921DataSet1 mssql2001921DataSet1;
        private System.Windows.Forms.BindingSource assets2BindingSource;
        private mssql2001921DataSet1TableAdapters.Assets2TableAdapter assets2TableAdapter;
        private mssql2001921DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView assetsDGV_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgv_linked_software;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_pd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_man;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_nist;
        private System.Windows.Forms.Button btn_exit;
    }
}

