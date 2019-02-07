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
        public FormNuevaReserva()
        {
            InitializeComponent();
            String [] aux = miConexion.getHabitaciones2LaVenganza();
            this.comboBoxHabitaciones.Items.AddRange(aux);
        }

        private void button1_Click(object sender,EventArgs e)
        {

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
