using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Text;
using System.Windows.Forms;

namespace PTC_Oficial
{
    public partial class Contrato : Form
    {
        public Contrato()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void lblNIT_Click(object sender, EventArgs e)
        {

        }
        public void MostrarDatos()
        {
            contratos con = new contratos();
            try
            {
                dgvContrato.DataSource = con.MostrarContratos();
            }
            catch
            {
                errorContrato.SetError(dgvContrato, "Error en la conexión con la base de datos");
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtClausulas.Text == "" || txtEmpresa.Text == "" || cboEmpleados.Text == "" || cboSalarios.Text == "")
            {
                errorContrato.SetError(txtClausulas, "Los campos estan vacios.");
                errorContrato.SetError(txtEmpresa, "Los campos estan vacios.");
                errorContrato.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorContrato.SetError(cboSalarios, "Los campos estan vacios esto significa que no hay registros de tiempo por tarea en el programa, apriete el boton tiempo por tarea e ingrese registros de tiempo por tarea.");
            }
            else
            {
                contratos con = new contratos();
                con.Fecha = dtpFecha.Text;
                con.Empresa = txtEmpresa.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.nacionalidad = (int)cboNacionalidades.SelectedValue;
                con.apartir = dtpDesde.Text;
                con.hasta = dtpHasta.Text;
                con.salario = (int)cboSalarios.SelectedValue;
                con.Clausulas = txtClausulas.Text;

                if (con.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorContrato.SetError(dgvContrato, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvContrato.CurrentRow.Cells[0].Value.ToString());
                contratos con = new contratos();
                con.idContratos = id;
                if (con.Eliminar())
                {
                    MostrarDatos();
                }
                else
                {
                    errorContrato.SetError(dgvContrato, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtClausulas.Text == "" || txtEmpresa.Text == "" || cboEmpleados.Text == "" || cboSalarios.Text == "")
            {
                errorContrato.SetError(txtClausulas, "Los campos estan vacios.");
                errorContrato.SetError(txtEmpresa, "Los campos estan vacios.");
                errorContrato.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorContrato.SetError(cboSalarios, "Los campos estan vacios esto significa que no hay registros de tiempo por tarea en el programa, apriete el boton tiempo por tarea e ingrese registros de tiempo por tarea.");
            }
            else
            {
                int id = int.Parse(dgvContrato.CurrentRow.Cells[0].Value.ToString());
                contratos con = new contratos();
                con.Fecha = dtpFecha.Text;
                con.Empresa = txtEmpresa.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.nacionalidad = (int)cboNacionalidades.SelectedValue;
                con.apartir = dtpDesde.Text;
                con.hasta = dtpHasta.Text;
                con.salario = (int)cboSalarios.SelectedValue;
                con.Clausulas = txtClausulas.Text;
                con.idContratos = id;

                if (con.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorContrato.SetError(dgvContrato, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }

        private void Contrato_Load(object sender, EventArgs e)
        {
            contratos c = new contratos();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            cboNacionalidades.DataSource = c.Nacionalidades();
            cboNacionalidades.DisplayMember = "nacionalidad";
            cboNacionalidades.ValueMember = "idNacionalidad";

            cboSalarios.DataSource = c.Salario();
            cboSalarios.DisplayMember = "salario_neto";
            cboSalarios.ValueMember = "id_salario";

            dgvContrato.Columns[0].Visible = false;
        }

        private void dgvContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha.Text = dgvContrato.CurrentRow.Cells[1].Value.ToString();
            txtEmpresa.Text = dgvContrato.CurrentRow.Cells[2].Value.ToString();
            cboEmpleados.Text = dgvContrato.CurrentRow.Cells[3].Value.ToString();
            cboNacionalidades.Text = dgvContrato.CurrentRow.Cells[4].Value.ToString();
            dtpDesde.Text = dgvContrato.CurrentRow.Cells[5].Value.ToString();
            dtpHasta.Text = dgvContrato.CurrentRow.Cells[6].Value.ToString();
            cboSalarios.Text = dgvContrato.CurrentRow.Cells[7].Value.ToString();
            txtClausulas.Text = dgvContrato.CurrentRow.Cells[8].Value.ToString();

        }

        private void txtClausulas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
