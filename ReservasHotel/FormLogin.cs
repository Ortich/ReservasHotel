using System;
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
        ConexionBBDD conexion = new ConexionBBDD();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender,EventArgs e)
        {
            //this.Hide();
            int aux;
            FormVentananPrincipal ventanaPrincipal = new FormVentananPrincipal();
            aux = conexion.login(textBoxusuarioLogin.Text, textBoxPassLogin.Text);
            //textBoxusuarioLogin.Text = aux.ToString();
            ventanaPrincipal.Show();
        }
    }
}
