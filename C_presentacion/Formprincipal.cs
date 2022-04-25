using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidad_L;

namespace C_presentacion
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Form formactivar = null;

        public void abrirformulario (Form formhijo) 
        {
            if (formactivar != null)
                formactivar.Close();
            formactivar = formhijo;
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(formhijo);
            wrapper.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            
            abrirformulario(new Formvisita());

            lbltema.Text = "VISITAS";
        }

        private void btnregistros_Click(object sender, EventArgs e)
        {
            abrirformulario(new FormRegistro());
            lbltema.Text = "REGISTROS";
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            abrirformulario(new FormCrear());
            lbltema.Text = "CREAR USUARIO";
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            abrirformulario(new FormUsuario());
            lbltema.Text = "USUARIOS";
        }

        private void VerUsuarioData()
        {
            lblusuario.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lbltipo.Text = UserLoginCache.Cargo;
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            VerUsuarioData();
        }
    }
}
