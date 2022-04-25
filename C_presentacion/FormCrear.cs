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
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }
        public string IDusuario;
        public bool editarse = false;
        E_sistema objEntidad = new E_sistema();
        N_sistema objNegocio = new N_sistema();


        
        private void txtNameUser_Enter(object sender, EventArgs e)
        {
            if (txtNameUser.Text == "NOMBRE:")
            {
                txtNameUser.Text = "";

            }
        }

        private void txtNameUser_Leave(object sender, EventArgs e)
        {
            if (txtNameUser.Text == "")
            {
                txtNameUser.Text = "NOMBRE:";
            }
        }

        private void txtLastNameUser_Enter(object sender, EventArgs e)
        {
            if (txtLastNameUser.Text == "APELLIDO:")
            {
                txtLastNameUser.Text = "";

            }
        }

        private void txtLastNameUser_Leave(object sender, EventArgs e)
        {
            if (txtLastNameUser.Text == "")
            {
                txtLastNameUser.Text = "APELLIDO:";
            }
        }

        private void txtcrearuser_Enter(object sender, EventArgs e)
        {
            if (txtcrearuser.Text == "USUARIO:"){
                txtcrearuser.Text = "";
            }
        }

        private void txtcrearuser_Leave(object sender, EventArgs e)
        {
            if (txtcrearuser.Text == "")
            {
                txtcrearuser.Text = "USUARIO:";
            }
        }

        private void txtCrearpass_Enter(object sender, EventArgs e)
        {if (txtCrearpass.Text == "CONTRASEÑA:")
            {
                txtCrearpass.Text = "";
            }
        }

        private void txtCrearpass_Leave(object sender, EventArgs e)
        {
            if (txtCrearpass.Text == "")
            {
                txtCrearpass.Text = "CONTRASEÑA:";
            }
        }

        private void btnGuardaruser_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.N_usuario = txtNameUser.Text.Trim();
                    objEntidad.A_usuario = txtLastNameUser.Text.Trim();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(Fecha_nacimiento.Text);
                    objEntidad.Tipo_usuario = comboboxtipo.Text.Trim();
                    objEntidad.Usuario = txtcrearuser.Text.Trim();
                    objEntidad.Contraseña = txtCrearpass.Text.Trim();
                   

                    objNegocio.InsertarUsuario(objEntidad);


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
                    objEntidad.IDusuario = Convert.ToInt32(IDusuario);
                    objEntidad.N_usuario = txtNameUser.Text.Trim();
                    objEntidad.A_usuario = txtLastNameUser.Text.Trim();
                    objEntidad.Fecha_nacimiento = Convert.ToDateTime(Fecha_nacimiento.Text);
                    objEntidad.Tipo_usuario = comboboxtipo.Text.Trim();
                    objEntidad.Usuario = txtcrearuser.Text.Trim();
                    objEntidad.Contraseña = txtCrearpass.Text.Trim();


                    objNegocio.EditarUsuario(objEntidad);


                    MessageBox.Show("se han editado los datos correctamente.");
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se han editado los datos correctamente" + ex);

                }
            }
        }

        public void limpiarcampos()
        {
            editarse = false;
            txtCrearpass.Text = "";
            txtcrearuser.Text = "";
            txtNameUser.Text = "";
            txtLastNameUser.Text = "";
            comboboxtipo.Text = "";
            Fecha_nacimiento.Value.DayOfWeek.ToString();
            txtNameUser.Focus();
           
        }

        private void btnNuevouser_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}
