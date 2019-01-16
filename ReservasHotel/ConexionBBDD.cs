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


        public DataTable geTitulos()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM album",conexion);
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

        public DataTable getTituloPorNombre(String nombre)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM album WHERE titulo='" + nombre + "';",conexion);
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

        public void actualizaAlbum(String titulo,String autor,String id)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("UPDATE album SET titulo='" + titulo + "', autor='" + autor + "' WHERE id='" + id + "'",conexion);
                consulta.ExecuteNonQuery();
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }

        public void annadeNuevoAlbum(String titulo,String autor)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta -------------------------------------------");
                MySqlCommand consulta = new MySqlCommand("INSERT INTO album (titulo, autor) VALUES('" + titulo + "', '" + autor + "');",conexion);
                consulta.ExecuteNonQuery();
                conexion.Close();
                Console.WriteLine("Conexion Cerrada -------------------------------------------");
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
