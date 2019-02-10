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
        DateTime fechaActual = DateTime.Today;

        int anno;
        int mes;
        public FormVentananPrincipal()
        {
            InitializeComponent();

            reservas = miConexion.getReservas();
            habitaciones = miConexion.getHabitaciones();

            anno = fechaActual.Year;
            mes = fechaActual.Month;

            calendario.Columns.Add("Habitaciones",typeof(int));//Carlos idea
            actualizaDias(System.DateTime.DaysInMonth(anno,mes));
            actualizaHabitaciones(habitaciones);
            labelMesAnno.Text = nombreMes(mes) + " - " + anno;

            dataGridViewCalendarioReservas.DataSource = calendario;
            limpiaReservas();
        }

        public void actualizaReservas()
        {
            try
            {
                for(int i = 0; i < reservas.Rows.Count; i++)
                {
                    String nHab = Convert.ToString((int)reservas.Rows[i]["nHabitacionS"]);
                    int aux = 0;
                    Boolean encontrado = false;
                    for(int j = 0; j < calendario.Rows.Count && !encontrado; j++)
                    {
                        if(calendario.Rows[j][0].ToString() == nHab)
                        {
                            aux = j;
                            encontrado = true;
                        }
                    }
                    DateTime fechaEntrada = (DateTime)reservas.Rows[i]["fecha_entrada"];
                    DateTime fechaSalida = (DateTime)reservas.Rows[i]["fecha_salida"];
                    if(fechaEntrada.Month == mes && fechaEntrada.Year == anno)
                    {
                        if(fechaSalida.Month == mes)
                        {
                            for(int k = fechaEntrada.Day; k <= fechaSalida.Day; k++)
                            {
                                calendario.Rows[aux][k] = "X";
                                dataGridViewCalendarioReservas.Rows[aux].Cells[k].Style.BackColor = Color.Red;

                            }
                        }
                        else
                        {
                            for(int k = fechaEntrada.Day; k <= System.DateTime.DaysInMonth(fechaEntrada.Year,fechaEntrada.Month); k++)
                            {
                                calendario.Rows[aux][k] = "X";
                                dataGridViewCalendarioReservas.Rows[aux].Cells[k].Style.BackColor = Color.Red;

                            }
                        }
                    }
                    else if(fechaSalida.Month == mes && fechaSalida.Year == anno)
                    {
                        for(int k = 1; k <= fechaSalida.Day; k++)
                        {
                            calendario.Rows[aux][k] = "X";
                            dataGridViewCalendarioReservas.Rows[aux].Cells[k].Style.BackColor = Color.Red;

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se han podido cargar las reservas");
            }
        }

        protected void limpiaReservas()
        {
            for(int i = 0; i < calendario.Rows.Count; i++)
            {
                for(int j = 1; j < calendario.Columns.Count; j++)
                {
                    calendario.Rows[i][j] = "";
                    dataGridViewCalendarioReservas.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        protected String nombreMes(int _mes)
        {
            switch(_mes)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "Febrero";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                case 7:
                    return "Julio";
                    break;
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Septiembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;
                default:
                    return "Otro mes";
                    break;
            }
        }

        protected void actualizaDias(int dias)
        {
            for(int i = 0; i < dias; i++)
            {
                if(calendario.Columns.Count - 1 < dias)
                {
                    calendario.Columns.Add((calendario.Columns.Count).ToString());
                }
                else if(calendario.Columns.Count - 1 > dias)
                {
                    calendario.Columns.RemoveAt(calendario.Columns.Count - 1);
                }
            }
            labelMesAnno.Text = nombreMes(mes) + " - " + anno;
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

        private void button1_Click(object sender,EventArgs e)
        {

        }

        private void buttonAnteriorMes_Click(object sender,EventArgs e)
        {
            if(mes > 1)
            {
                mes = mes - 1;
            }
            else
            {
                mes = 12;
                anno = anno - 1;
            }
            actualizaDias(System.DateTime.DaysInMonth(anno,mes));
            limpiaReservas();
            actualizaReservas();
        }

        private void buttonSiguienteMes_Click(object sender,EventArgs e)
        {
            if(mes < 12)
            {
                mes = mes + 1;
            }
            else
            {
                mes = 1;
                anno = anno + 1;
            }
            actualizaDias(System.DateTime.DaysInMonth(anno,mes));
            limpiaReservas();
            actualizaReservas();
        }

        private void carga(object sender,EventArgs e)
        {
            actualizaReservas();
        }
    }
}
