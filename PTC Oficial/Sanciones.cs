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
    public partial class Sanciones : Form
    {
        public Sanciones()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void cboTiempoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarDatos()
        {
            sancion s = new sancion();
            dgvSanciones.DataSource = s.MostrarSanciones();

            dgvSanciones.Columns[0].Visible = false;

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtDescripcion.Text =="")
            {
                errorSancion.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
                errorSancion.SetError(txtDescripcion, "Los campos estan vacios. ");
            }
            else
            {
                sancion san = new sancion();
                san.gravedad = (int)cboGravedad.SelectedValue;
                san.empleados = (int)cboEmpleados.SelectedValue;
                san.descripcion = txtDescripcion.Text;
                if (san.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorSancion.SetError(dgvSanciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                int ids = int.Parse(dgvSanciones.CurrentRow.Cells[0].Value.ToString());
                sancion s = new sancion();
                s.id = ids;
                if (s.Eliminar())
                {
                    MessageBox.Show("la solicitud de vacaciones ha sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDatos();


                }
                else
                {
                    errorSancion.SetError(dgvSanciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtDescripcion.Text == "")
            {
                errorSancion.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
                errorSancion.SetError(txtDescripcion, "Los campos estan vacios. ");
            }
            else
            {
                int ids = int.Parse(dgvSanciones.CurrentRow.Cells[0].Value.ToString());

                sancion san = new sancion();
                san.gravedad = (int)cboGravedad.SelectedValue;
                san.empleados = (int)cboEmpleados.SelectedValue;
                san.descripcion = txtDescripcion.Text;
                san.id = ids;
                if (san.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorSancion.SetError(dgvSanciones, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void Sanciones_Load(object sender, EventArgs e)
        {
            sancion c = new sancion();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            cboGravedad.DataSource = c.Gravedad();
            cboGravedad.DisplayMember = "gravedaddeSancion";
            cboGravedad.ValueMember = "idTipoSancion";
        }
    }
}
