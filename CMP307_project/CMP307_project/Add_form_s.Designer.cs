
namespace CMP307_project
{
    partial class Add_form_s
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_man = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_getInfo = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Software Asset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hardware Asset ID (optional):";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(12, 245);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(364, 20);
            this.txt_type.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Manufacturer:";
            // 
            // txt_man
            // 
            this.txt_man.Location = new System.Drawing.Point(12, 187);
            this.txt_man.Name = "txt_man";
            this.txt_man.Size = new System.Drawing.Size(364, 20);
            this.txt_man.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Version:";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(12, 126);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(364, 20);
            this.txt_model.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 68);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(364, 20);
            this.txt_name.TabIndex = 9;
            // 
            // btn_getInfo
            // 
            this.btn_getInfo.Location = new System.Drawing.Point(12, 286);
            this.btn_getInfo.Name = "btn_getInfo";
            this.btn_getInfo.Size = new System.Drawing.Size(364, 37);
            this.btn_getInfo.TabIndex = 20;
            this.btn_getInfo.Text = "Get Software Info";
            this.btn_getInfo.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(202, 339);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(173, 37);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add Asset";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(11, 339);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(173, 37);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Add_form_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 389);
            this.Controls.Add(this.btn_getInfo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_man);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Add_form_s";
            this.Text = "Add_form_s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_man;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_getInfo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}