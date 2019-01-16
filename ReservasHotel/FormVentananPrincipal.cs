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
    public partial class FormVentananPrincipal : Form
    {
        ConexionBBDD miConexion = new ConexionBBDD();
        public FormVentananPrincipal()
        {
            InitializeComponent();

        }
        //Metodo para cerrar la aplicacion entera cuando se cierra este form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button3_Click(object sender,EventArgs e)
        {
            FormNuevaReserva nuevaReserva = new FormNuevaReserva();
            nuevaReserva.Show();
        }

        private void button4_Click(object sender,EventArgs e)
        {
            FormBuscarReserva buscarReserva = new FormBuscarReserva();
            buscarReserva.Show();
        }
    }
}
