
namespace CMP307_project
{
    partial class NIST_form
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
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lv_vulnerabilities = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vulnerabilities found in the last 3 months:";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(308, 12);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(18, 20);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "0";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(137, 295);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(105, 37);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lv_vulnerabilities
            // 
            this.lv_vulnerabilities.GridLines = true;
            this.lv_vulnerabilities.HideSelection = false;
            this.lv_vulnerabilities.Location = new System.Drawing.Point(17, 45);
            this.lv_vulnerabilities.MultiSelect = false;
            this.lv_vulnerabilities.Name = "lv_vulnerabilities";
            this.lv_vulnerabilities.Size = new System.Drawing.Size(370, 235);
            this.lv_vulnerabilities.TabIndex = 0;
            this.lv_vulnerabilities.UseCompatibleStateImageBehavior = false;
            this.lv_vulnerabilities.View = System.Windows.Forms.View.SmallIcon;
            // 
            // NIST_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 346);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_vulnerabilities);
            this.Name = "NIST_form";
            this.Text = "NIST_form";
            this.Load += new System.EventHandler(this.NIST_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ListView lv_vulnerabilities;
    }
}