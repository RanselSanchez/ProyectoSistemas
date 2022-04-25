using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos_V;
using CapaEntidad_V;
using CapaNegocio_V;

namespace C_presentacion
{
    public partial class Formactualizar : Form
    {
        public Formactualizar()
        {
            InitializeComponent();
        }
        public string IDpersona2;
        public bool editarse = false;
        E_visita objEntidad = new E_visita();
        N_visita objNegocio = new N_visita();
        FormRegistro tabla = new FormRegistro();

        private void txtcod2_Enter(object sender, EventArgs e)
        {
            if (txtcod2.Text == "CODIGO:")
            {
                txtcod2.Text = "";

            }
        }

        private void txtcod2_Leave(object sender, EventArgs e)
        {
            if (txtcod2.Text == "")
            {
                txtcod2.Text = "CODIGO:";
            }
        }

        private void txtnombre2_Enter(object sender, EventArgs e)
        {
            if (txtnombre2.Text == "NOMBRE:")
            {
                txtnombre2.Text = "";

            }
        }

        private void txtnombre2_Leave(object sender, EventArgs e)
        {
            if (txtnombre2.Text == "")
            {
                txtnombre2.Text = "NOMBRE:";
            }
        }

        private void txtapellido2_Enter(object sender, EventArgs e)
        {

            if (txtapellido2.Text == "APELLIDO:")
            {
                txtapellido2.Text = "";

            }
        }

        private void txtapellido2_Leave(object sender, EventArgs e)
        {
            if (txtapellido2.Text == "")
            {
                txtapellido2.Text = "APELLIDO:";
            }
        }

        private void txtcarrera2_Enter(object sender, EventArgs e)
        {
            if (txtcarrera2.Text == "CARRERA:")
            {
                txtcarrera2.Text = "";

            }
        }

        private void txtcorreo2_Leave(object sender, EventArgs e)
        {

            if (txtcorreo2.Text == "")
            {
                txtcorreo2.Text = "CORREO:";
            }
        }

        private void txtcarrera2_Leave(object sender, EventArgs e)
        {
            if (txtcarrera2.Text == "")
            {
                txtcarrera2.Text = "CARRERA:";
            }
        }

        private void txtcorreo2_Enter(object sender, EventArgs e)
        {
            if (txtcorreo2.Text == "")
            {
                txtcorreo2.Text = "CORREO:";
            }
        }

        private void comboBoxAULA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (editarse == false)
            {
                try
                {
                    objEntidad.Nombre = txtnombre2.Text.Trim();
                    objEntidad.Apellido = txtapellido2.Text.Trim();
                    objEntidad.Carrera = txtcarrera2.Text.Trim();
                    objEntidad.Correo = txtcorreo2.Text.Trim();
                    objEntidad.Edificio = combodepa2.Text.Trim();
                    objEntidad.Aula = comboBoxAULA2.Text.Trim();
                    objEntidad.Hora_entrada = Convert.ToDateTime(hora_entrada2.Text);
                    objEntidad.Hora_salida = Convert.ToDateTime(hora_salida2.Text);
                    objEntidad.Motivo_visita = motivo_visita2.Text.Trim();

                    objNegocio.insertarVisita(objEntidad);
                    tabla.mostrartabla("", "");

                    MessageBox.Show("se han guardado los datos correctamente.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se ha guardado los datos correctamente" + ex);

                }
            }
            if (editarse == true)
            {
                try
                {
                    objEntidad.IDpersona = Convert.ToInt32(IDpersona2);
                    objEntidad.Nombre = txtnombre2.Text.Trim();
                    objEntidad.Apellido = txtapellido2.Text.Trim();
                    objEntidad.Carrera = txtcarrera2.Text.Trim();
                    objEntidad.Correo = txtcorreo2.Text.Trim();
                    objEntidad.Edificio = combodepa2.Text.Trim();
                    objEntidad.Aula = comboBoxAULA2.Text.Trim();
                    objEntidad.Hora_entrada = Convert.ToDateTime(hora_entrada2.Text);
                    objEntidad.Hora_salida = Convert.ToDateTime(hora_salida2.Text);
                    objEntidad.Motivo_visita = motivo_visita2.Text.Trim();

                    objNegocio.editarVisita(objEntidad);


                    MessageBox.Show("se han editado los datos correctamente.");
                    tabla.mostrartabla("", "");
                    editarse = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se han editado los datos correctamente" + ex);

                }

                
            }
        }

