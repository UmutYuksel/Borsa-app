﻿using Borsa_app2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Borsa_App
{
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }
        
private void admin_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_login ana_ekran = new frm_login();
            ana_ekran.Show(); ;
            this.Hide();
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            uye_bilgi_form uye_bilgileri= new uye_bilgi_form();
            uye_bilgileri.Show();
            this.Hide();


            
        }
    }
}