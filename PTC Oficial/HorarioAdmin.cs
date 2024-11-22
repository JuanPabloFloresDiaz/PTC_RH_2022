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
    public partial class HorarioAdmin : Form
    {
        public HorarioAdmin()
        {
            InitializeComponent();
        }

        private void HorarioAdmin_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Horario s = new Horario();
            cboDia.DataSource = s.Dias();
            cboDia.DisplayMember = "dia";
            cboDia.ValueMember = "id_dia";

            cboTurno.DataSource = s.Turnos();
            cboTurno.DisplayMember = "Tipo_turno";
            cboTurno.ValueMember = "id_turno";

            cboEmpleados.DataSource = s.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "")
            {
                errorHorario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                Horario hor = new Horario();
                hor.Horas = dtpHora.Text;
                hor.Fecha = dtpFecha.Text;
                hor.dia = (int)cboDia.SelectedValue;
                hor.turno = (int)cboTurno.SelectedValue;
                hor.empleados = (int)cboEmpleados.SelectedValue;
                if (hor.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorHorario.SetError(dgvHorario, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }
        private void MostrarDatos()
        {
            Horario s = new Horario();
            dgvHorario.DataSource = s.MostrarHorario();

            dgvHorario.Columns[0].Visible = false;
            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "")
            {
                errorHorario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                
                int id = int.Parse(dgvHorario.CurrentRow.Cells[0].Value.ToString());

                Horario hor = new Horario();
                hor.Horas = dtpHora.Text;
                hor.Fecha = dtpFecha.Text;
                hor.dia = (int)cboDia.SelectedValue;
                hor.turno = (int)cboTurno.SelectedValue;
                hor.empleados = (int)cboEmpleados.SelectedValue;
                hor.idHorario = id;

                if (hor.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorHorario.SetError(dgvHorario, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvHorario.CurrentRow.Cells[0].Value.ToString());
                Horario hor = new Horario();
                hor.idHorario = id;
                if (hor.Eliminar())
                {
                    //MessageBox.Show("El contacto ha sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    MostrarDatos();
                }
                else
                {
                    errorHorario.SetError(dgvHorario, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpHora.Text = dgvHorario.CurrentRow.Cells[1].Value.ToString();
            dtpFecha.Text = dgvHorario.CurrentRow.Cells[2].Value.ToString();
            cboDia.Text = dgvHorario.CurrentRow.Cells[3].Value.ToString();
            cboTurno.Text = dgvHorario.CurrentRow.Cells[4].Value.ToString();
            cboEmpleados.Text = dgvHorario.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