        private void Formactualizar_Load(object sender, EventArgs e)
        {
            tabla.mostrartabla("","");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combodepa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //departamento A
            DataTable depaA = new DataTable();
            depaA.Columns.Add("departamento");
            DataRow row = depaA.NewRow();
            row["departamento"] = "Aula-A001";
            depaA.Rows.Add(row);
            DataRow row2 = depaA.NewRow();
            row2["departamento"] = "Aula-A002";
            depaA.Rows.Add(row2);
            DataRow row3 = depaA.NewRow();
            row3["departamento"] = "Aula-A003";
            depaA.Rows.Add(row3);
            DataRow row4 = depaA.NewRow();
            row4["departamento"] = "Aula-A004";
            depaA.Rows.Add(row4);
            DataRow row5 = depaA.NewRow();
            row5["departamento"] = "Aula-A005";
            depaA.Rows.Add(row5);
            DataRow row6 = depaA.NewRow();
            row6["departamento"] = "Aula-A006";
            depaA.Rows.Add(row6);

            //departamento B
            DataTable depaB = new DataTable();
            depaB.Columns.Add("departamento");
            DataRow row7 = depaB.NewRow();
            row7["departamento"] = "Aula-B001";
            depaB.Rows.Add(row7);
            DataRow row8 = depaB.NewRow();
            row8["departamento"] = "Aula-B002";
            depaB.Rows.Add(row8);
            DataRow row9 = depaB.NewRow();
            row9["departamento"] = "Aula-B003";
            depaB.Rows.Add(row9);
            DataRow row10 = depaB.NewRow();
            row10["departamento"] = "Aula-B004";
            depaB.Rows.Add(row10);
            DataRow row11 = depaB.NewRow();
            row11["departamento"] = "Aula-B005";
            depaB.Rows.Add(row11);
            DataRow row12 = depaB.NewRow();
            row12["departamento"] = "Aula-B006";
            depaB.Rows.Add(row12);

            //departamento c
            DataTable depac = new DataTable();
            depac.Columns.Add("departamento");
            DataRow row13 = depac.NewRow();
            row13["departamento"] = "Aula-C001";
            depac.Rows.Add(row13);
            DataRow row14 = depac.NewRow();
            row14["departamento"] = "Aula-C002";
            depac.Rows.Add(row14);
            DataRow row15 = depac.NewRow();
            row15["departamento"] = "Aula-C003";
            depac.Rows.Add(row15);
            DataRow row16 = depac.NewRow();
            row16["departamento"] = "Aula-C004";
            depac.Rows.Add(row16);
            DataRow row17 = depac.NewRow();
            row17["departamento"] = "Aula-C005";
            depac.Rows.Add(row17);
            DataRow row18 = depac.NewRow();
            row18["departamento"] = "Aula-C006";
            depac.Rows.Add(row18);

            if (combodepa2.SelectedIndex == 0)
            {
                comboBoxAULA2.DataSource = depaA;
                comboBoxAULA2.DisplayMember = "departamento";
            }
            else if (combodepa2.SelectedIndex == 1)
            {
                comboBoxAULA2.DataSource = depaB;
                comboBoxAULA2.DisplayMember = "departamento";
            }
            else if (combodepa2.SelectedIndex == 2)
            {
                comboBoxAULA2.DataSource = depac;
                comboBoxAULA2.DisplayMember = "departamento";
            }

        }
    }
}
