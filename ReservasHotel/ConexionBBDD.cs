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
    }
}
