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
    public partial class BajasLaborales : Form
    {
        public BajasLaborales()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtJustificacion.Text == "" || cboVacaciones.Text == "" || cboEmpleados.Text == "" )
            {
                errorBajas.SetError(txtJustificacion, "Los campos estan vacios.");
                errorBajas.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorBajas.SetError(cboVacaciones, "Los campos estan vacios esto significa que no hay registros de gestion de vacaciones en el programa...");
            }
            else
            {
                bajas con = new bajas();
                con.vacaciones = (int)cboVacaciones.SelectedValue;
                con.Fecha = dtpFecha.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.Justificacion = txtJustificacion.Text;
                con.estatus = (int)cboEstatus.SelectedValue;
                if (con.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorBajas.SetError(dgvBajas, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvBajas.CurrentRow.Cells[0].Value.ToString());
                bajas con = new bajas();
                con.idBajas = id;
                if (con.Eliminar())
                {
                    MostrarDatos();
                }
                else
                {
                    errorBajas.SetError(dgvBajas, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtJustificacion.Text == "" || cboVacaciones.Text == "" || cboEmpleados.Text == "")
            {
                errorBajas.SetError(txtJustificacion, "Los campos estan vacios.");
                errorBajas.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorBajas.SetError(cboVacaciones, "Los campos estan vacios esto significa que no hay registros de gestion de vacaciones en el programa...");
            }
            else
            {


                int id = int.Parse(dgvBajas.CurrentRow.Cells[0].Value.ToString());
                bajas con = new bajas();
                con.vacaciones = (int)cboVacaciones.SelectedValue;
                con.Fecha = dtpFecha.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.Justificacion = txtJustificacion.Text;
                con.estatus = (int)cboEstatus.SelectedValue;
                con.idBajas = id;

                if (con.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorBajas.SetError(dgvBajas, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }
        public void MostrarDatos()
        {
            bajas con = new bajas();
            try
            {
                dgvBajas.DataSource = con.MostrarBajas();
            }
            catch
            {
                errorBajas.SetError(dgvBajas, "Error en la conexión con la base de datos");
            }
        }
        private void BajasLaborales_Load(object sender, EventArgs e)
        {
            bajas c = new bajas();
            cboVacaciones.DataSource = c.Vacaciones();
            cboVacaciones.DisplayMember = "Fecha_Inicio";
            cboVacaciones.ValueMember = "idGestionVacaciones";

            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            cboEstatus.DataSource = c.Estatus();
            cboEstatus.DisplayMember = "estatu";
            cboEstatus.ValueMember = "idEstatus";

            dgvBajas.Columns[0].Visible = false;
        }

        private void dgvBajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboVacaciones.Text = dgvBajas.CurrentRow.Cells[1].Value.ToString();
            dtpFecha.Text = dgvBajas.CurrentRow.Cells[2].Value.ToString();
            cboEmpleados.Text = dgvBajas.CurrentRow.Cells[3].Value.ToString();
            txtJustificacion.Text = dgvBajas.CurrentRow.Cells[4].Value.ToString();
            cboEstatus.Text = dgvBajas.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
