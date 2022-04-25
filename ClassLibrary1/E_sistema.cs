using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_sistema
    {

        private int _IDusuario;
        private string _N_usuario;
        private string _A_usuario;
        private DateTime _fecha_nacimiento;
        private string _tipo_usuario;
        private string _usuario;
        private string _contraseña;

        public int IDusuario { get => _IDusuario; set => _IDusuario = value; }
        public string N_usuario { get => _N_usuario; set => _N_usuario = value; }
        public string A_usuario { get => _A_usuario; set => _A_usuario = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string Tipo_usuario { get => _tipo_usuario; set => _tipo_usuario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
    }
}
