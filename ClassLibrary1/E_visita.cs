using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad_V
{
    public class E_visita
    {
        private int _IDpersona;
        private string _codigo;
        private string _nombre;
        private string _apellido;
        private string _carrera;
        private string _correo;
        private string _edificio;
        private DateTime _hora_entrada;
        private DateTime _hora_salida;
        private string motivo_visita;
        private string aula;

        public int IDpersona { get => _IDpersona; set => _IDpersona = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Carrera { get => _carrera; set => _carrera = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Edificio { get => _edificio; set => _edificio = value; }
        public DateTime Hora_entrada { get => _hora_entrada; set => _hora_entrada = value; }
        public DateTime Hora_salida { get => _hora_salida; set => _hora_salida = value; }
        public string Motivo_visita { get => motivo_visita; set => motivo_visita = value; }
        public string Aula { get => aula; set => aula = value; }
    }
}
