using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace ReservasHotel
{
    class ConexionBBDD
    {
        public MySqlConnection conexion;

        public ConexionBBDD()
        {
            try
            {
                conexion = new MySqlConnection("Server = 127.0.0.1; Database = hostal; Uid = root; Pwd =; Port = 3306");
                Console.WriteLine("Conexion Establecida -------------------------------------------");
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }


        public DataTable getReservas()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM reserva",conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                return usuarios;
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }

        public  DataTable getHabitaciones()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM habitaciones",conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable usuarios = new DataTable();
                usuarios.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                return usuarios;
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }

        public int login(String usuario, String pass)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT count(*) FROM usuario WHERE nombre='" + usuario + "'AND pass='" + pass + "';", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable aux = new DataTable();
                aux.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                return Convert.ToInt32(aux.Rows[0][0].ToString());
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }

        public String[] getHabitaciones2LaVenganza()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT nhabitacion FROM habitaciones", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable aux = new DataTable();
                aux.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                String[] habitaciones = new String[aux.Rows.Count];
                for (int i = 0; i < aux.Rows.Count; i++)
                {
                    habitaciones[i] = aux.Rows[i][0].ToString(); 
                }
                return habitaciones;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public String[] getCamas(String numeroHabitacion)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT nCamas, nCamasSupletoras,nCamasMatrimonio from habitaciones WHERE nHabitacion = " + numeroHabitacion + ";", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable aux = new DataTable();
                aux.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                String[] habitaciones = new String[aux.Rows[0].ItemArray.Length];
                for (int i = 0; i < aux.Rows[0].ItemArray.Length; i++)
                {
                    habitaciones[i] = aux.Rows[0][i].ToString();
                }
                return habitaciones;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public bool getDisponible(String numeroHabitacion, String fechaEntrada, String fechaSalida)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT fecha_entrada, fecha_salida FROM reserva WHERE nHabitacionS = '" + numeroHabitacion + "' " +
                    "AND fecha_entrada >='" + fechaEntrada + "' AND fecha_salida >='" + fechaEntrada + "' AND fecha_entrada <='" + fechaSalida + "' AND fecha_salida <='" + fechaSalida + "';", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable aux = new DataTable();
                aux.Load(resultado);
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                return aux.Rows.Count == 0;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public void setNuevaReserva(String dniCliente, String nombreCliente, String apellidoCliente, String emailCliente, String tlfnCliente, 
            String numeroHabitacion, String fechaEntrada, String fechaSalida)
        {
            try
            {
                //Hay que hacer una mierda para la idReserva
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE cliente_dni ='" + dniCliente + "';", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable aux = new DataTable();
                aux.Load(resultado);
                if(Convert.ToInt32(aux.Rows[0][0].ToString()) == 0)
                {
                    //el usuario no existe, se añade
                    consulta = new MySqlCommand("INSERT INTO `cliente` (`cliente_dni`, `cliente_nombre`, `cliente_apellido`, `cliente_email`, `cliente_tlfn`) VALUES " +
                        "('" + dniCliente + "', '" + nombreCliente + "', '" + apellidoCliente + "', '" + emailCliente + "', " + tlfnCliente + ");", conexion);
                    resultado = consulta.ExecuteReader();
                    
                }
                //añadir reserva
                conexion.Close();
                conexion.Open();
                consulta = new MySqlCommand("INSERT INTO `reserva` (`fecha_entrada`, `fecha_salida`, `dni_clienteS`, `nHabitacionS`) VALUES " +
                    "('" + fechaEntrada +"', '" + fechaSalida + "', '" + dniCliente + "', " + numeroHabitacion + ");", conexion);
                resultado = consulta.ExecuteReader();

                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
                
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
