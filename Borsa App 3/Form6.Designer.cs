
namespace Borsa_App_3
{
    partial class Form6
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
            this.gridViewStokOnay = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridViewBakiyeOnay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokOnay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBakiyeOnay)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewStokOnay
            // 
            this.gridViewStokOnay.AllowUserToAddRows = false;
            this.gridViewStokOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStokOnay.Location = new System.Drawing.Point(3, 6);
            this.gridViewStokOnay.Name = "gridViewStokOnay";
            this.gridViewStokOnay.Size = new System.Drawing.Size(762, 425);
            this.gridViewStokOnay.TabIndex = 0;
            this.gridViewStokOnay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewStokOnay_CellValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 463);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridViewStokOnay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok Onayları";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridViewBakiyeOnay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Onayları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridViewBakiyeOnay
            // 
            this.gridViewBakiyeOnay.AllowUserToAddRows = false;
            this.gridViewBakiyeOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBakiyeOnay.Location = new System.Drawing.Point(3, 6);
            this.gridViewBakiyeOnay.Name = "gridViewBakiyeOnay";
            this.gridViewBakiyeOnay.Size = new System.Drawing.Size(762, 425);
            this.gridViewBakiyeOnay.TabIndex = 1;
            this.gridViewBakiyeOnay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBakiyeOnay_CellValueChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokOnay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBakiyeOnay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewStokOnay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridViewBakiyeOnay;
    }
}