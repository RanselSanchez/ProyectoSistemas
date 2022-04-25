using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad_V;
using CapaNegocio_V;
using CapaDatos_V;

namespace C_presentacion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        E_visita objEntidad = new E_visita();
        N_visita objNegocio = new N_visita();

        public void mostrartabla(string buscar, string buscar2)
        {
            N_visita objnegocio = new N_visita();
            
           tablaVisitas.DataSource = objnegocio.datosVisita(buscar,buscar2);
           

        }
        public void acciontabla()
        {
            tablaVisitas.Columns[0].Visible = false;
            tablaVisitas.ClearSelection();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            mostrartabla("","");
            acciontabla();
        }

        private void comboelegirdep_Click(object sender, EventArgs e)
        {

            if(comboelegirdep.Text == "Departamento A")
            {
                mostrartabla("",comboelegirdep.Text);
            }
            if (comboelegirdep.Text == "Departamento B")
            {
                mostrartabla("", comboelegirdep.Text);
            } 
            if(comboelegirdep.Text == "Departamento C")
            {
                mostrartabla("", comboelegirdep.Text);
            }

          
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            mostrartabla(txtbuscar.Text,"");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (tablaVisitas.SelectedRows.Count > 0)
            {
                objEntidad.IDpersona = Convert.ToInt32(tablaVisitas.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminarVisita(objEntidad);

                MessageBox.Show("Se han eliminado las tablas");
                mostrartabla("", "");

            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desee eliminar");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Formactualizar editarform = new Formactualizar();


            if (tablaVisitas.SelectedRows.Count > 0)
            {
                editarform.editarse = true;
                editarform.IDpersona2 = tablaVisitas.CurrentRow.Cells[0].Value.ToString();
                editarform.txtcod2.Text = tablaVisitas.CurrentRow.Cells[1].Value.ToString();
                editarform.txtnombre2.Text = tablaVisitas.CurrentRow.Cells[2].Value.ToString();
                editarform.txtapellido2.Text = tablaVisitas.CurrentRow.Cells[3].Value.ToString();
                editarform.txtcarrera2.Text = tablaVisitas.CurrentRow.Cells[4].Value.ToString();
                editarform.txtcorreo2.Text = tablaVisitas.CurrentRow.Cells[5].Value.ToString();
                editarform.combodepa2.Text = tablaVisitas.CurrentRow.Cells[6].Value.ToString();
                editarform.hora_entrada2.Text = tablaVisitas.CurrentRow.Cells[7].Value.ToString();
                editarform.hora_salida2.Text = tablaVisitas.CurrentRow.Cells[8].Value.ToString();
                editarform.motivo_visita2.Text = tablaVisitas.CurrentRow.Cells[9].Value.ToString();
                editarform.comboBoxAULA2.Text = tablaVisitas.CurrentRow.Cells[10].Value.ToString();

                editarform.Show();
                mostrartabla("","");

            }
            else
            {
                MessageBox.Show("Seleccione la tabla que desea editar.");
            }
        }
    }
}
