using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos_V;
using CapaEntidad_V;

namespace CapaNegocio_V 
{ 
    public class N_visita
    {
        D_visita objdatos = new D_visita();

        public void insertarVisita(E_visita visita) 
        {
            objdatos.insertarVisita(visita);
        }

        public void editarVisita(E_visita visita)
        {

            objdatos.editarVisita(visita);
        }

        public void eliminarVisita(E_visita visita) 
        {
            objdatos.eliminarVisita(visita);
        }

        public List<E_visita> datosVisita(string buscar,string buscar2)
        {
            return objdatos.datosVisita(buscar,buscar2);
        }



    }
}
