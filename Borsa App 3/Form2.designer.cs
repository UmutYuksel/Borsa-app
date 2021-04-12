
namespace Borsa_App
{
    partial class admin_form
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
            this.button3 = new System.Windows.Forms.Button();
            this.uye_bilgi_b = new System.Windows.Forms.Button();
            this.admin_onay_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ana Ekrana Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uye_bilgi_b
            // 
            this.uye_bilgi_b.Location = new System.Drawing.Point(22, 45);
            this.uye_bilgi_b.Name = "uye_bilgi_b";
            this.uye_bilgi_b.Size = new System.Drawing.Size(102, 27);
            this.uye_bilgi_b.TabIndex = 1;
            this.uye_bilgi_b.Text = "Üye Görüntüle";
            this.uye_bilgi_b.UseVisualStyleBackColor = true;
            this.uye_bilgi_b.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // admin_onay_b
            // 
            this.admin_onay_b.Location = new System.Drawing.Point(22, 78);
            this.admin_onay_b.Name = "admin_onay_b";
            this.admin_onay_b.Size = new System.Drawing.Size(102, 27);
            this.admin_onay_b.TabIndex = 2;
            this.admin_onay_b.Text = "Onay Ver";
            this.admin_onay_b.UseVisualStyleBackColor = true;
            // 
            // admin_form
            // 
            this.BackgroundImage = global::Borsa_App_3.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(699, 318);
            this.Controls.Add(this.admin_onay_b);
            this.Controls.Add(this.uye_bilgi_b);
            this.Controls.Add(this.button3);
            this.Name = "admin_form";
            this.Text = "ADMİN PANEL";
            this.Load += new System.EventHandler(this.admin_form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button uye_bilgi_b;
        private System.Windows.Forms.Button admin_onay_b;
    }
}