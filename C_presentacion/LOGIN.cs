using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio_V;

namespace C_presentacion
{
    public partial class LOGIN : Form
    {
        D_sistema objdatos = new D_sistema();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text != "USUARIO")
            {
                if(txtpass.Text != "CONTRASEÑA")
                {
                    var validlogin = objdatos.selectlogin(txtuser.Text, txtpass.Text);
                    if (validlogin == true)
                    {
                        Formprincipal menu = new Formprincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrecta.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
