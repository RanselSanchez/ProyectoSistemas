using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_sistema
    {
        D_sistema objdatos = new D_sistema();
        public bool Selectlogin(string Usuario, string Contraseña)
        {
            return objdatos.selectlogin(Usuario, Contraseña);
        }
        public void InsertarUsuario(E_sistema sistema) 
        {
            objdatos.InsertarUsuario(sistema);
        }

        public void EditarUsuario(E_sistema sistema)
        {
            objdatos.EditarUsuario(sistema);
        }

        public void EliminarUsuario(E_sistema sistema) 
        {
            objdatos.EliminarUsuario(sistema);
        }

        public List<E_sistema> datosUsuario(string buscar1)
        {
            return objdatos.datosUsuario(buscar1);
        }
    }
}
