using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            nominas nom = new nominas();
            try
            {
                dgvNominas.DataSource = nom.MostrarNomina();
            }
            catch
            {
                errorNomina.SetError(dgvNominas, "Error en la conexión con la base de datos");
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtAguinaldo.Text == "")
            {
                errorNomina.SetError(txtAguinaldo, "Los campos estan vacios");
                errorNomina.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                nominas nom = new nominas();
                nom.empleados = (int)cboEmpleados.SelectedValue;
                nom.aguinaldo = txtAguinaldo.Text;
                nom.salario = (int)cboSalario.SelectedValue;
                if (nom.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorNomina.SetError(dgvNominas, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                int id = int.Parse(dgvNominas.CurrentRow.Cells[0].Value.ToString());
                nominas nom = new nominas();
                nom.idnominas = id;
                if (nom.Eliminar())
                {
                    MessageBox.Show("la solicitud de vacaciones ha sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDatos();


                }
                else
                {
                    errorNomina.SetError(dgvNominas, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtAguinaldo.Text == "")
            {
                errorNomina.SetError(txtAguinaldo, "Los campos estan vacios");
                errorNomina.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                int id = int.Parse(dgvNominas.CurrentRow.Cells[0].Value.ToString());

                nominas nom = new nominas();
                nom.empleados = (int)cboEmpleados.SelectedValue;
                nom.aguinaldo = txtAguinaldo.Text;
                nom.salario = (int)cboSalario.SelectedValue;
                nom.idnominas = id;
                if (nom.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorNomina.SetError(dgvNominas, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            nominas c = new nominas();
            cboSalario.DataSource = c.Salarios();
            cboSalario.DisplayMember = "salario_neto";
            cboSalario.ValueMember = "id_salario";

            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            dgvNominas.Columns[0].Visible = false;
        }

        private void dgvNominas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboEmpleados.Text = dgvNominas.CurrentRow.Cells[1].Value.ToString();
            txtAguinaldo.Text = dgvNominas.CurrentRow.Cells[2].Value.ToString();
            cboSalario.Text = dgvNominas.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void txtAguinaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorNomina.SetError(txtAguinaldo, "Solo se admiten numeros");
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                errorNomina.SetError(txtAguinaldo, "Solo se admiten numeros y un decimal");
            }
        }
    }
}
