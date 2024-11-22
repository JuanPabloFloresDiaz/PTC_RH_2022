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
    public partial class ActasAdministrativas : Form
    {
        public ActasAdministrativas()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRazon.Text == "" || txtFalta.Text == "" || txtCiudad.Text == "" || txtEmpresa.Text == "" || txtHechos.Text == "" || txtAcusador.Text == "" || txtCargo.Text == "" || cboEmpleados.Text == "")
            {
                errorActas.SetError(txtRazon, "Los campos estan vacios.");
                errorActas.SetError(txtFalta, "Los campos estan vacios.");
                errorActas.SetError(txtCiudad, "Los campos estan vacios.");
                errorActas.SetError(txtEmpresa, "Los campos estan vacios.");
                errorActas.SetError(txtHechos, "Los campos estan vacios.");
                errorActas.SetError(txtAcusador, "Los campos estan vacios.");
                errorActas.SetError(txtCargo, "Los campos estan vacios.");
                errorActas.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
            }
            else
            {
                actas act = new actas();
                act.Razon = txtRazon.Text;
                act.Empresa = txtEmpresa.Text;
                act.Ciudad = txtCiudad.Text;
                act.Fecha = dtpFecha.Text;
                act.Hechos = txtHechos.Text;
                act.Acusador = txtAcusador.Text;
                act.Cargo = txtCargo.Text;
                act.Falta = txtFalta.Text;
                act.empleados = (int)cboEmpleados.SelectedValue;
                
                if (act.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorActas.SetError(dgvActas, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }
        public void MostrarDatos()
        {
            actas act = new actas();
            try
            {
                dgvActas.DataSource = act.MostrarActas();
            }
            catch
            {
                errorActas.SetError(dgvActas, "Error en la conexión con la base de datos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvActas.CurrentRow.Cells[0].Value.ToString());
                actas act = new actas();
                act.idActas = id;
                if (act.Eliminar())
                {
                    MostrarDatos();
                }
                else
                {
                    errorActas.SetError(dgvActas, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRazon.Text == "" || txtFalta.Text == "" || txtCiudad.Text == "" || txtEmpresa.Text == "" || txtHechos.Text == "" || txtAcusador.Text == "" || txtCargo.Text == "" || cboEmpleados.Text == "")
            {
                errorActas.SetError(txtRazon, "Los campos estan vacios.");
                errorActas.SetError(txtFalta, "Los campos estan vacios.");
                errorActas.SetError(txtCiudad, "Los campos estan vacios.");
                errorActas.SetError(txtEmpresa, "Los campos estan vacios.");
                errorActas.SetError(txtHechos, "Los campos estan vacios.");
                errorActas.SetError(txtAcusador, "Los campos estan vacios.");
                errorActas.SetError(txtCargo, "Los campos estan vacios.");
                errorActas.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
            }
            else
            {
                int id = int.Parse(dgvActas.CurrentRow.Cells[0].Value.ToString());
                actas act = new actas();
                act.Razon = txtRazon.Text;
                act.Empresa = txtEmpresa.Text;
                act.Ciudad = txtCiudad.Text;
                act.Fecha = dtpFecha.Text;
                act.Hechos = txtHechos.Text;
                act.Acusador = txtAcusador.Text;
                act.Cargo = txtCargo.Text;
                act.Falta = txtFalta.Text;
                act.empleados = (int)cboEmpleados.SelectedValue;
                act.idActas = id;

                if (act.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorActas.SetError(dgvActas, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }

        private void ActasAdministrativas_Load(object sender, EventArgs e)
        {
            actas c = new actas();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
            dgvActas.Columns[0].Visible = false;
        }

        private void txtFalta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condición para solo numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //Si no cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numericos", "validacion de numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvActas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRazon.Text = dgvActas.CurrentRow.Cells[1].Value.ToString();
            txtEmpresa.Text = dgvActas.CurrentRow.Cells[2].Value.ToString();
            txtCiudad.Text = dgvActas.CurrentRow.Cells[3].Value.ToString();
            dtpFecha.Text = dgvActas.CurrentRow.Cells[4].Value.ToString();
            txtHechos.Text = dgvActas.CurrentRow.Cells[5].Value.ToString();
            txtAcusador.Text = dgvActas.CurrentRow.Cells[6].Value.ToString();
            txtCargo.Text = dgvActas.CurrentRow.Cells[7].Value.ToString();
            txtFalta.Text = dgvActas.CurrentRow.Cells[8].Value.ToString();
            cboEmpleados.Text = dgvActas.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
