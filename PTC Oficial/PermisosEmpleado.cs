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
    public partial class PermisosEmpleado : Form
    {
        public PermisosEmpleado()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtJustificacion.Text == "")
            {
                errorPermisos.SetError(cboEmpleados, "Los campos estan vacios, muy posiblemente no se han ingresado sus datos de empleado al programa, solicite a un administrador que le ingrese sus datos.");
                errorPermisos.SetError(txtJustificacion, "Los campos estan vacios");


            }
            else
            {
                Permisos per = new Permisos((int)cboDia.SelectedValue, dtpHora.Text, dtpFecha.Text, (int)cboEmpleados.SelectedValue, txtJustificacion.Text);

                if (per.Agregar() == true)
                {
                    MostrarDatos();
                    txtJustificacion.Clear();

                }
                else
                {
                    errorPermisos.SetError(btnAgregar, "Hubo un error en el traspaso de información");
                }
            }
        }

        public void MostrarDatos()
        {
            Permisos per = new Permisos();
            try
            {
                dgvPermisos.DataSource = per.MostrarPermisos();
            }
            catch
            {
                errorPermisos.SetError(dgvPermisos, "Error en la conexión con la base de datos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvPermisos.CurrentRow.Cells[0].Value.ToString());
                Permisos cal = new Permisos(id);
                if (cal.Eliminar())
                {
                    txtJustificacion.Clear();
                    MostrarDatos();
                }
                else
                {
                   errorPermisos.SetError(btnEliminar, "Error al eliminar en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtJustificacion.Text == "")
            {
                errorPermisos.SetError(cboEmpleados, "Los campos estan vacios, muy posiblemente no se han ingresado sus datos de empleado al programa, solicite a un administrador que le ingrese sus datos.");
                errorPermisos.SetError(txtJustificacion, "Los campos estan vacios");
            }
            else
            {
                try
                {
                    int id = int.Parse(dgvPermisos.CurrentRow.Cells[0].Value.ToString());
                    int Dia = (int)cboDia.SelectedValue;
                    string Hora = dtpHora.Text;
                    string Fecha = dtpFecha.Text;
                    int Empleado = (int)cboEmpleados.SelectedValue;
                    string Justificacion = txtJustificacion.Text;

                    Permisos CAL = new Permisos(id, Dia, Hora, Fecha, Empleado, Justificacion);
                    if (CAL.Actualizar())
                    {
                        txtJustificacion.Clear();
                        MostrarDatos();
                    }
                    else
                    {
                        errorPermisos.SetError(btnActualizar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboDia.Text = dgvPermisos.CurrentRow.Cells[1].Value.ToString();
            dtpHora.Text = dgvPermisos.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Text = dgvPermisos.CurrentRow.Cells[3].Value.ToString();
            cboEmpleados.Text = dgvPermisos.CurrentRow.Cells[4].Value.ToString();
            txtJustificacion.Text = dgvPermisos.CurrentRow.Cells[5].Value.ToString();
        }

        private void PermisosEmpleado_Load(object sender, EventArgs e)
        {
           dgvPermisos.Columns[0].Visible = false;
            Permisos c = new Permisos();
            cboDia.DataSource = c.Dias();
            cboDia.DisplayMember = "dia";
            cboDia.ValueMember = "id_dia";

            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            string dia = dtpFecha.Value.DayOfWeek.ToString();
            if (dia == "Sunday")
            {
                cboDia.DisplayMember = "Domingo";
                cboDia.SelectedValue = 7;
            }
            else if (dia == "Monday")
            {
                cboDia.DisplayMember = "Lunes";
                cboDia.SelectedValue = 1;
            }
            else if (dia == "Tuesday")
            {
                cboDia.DisplayMember = "Martes";
                cboDia.SelectedValue = 2;
            }
            else if (dia == "Wednesday")
            {
                cboDia.DisplayMember = "Miercoles";
                cboDia.SelectedValue = 3;
            }
            else if (dia == "Thursday")
            {
                cboDia.DisplayMember = "Jueves";
                cboDia.SelectedValue = 4;
            }
            else if (dia == "Friday")
            {
                cboDia.DisplayMember = "Viernes";
                cboDia.SelectedValue = 5;
            }
            else if (dia == "Saturday")
            {
                cboDia.DisplayMember = "Sabado";
                cboDia.SelectedValue = 6;
            }
        }
    }
}
