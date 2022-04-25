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
using CapaNegocio;

namespace C_presentacion
{
    public partial class FormactualizarUsuario : Form
    {
        public FormactualizarUsuario()
        {
            InitializeComponent();
        }
        public string IDusuario2;
        public bool editarse = false;
        E_sistema objEntidad = new E_sistema();
        N_sistema objNegocio = new N_sistema();
        FormUsuario tabla = new FormUsuario();
        private void botonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameUser2_Enter(object sender, EventArgs e)
        {
            if (txtNameUser2.Text == "NOMBRE:")
            {
                txtNameUser2.Text = "";

            }
        }

        private void txtNameUser2_Leave(object sender, EventArgs e)
        {
            if (txtNameUser2.Text == "")
            {
                txtNameUser2.Text = "NOMBRE:";
            }
        }

        private void txtLastNameUser2_Enter(object sender, EventArgs e)
        {
            if (txtLastNameUser2.Text == "APELLIDO:")
            {
                txtLastNameUser2.Text = "";

            }
        }

        private void txtLastNameUser2_Leave(object sender, EventArgs e)
        {
            if (txtLastNameUser2.Text == "")
            {
                txtLastNameUser2.Text = "APELLIDO:";
            }
        }

        private void txtcrearuser2_Enter(object sender, EventArgs e)
        {
            if (txtcrearuser2.Text == "USUARIO:")
            {
                txtcrearuser2.Text = "";
            }
        }

        private void txtcrearuser2_Leave(object sender, EventArgs e)
        {
            if (txtcrearuser2.Text == "")
            {
                txtcrearuser2.Text = "USUARIO:";
            }
        }

        private void txtCrearpass2_Enter(object sender, EventArgs e)
        {
            if (txtCrearpass2.Text == "CONTRASEÑA:")
            {
                txtCrearpass2.Text = "";
            }
        }

        private void txtCrearpass2_Leave(object sender, EventArgs e)
        {
            if (txtCrearpass2.Text == "")
            {
                txtCrearpass2.Text = "CONTRASEÑA:";
            }
        }

        private void btnGuardaruser_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.N_usuario = txtNameUser2.Text.Trim();
                    objEntidad.A_usuario = txtLastNameUser2.Text.Trim();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(Fecha_nacimiento2.Text);
                    objEntidad.Tipo_usuario = comboboxtipo2.Text.Trim();
                    objEntidad.Usuario = txtcrearuser2.Text.Trim();
                    objEntidad.Contraseña = txtCrearpass2.Text.Trim();


                    objNegocio.InsertarUsuario(objEntidad);
                    tabla.mostrartabla("");

                    MessageBox.Show("se han guardado los datos correctamente.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se ha guardado los datos correctamente" + ex);

                }
            }
            else if (editarse == true)
            {
                try
                {
                    objEntidad.IDusuario = Convert.ToInt32(IDusuario2);
                    objEntidad.N_usuario = txtNameUser2.Text.Trim();
                    objEntidad.A_usuario = txtLastNameUser2.Text.Trim();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(Fecha_nacimiento2.Text);
                    objEntidad.Tipo_usuario = comboboxtipo2.Text.Trim();
                    objEntidad.Usuario = txtcrearuser2.Text.Trim();
                    objEntidad.Contraseña = txtCrearpass2.Text.Trim();


                    objNegocio.EditarUsuario(objEntidad);
                    tabla.mostrartabla("");

                    MessageBox.Show("se han editado los datos correctamente.");
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se han editado los datos correctamente" + ex);

                }
            }
        }
    }
}
