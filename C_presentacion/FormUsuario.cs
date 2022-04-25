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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        E_sistema objEntidad = new E_sistema();
        N_sistema objNegocio = new N_sistema();

        public void mostrartabla(string buscar1)
        {
            N_sistema objNegocio = new N_sistema();

            datatableUSER.DataSource = objNegocio.datosUsuario(buscar1);


        }
        public void acciontabla()
        {
            datatableUSER.Columns[0].Visible = false;
            datatableUSER.ClearSelection();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            mostrartabla("");
            acciontabla();
        }

        private void txtbuscarUSER_TextChanged(object sender, EventArgs e)
        {
            mostrartabla(txtbuscarUSER.Text);
        }

        private void btnEliminarUSER_Click(object sender, EventArgs e)
        {
            if (datatableUSER.SelectedRows.Count > 0)
            {
                objEntidad.IDusuario = Convert.ToInt32(datatableUSER.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarUsuario(objEntidad);

                MessageBox.Show("Se han eliminado las tablas");
                mostrartabla("");

            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desee eliminar");
            }
        }

        private void btnEditarUSER_Click(object sender, EventArgs e)
        {
            FormactualizarUsuario editarform = new FormactualizarUsuario();


            if (datatableUSER.SelectedRows.Count > 0)
            {
                editarform.editarse = true;
                editarform.IDusuario2 = datatableUSER.CurrentRow.Cells[0].Value.ToString();
                editarform.txtNameUser2.Text = datatableUSER.CurrentRow.Cells[1].Value.ToString();
                editarform.txtLastNameUser2.Text = datatableUSER.CurrentRow.Cells[2].Value.ToString();
                editarform.Fecha_nacimiento2.Text = datatableUSER.CurrentRow.Cells[3].Value.ToString();
                editarform.comboboxtipo2.Text = datatableUSER.CurrentRow.Cells[4].Value.ToString();
                editarform.txtcrearuser2.Text = datatableUSER.CurrentRow.Cells[5].Value.ToString();
                editarform.txtCrearpass2.Text = datatableUSER.CurrentRow.Cells[6].Value.ToString();

                editarform.Show();

            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar.");
            }
        }
    }
}