using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad_V;
namespace CapaDatos_V
{
    public class D_visita
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void insertarVisita ( E_visita visita) 
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARVISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", visita.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visita.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visita.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", visita.Hora_entrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", visita.Hora_salida);
            cmd.Parameters.AddWithValue("@MOTIVO_VISITA", visita.Motivo_visita);
            cmd.Parameters.AddWithValue("@AULA", visita.Aula);

            cmd.ExecuteNonQuery();
            conexion.Close();
            
        }

        public void editarVisita(E_visita visita)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARVISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_PERSONA", visita.IDpersona);
            cmd.Parameters.AddWithValue("@NOMBRE", visita.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visita.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visita.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", visita.Hora_entrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", visita.Hora_salida);
            cmd.Parameters.AddWithValue("@MOTIVO_VISITA", visita.Motivo_visita);
            cmd.Parameters.AddWithValue("@AULA", visita.Aula);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void eliminarVisita(E_visita visita) 
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARVISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPERSONA", visita.IDpersona);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<E_visita> datosVisita(string buscar,string buscar2) 
        {
            SqlDataReader Leerfilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARVISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar", buscar);
            cmd.Parameters.AddWithValue("@buscar2", buscar2);
            Leerfilas = cmd.ExecuteReader();

            List<E_visita> listar = new List<E_visita>();

            while (Leerfilas.Read())
            {
                listar.Add(new E_visita
                {
                    IDpersona = Leerfilas.GetInt32(0),
                    Codigo = Leerfilas.GetString(1),
                    Nombre = Leerfilas.GetString(2),
                    Apellido = Leerfilas.GetString(3),
                    Carrera = Leerfilas.GetString(4),
                    Correo = Leerfilas.GetString(5),
                    Edificio = Leerfilas.GetString(6),
                    Hora_entrada = Leerfilas.GetDateTime(7),
                    Hora_salida = Leerfilas.GetDateTime(8),
                    Motivo_visita = Leerfilas.GetString(9),
                    Aula = Leerfilas.GetString(10),
                });
            }
            
            conexion.Close();
            Leerfilas.Close();
            return listar;
        }
    }
}
