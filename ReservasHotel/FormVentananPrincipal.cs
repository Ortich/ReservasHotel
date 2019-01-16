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
        DataTable reservas = new DataTable();
        DataTable habitaciones = new DataTable();
        DataTable calendario = new DataTable();

        public FormVentananPrincipal()
        {
            InitializeComponent();

            reservas = miConexion.getReservas();
            habitaciones = miConexion.getHabitaciones();
           
            actualizaMes(30);
            actualizaHabitaciones(habitaciones);

            dataGridViewCalendarioReservas.DataSource = calendario;

        }

        protected void actualizaMes(int dias)
        {
            for(int i = 0; i<dias; i++)
            {
                calendario.Columns.Add((i+1).ToString());
            }
        }

        protected void actualizaHabitaciones(DataTable _habitaciones)
        {
            for(int i = 0; i < _habitaciones.Rows.Count; i++)
            {
                calendario.Rows.Add(habitaciones.Rows[i]["nHabitacion"].ToString());
            }
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
