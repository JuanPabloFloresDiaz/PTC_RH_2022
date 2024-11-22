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
    public partial class GestionVacaciones : Form
    {
        public GestionVacaciones()
        {
            InitializeComponent();
            MostrarDatos();
        }
       
        private void dgvVacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "")
            {
                errorVacaciones.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                vacaciones con = new vacaciones();
                con.Fecha_Inicio = dtpFechaInicial.Text;
                con.Fecha_Final = dtpFechaFinal.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                if (con.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorVacaciones.SetError(dgvVacaciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }
        private void MostrarDatos()
        {
            vacaciones s = new vacaciones();
            dgvVacaciones.DataSource = s.MostrarVacaciones();
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                int id = int.Parse(dgvVacaciones.CurrentRow.Cells[0].Value.ToString());
                vacaciones vac = new vacaciones();
                vac.idGestionVacaciones = id;
                if (vac.Eliminar())
                {
                    MessageBox.Show("la solicitud de vacaciones ha sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDatos();


                }
                else
                {
                    errorVacaciones.SetError(dgvVacaciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvVacaciones.CurrentRow.Cells[0].Value.ToString());

            vacaciones con = new vacaciones();
            con.Fecha_Inicio = dtpFechaInicial.Text;
            con.Fecha_Final = dtpFechaFinal.Text;
            con.empleados = (int)cboEmpleados.SelectedValue;
            con.idGestionVacaciones = id;
            if (con.Update() == true)
            {
                MostrarDatos();
            }
            else
            {
                errorVacaciones.SetError(dgvVacaciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
            }
        }

        private void GestionVacaciones_Load(object sender, EventArgs e)
        {
            dgvVacaciones.Columns[0].Visible = false;
            MostrarDatos();
            vacaciones c = new vacaciones();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
        }
    }
}
