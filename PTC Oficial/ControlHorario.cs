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
    public partial class ControlHorario : Form
    {
        public ControlHorario()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Este label fue abierto por error :[
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
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelObjetos.Controls.Count > 0)
                this.panelObjetos.Controls.RemoveAt(0);
            this.panelContenedor.Visible = false;
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelObjetos.Controls.Add(fh);
            this.panelObjetos.Tag = fh;
            fh.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtHorastrabajada.Text == "" || txtNIT.Text == "" || cboEmpleados.Text == "" || cboTiempoTarea.Text == "")
            {
                errorControlhorario.SetError(txtHorastrabajada, "Los campos estan vacios.");
                errorControlhorario.SetError(txtNIT, "Los campos estan vacios.");
                errorControlhorario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorControlhorario.SetError(cboTiempoTarea, "Los campos estan vacios esto significa que no hay registros de tiempo por tarea en el programa, apriete el boton tiempo por tarea e ingrese registros de tiempo por tarea.");
            }
            else
            {
                control con = new control();
                con.dia = (int)cboDia.SelectedValue;
                con.entrada = dtpEntrada.Text;
                con.salida = dtpSalida.Text;
                con.inicio = dtpInicio.Text;
                con.finalizacion = dtpAcabo.Text;
                con.horas = txtHorastrabajada.Text;
                con.NIT = txtNIT.Text;
                con.Fecha = dtpFecha.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.tiempotarea = (int)cboTiempoTarea.SelectedValue;
                if (con.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorControlhorario.SetError(dgvControlHorario, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                try
                {
                    int id = int.Parse(dgvControlHorario.CurrentRow.Cells[0].Value.ToString());
                    control con = new control();
                    con.idControl = id;
                    if (con.Eliminar())
                    {
                        MostrarDatos();
                    }
                    else
                    {
                        errorControlhorario.SetError(dgvControlHorario, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtHorastrabajada.Text == "" || txtNIT.Text == "" || cboEmpleados.Text == "" || cboTiempoTarea.Text == "")
            {
                errorControlhorario.SetError(txtHorastrabajada, "Los campos estan vacios.");
                errorControlhorario.SetError(txtNIT, "Los campos estan vacios.");
                errorControlhorario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay registros de empleados en el programa, solicite a un administrador que registre empleados al programa.");
                errorControlhorario.SetError(cboTiempoTarea, "Los campos estan vacios esto significa que no hay registros de tiempo por tarea en el programa, apriete el boton tiempo por tarea e ingrese registros de tiempo por tarea.");
            }
            else
            {


                int id = int.Parse(dgvControlHorario.CurrentRow.Cells[0].Value.ToString());
                control con = new control();
                con.dia = (int)cboDia.SelectedValue;
                con.entrada = dtpEntrada.Text;
                con.salida = dtpSalida.Text;
                con.inicio = dtpInicio.Text;
                con.finalizacion = dtpAcabo.Text;
                con.horas = txtHorastrabajada.Text;
                con.NIT = txtNIT.Text;
                con.Fecha = dtpFecha.Text;
                con.empleados = (int)cboEmpleados.SelectedValue;
                con.tiempotarea = (int)cboTiempoTarea.SelectedValue;
                con.idControl = id;

                if (con.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorControlhorario.SetError(dgvControlHorario, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }
        public void MostrarDatos()
        {
            control con = new control();
            try
            {
                dgvControlHorario.DataSource = con.MostrarControl();
            }
            catch
            {
                errorControlhorario.SetError(dgvControlHorario, "Error en la conexión con la base de datos");
            }
        }
        private void btnTiempoTarea_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TiempoPorTarea());
        }

        private void ControlHorario_Load(object sender, EventArgs e)
        {
            control c = new control(); 
            cboDia.DataSource = c.Dias();
            cboDia.DisplayMember = "dia";
            cboDia.ValueMember = "id_dia";

            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            cboTiempoTarea.DataSource = c.Tiempoportarea();
            cboTiempoTarea.DisplayMember = "tarea";
            cboTiempoTarea.ValueMember = "id_tiempotarea";
            dgvControlHorario.Columns[0].Visible = false;
        }

        private void dgvControlHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboDia.Text = dgvControlHorario.CurrentRow.Cells[1].Value.ToString();
            //dtpEntrada.Text = dgvControlHorario.CurrentRow.Cells[2].Value.ToString();
            //dtpSalida.Text = dgvControlHorario.CurrentRow.Cells[3].Value.ToString();
            //dtpInicio.Text = dgvControlHorario.CurrentRow.Cells[4].Value.ToString();
            //dtpAcabo.Text = dgvControlHorario.CurrentRow.Cells[5].Value.ToString();
            //txtHorastrabajada.Text = dgvControlHorario.CurrentRow.Cells[6].Value.ToString();
            //txtNIT.Text = dgvControlHorario.CurrentRow.Cells[7].Value.ToString();
            //dtpFecha.Text = dgvControlHorario.CurrentRow.Cells[8].Value.ToString();
            //cboEmpleados.Text = dgvControlHorario.CurrentRow.Cells[9].Value.ToString();
            //cboTiempoTarea.Text = dgvControlHorario.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
