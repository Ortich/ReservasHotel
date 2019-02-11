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
    public partial class FormNuevaReserva : Form
    {
        ConexionBBDD miConexion = new ConexionBBDD();
        FormVentananPrincipal ventana = null;
        public FormNuevaReserva(FormVentananPrincipal _ventana)
        {
            ventana = _ventana;
            InitializeComponent();
            String [] aux = miConexion.getHabitaciones2LaVenganza();
            this.comboBoxHabitaciones.Items.AddRange(aux);
        }
        private String fuckingZero(int date)
        {
            if(date < 10)
            {
                return "0" + date;
            }
            else
            {
                return date.ToString();
            }

        }
        private void button1_Click(object sender,EventArgs e)
        {
            String entrada = dateTimePickerFechaEntrada.Value.Year + "-" + fuckingZero(dateTimePickerFechaEntrada.Value.Month) + "-" + fuckingZero(dateTimePickerFechaEntrada.Value.Day);
            String salida = dateTimePickerFechaSalida.Value.Year + "-" + fuckingZero(dateTimePickerFechaSalida.Value.Month) + "-" + fuckingZero(dateTimePickerFechaSalida.Value.Day);
            Console.WriteLine(entrada + " " + salida);
            bool libre = false;
            if (Convert.ToInt32(textBoxNumeroPersonas.Text) <= Convert.ToInt32(labelCamasIndividuales.Text) + Convert.ToInt32(labelCamasMatrimonio.Text) + Convert.ToInt32(labelCamasSupletorias.Text) 
                && Convert.ToInt32(textBoxBCamasSupletorias.Text) <= Convert.ToInt32(labelCamasSupletorias.Text))
            {
                libre = miConexion.getDisponible(comboBoxHabitaciones.SelectedItem.ToString(), entrada, salida);
            }
            Console.WriteLine("Estado de la comprobación" + libre);
            if (libre)
            {
                miConexion.setNuevaReserva(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxEmail.Text, textBoxTelefono.Text, 
                    comboBoxHabitaciones.SelectedItem.ToString(), entrada, salida);
                ventana.actualizaDatosReservas();
                ventana.actualizaReservas();
                MessageBox.Show("Reserva añadida");
            }

        }

        private void comboBoxHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBoxHabitaciones.SelectedItem;
            Console.WriteLine(selectedItem.ToString());
            String[] data = miConexion.getCamas(selectedItem.ToString());
            labelCamasIndividuales.Text = data[0];
            labelCamasMatrimonio.Text = data[1];
            labelCamasSupletorias.Text = data[2];

        }
    }
}
