
namespace Borsa_app2
{
    partial class uye_bilgi_form
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.Apanel_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1267, 560);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD SOYAD";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KULLANICI AD";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ŞİFRE";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELFON NO";
            this.columnHeader4.Width = 210;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TC NO";
            this.columnHeader5.Width = 156;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MAİL";
            this.columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ADRES";
            this.columnHeader7.Width = 218;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(624, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bilgileri Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apanel_b
            // 
            this.Apanel_b.Location = new System.Drawing.Point(642, 524);
            this.Apanel_b.Name = "Apanel_b";
            this.Apanel_b.Size = new System.Drawing.Size(613, 23);
            this.Apanel_b.TabIndex = 2;
            this.Apanel_b.Text = "Panele Dön";
            this.Apanel_b.UseVisualStyleBackColor = true;
            this.Apanel_b.Click += new System.EventHandler(this.Apanel_b_Click);
            // 
            // uye_bilgi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 560);
            this.Controls.Add(this.Apanel_b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "uye_bilgi_form";
            this.Text = "ÜYE BİLGİLERİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Apanel_b;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
    }
}