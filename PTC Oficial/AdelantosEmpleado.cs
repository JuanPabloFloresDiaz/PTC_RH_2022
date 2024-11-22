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
    public partial class AdelantosEmpleado : Form
    {
        public AdelantosEmpleado()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "" || txtJustificacion.Text == "" )
            {
                errorAdelantos.SetError(cboEmpleados, "Los campos estan vacios, muy posiblemente no se han ingresado sus datos de empleado al programa, solicite a un administrador que le ingrese sus datos.");
                errorAdelantos.SetError(txtJustificacion, "Los campos estan vacios");
            }
            else
            {
                Adelantos adl = new Adelantos((int)cboDia.SelectedValue, dtpHora.Text, dtpFecha.Text, (int)cboEmpleados.SelectedValue, txtJustificacion.Text);
                if (adl.Agregar() == true)
                {
                    MostrarDatos();
                    txtJustificacion.Clear();

                }
                else
                {
                    errorAdelantos.SetError(btnAgregar, "Hubo un error en el traspaso de información");
                }
            }
        }
        public void MostrarDatos()
        {
            Adelantos adl = new Adelantos();
            try
            {
                dgvAdelantos.DataSource = adl.MostrarAdelantos();
            }
            catch
            {
                errorAdelantos.SetError(dgvAdelantos, "Error en la conexión con la base de datos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvAdelantos.CurrentRow.Cells[0].Value.ToString());
                Adelantos cal = new Adelantos(id);
                if (cal.Eliminar())
                {
                   txtJustificacion.Clear();
                    MostrarDatos();
                }
                else
                {
                    errorAdelantos.SetError(btnEliminar, "Error al eliminar en la conexión con la base de datos");
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
                errorAdelantos.SetError(cboEmpleados, "Los campos estan vacios, muy posiblemente no se han ingresado sus datos de empleado al programa, solicite a un administrador que le ingrese sus datos.");
                errorAdelantos.SetError(txtJustificacion, "Los campos estan vacios");
            }
            else
            {
                try
                {
                    int id = int.Parse(dgvAdelantos.CurrentRow.Cells[0].Value.ToString());
                    int Dia = (int)cboDia.SelectedValue;
                    string Hora = dtpHora.Text;
                    string Fecha = dtpFecha.Text;
                    int Empleado = (int)cboEmpleados.SelectedValue;
                    string Justificacion = txtJustificacion.Text;

                    Adelantos CAL = new Adelantos(id,Dia,Hora,Fecha,Empleado,Justificacion);
                    if (CAL.Actualizar())
                    {
                       
                        txtJustificacion.Clear();
                        MostrarDatos();
                    }
                    else
                    {
                       errorAdelantos.SetError(btnActualizar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvAdelantos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboDia.Text = dgvAdelantos.CurrentRow.Cells[1].Value.ToString();
            dtpHora.Text = dgvAdelantos.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Text = dgvAdelantos.CurrentRow.Cells[3].Value.ToString();
            cboEmpleados.Text = dgvAdelantos.CurrentRow.Cells[4].Value.ToString();
            txtJustificacion.Text = dgvAdelantos.CurrentRow.Cells[5].Value.ToString();
        }

        private void AdelantosEmpleado_Load(object sender, EventArgs e)
        {
            dgvAdelantos.Columns[0].Visible = false;
            Adelantos c = new Adelantos();
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
