﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasHotel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender,EventArgs e)
        {
            this.Hide();
            FormVentananPrincipal ventanaPrincipal = new FormVentananPrincipal();
            ventanaPrincipal.Show();
        }
    }
}
