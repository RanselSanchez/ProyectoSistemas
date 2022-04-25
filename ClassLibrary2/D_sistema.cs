using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;
using capa_entidad_L;
using System.Windows.Forms;


namespace CapaDatos
{
    public class D_sistema
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public bool selectlogin(string Usuario,string Contraseña) 
        {
           
                SqlCommand cmd = new SqlCommand("SP_LOGIN", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@VUSUARIO", Usuario);
                cmd.Parameters.AddWithValue("@VCLAVE", Contraseña);

                SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    UserLoginCache.IDusuario = dr.GetInt32(0);
                    UserLoginCache.Nombre = dr.GetString(1);
                    UserLoginCache.Apellido = dr.GetString(2);
                    UserLoginCache.Cargo = dr.GetString(4);
                }
                return true;
            }
            else
                return false;
                
               
           

        }

        public void InsertarUsuario(E_sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", sistema.N_usuario);
            cmd.Parameters.AddWithValue("@APELLIDO", sistema.A_usuario);
            cmd.Parameters.AddWithValue("@FECHA", sistema.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", sistema.Tipo_usuario);
            cmd.Parameters.AddWithValue("@USUARIO", sistema.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", sistema.Contraseña);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarUsuario(E_sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDUSUARIO", sistema.IDusuario);
            cmd.Parameters.AddWithValue("@NOMBRE", sistema.N_usuario);
            cmd.Parameters.AddWithValue("@APELLIDO", sistema.A_usuario);
            cmd.Parameters.AddWithValue("@FECHA", sistema.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@TIPO_USUSARIO", sistema.Tipo_usuario);
            cmd.Parameters.AddWithValue("@USUARIO", sistema.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", sistema.Contraseña);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EliminarUsuario(E_sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDUSUARIO", sistema.IDusuario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<E_sistema> datosUsuario(string buscar1)
        {
            SqlDataReader Leerfilas2;
            SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@buscar3", buscar1);
            Leerfilas2 = cmd.ExecuteReader();

            List<E_sistema> listar = new List<E_sistema>();

            while (Leerfilas2.Read())
            {
                listar.Add(new E_sistema
                {
                    IDusuario = Leerfilas2.GetInt32(0),
                    N_usuario = Leerfilas2.GetString(1),
                    A_usuario = Leerfilas2.GetString(2),
                    Fecha_nacimiento = Leerfilas2.GetDateTime(3),
                    Tipo_usuario = Leerfilas2.GetString(4),
                    Usuario = Leerfilas2.GetString(5),
                    Contraseña = Leerfilas2.GetString(6),
                    
                });
            }

            conexion.Close();
            Leerfilas2.Close();
            return listar;
        }
    }
}
