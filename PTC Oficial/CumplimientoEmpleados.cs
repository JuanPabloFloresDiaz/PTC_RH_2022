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
    public partial class CumplimientoEmpleados : Form
    {
        public CumplimientoEmpleados()
        {
            InitializeComponent();
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            cumplimiento s = new cumplimiento();
            dgvCumplimientoEmpleado.DataSource = s.MostrarCumplimiento();

            dgvCumplimientoEmpleado.Columns[0].Visible = false;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int mayora100A, mayora100B, mayora100C, mayora100D, mayora100E, mayora100F;
            mayora100A = Convert.ToInt32(txtActitud.Text);
            mayora100B = Convert.ToInt32(txtEficiencia.Text);
            mayora100C = Convert.ToInt32(txtEntornoLaboral.Text);
            mayora100D = Convert.ToInt32(txtEsfuerzo.Text);
            mayora100E = Convert.ToInt32(txtProductividad.Text);
            mayora100F = Convert.ToInt32(txtTrabajoenequipo.Text);

            if (mayora100A > 100 || mayora100B > 100 || mayora100C > 100 || mayora100D > 100 || mayora100E > 100 || mayora100F > 100)
            {
                errorCumplimiento.SetError(btnAgregar, "Error el numero es mayor a 100");
            }
            else
            {
                if (txtActitud.Text == "" || txtEficiencia.Text == "" || txtEntornoLaboral.Text == "" || txtTrabajoenequipo.Text == "" || txtEsfuerzo.Text == "" || txtProductividad.Text == "" || cboEmpleados.Text == "")
                {
                    errorCumplimiento.SetError(txtActitud, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEficiencia, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEntornoLaboral, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtTrabajoenequipo, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEsfuerzo, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtProductividad, "Los campos estan vacios.");
                    errorCumplimiento.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                }
                else
                {
                    cumplimiento cum = new cumplimiento();
                    cum.Calidad = int.Parse(txtProductividad.Text);
                    cum.Eficiencia = int.Parse(txtEficiencia.Text);
                    cum.Entornolaboral = int.Parse(txtEntornoLaboral.Text);
                    cum.Actitud = int.Parse(txtActitud.Text);
                    cum.Esfuerzo = int.Parse(txtEsfuerzo.Text);
                    cum.Trabajoenequipo = int.Parse(txtTrabajoenequipo.Text);
                    cum.Empleado = (int)cboEmpleados.SelectedValue;
                    if (cum.Agregar() == true)
                    {
                        MostrarDatos();
                    }
                    else
                    {
                        errorCumplimiento.SetError(dgvCumplimientoEmpleado, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvCumplimientoEmpleado.CurrentRow.Cells[0].Value.ToString());
                cumplimiento cum = new cumplimiento();
                cum.idCumplimiento = id;
                if (cum.Eliminar())
                {
                    MostrarDatos();
                }
                else
                {
                    errorCumplimiento.SetError(dgvCumplimientoEmpleado, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int mayora100A, mayora100B, mayora100C, mayora100D, mayora100E, mayora100F;
            mayora100A = Convert.ToInt32(txtActitud.Text);
            mayora100B = Convert.ToInt32(txtEficiencia.Text);
            mayora100C = Convert.ToInt32(txtEntornoLaboral.Text);
            mayora100D = Convert.ToInt32(txtEsfuerzo.Text);
            mayora100E = Convert.ToInt32(txtProductividad.Text);
            mayora100F = Convert.ToInt32(txtTrabajoenequipo.Text);

            if (mayora100A > 100 || mayora100B > 100 || mayora100C > 100 || mayora100D > 100 || mayora100E > 100 || mayora100F > 100)
            {
                errorCumplimiento.SetError(btnActualizar, "Error el numero es mayor a 100");
            }
            else
            {
                if (txtActitud.Text == "" || txtEficiencia.Text == "" || txtEntornoLaboral.Text == "" || txtTrabajoenequipo.Text == "" || txtEsfuerzo.Text == "" || txtProductividad.Text == "" || cboEmpleados.Text == "")
                {
                    errorCumplimiento.SetError(txtActitud, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEficiencia, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEntornoLaboral, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtTrabajoenequipo, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtEsfuerzo, "Los campos estan vacios.");
                    errorCumplimiento.SetError(txtProductividad, "Los campos estan vacios.");
                    errorCumplimiento.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                }
                else
                {

                    int id = int.Parse(dgvCumplimientoEmpleado.CurrentRow.Cells[0].Value.ToString());
                    cumplimiento cum = new cumplimiento();
                    cum.Calidad = int.Parse(txtProductividad.Text);
                    cum.Eficiencia = int.Parse(txtEficiencia.Text);
                    cum.Entornolaboral = int.Parse(txtEntornoLaboral.Text);
                    cum.Actitud = int.Parse(txtActitud.Text);
                    cum.Esfuerzo = int.Parse(txtEsfuerzo.Text);
                    cum.Trabajoenequipo = int.Parse(txtTrabajoenequipo.Text);
                    cum.Empleado = (int)cboEmpleados.SelectedValue;
                    cum.idCumplimiento = id;

                    if (cum.Update() == true)
                    {
                        MostrarDatos();
                    }
                    else
                    {
                        errorCumplimiento.SetError(dgvCumplimientoEmpleado, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                    }
                }
            }
        }

        private void CumplimientoEmpleados_Load(object sender, EventArgs e)
        {
            cumplimiento c = new cumplimiento();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
        }

        private void dgvCumplimientoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductividad.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtEficiencia.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtEntornoLaboral.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtActitud.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtEsfuerzo.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtTrabajoenequipo.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[6].Value.ToString();
            cboEmpleados.Text = dgvCumplimientoEmpleado.CurrentRow.Cells[7].Value.ToString();
            
        }
    }
}
