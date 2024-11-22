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
    public partial class CalendarioTrabajo : Form
    {
        public CalendarioTrabajo()
        {
            InitializeComponent();
            MostrarDatos();
            //string dia = dtpFecha.Value.DayOfWeek.ToString();
            //if (dia == "Sunday")
            //{
            //    cboDia.Text = "Domingo";
            //    cboDia.SelectedValue = 6;
            //}
            //else if (dia == "Monday")
            //{
            //    cboDia.Text = "Lunes";
            //    cboDia.SelectedValue = 0;
            //}
            //else if (dia == "Tuesday")
            //{
            //    cboDia.Text = "Martes";
            //    cboDia.SelectedValue = 1;
            //}
            //else if (dia == "Wednesday")
            //{
            //    cboDia.Text = "Miercoles";
            //    cboDia.SelectedValue = 2;
            //}
            //else if (dia == "Thursday")
            //{
            //    cboDia.Text = "Jueves";
            //    cboDia.SelectedValue = 3;
            //}
            //else if (dia == "Friday")
            //{
            //    cboDia.Text = "Viernes";
            //    cboDia.SelectedValue = 4;
            //}
            //else if (dia == "Saturday")
            //{
            //    cboDia.Text = "Sabado";
            //    cboDia.SelectedValue = 5;
            //}
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelObjetos.Controls.Count > 0)
                this.panelObjetos.Controls.RemoveAt(0);
            this.panelDivisor.Visible = false;
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelObjetos.Controls.Add(fh);
            this.panelObjetos.Tag = fh;
            fh.Show();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboFunciones.Text == "" || txtHora.Text == "" || cboEmpleados.Text == "")
            {
                errorCalendario.SetError(cboFunciones, "Los campos estan vacios, esto significa que no hay funciones por realizar ingresadas, se le recomienda hacer click al boton de funciones a realizar e ingresar las funciones por realizar.");
                errorCalendario.SetError(txtHora, "Los campos estan vacios");
                errorCalendario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay empleados registrados, se le recomienda ingresar empleados por medio del formulario de registro de empleados");
            }
            else
            {
                Calendario hor = new Calendario(dtpFecha.Text, txtHora.Text, (int)cboDia.SelectedValue, (int)cboFunciones.SelectedValue, (int)cboEmpleados.SelectedValue);
                if (hor.Agregar() == true)
                {
                    MostrarDatos();
                    txtHora.Clear();
                }
                else
                {
                    errorCalendario.SetError(btnAgregar, "Hubo un error en el traspaso de información");
                }
            }
        }

        public void MostrarDatos()
        {
            Calendario cal = new Calendario();
            try
            {
                dgvCalendario.DataSource = cal.MostrarCalendario();
            }
            catch
            {
                errorCalendario.SetError(dgvCalendario, "Error en la conexión con la base de datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvCalendario.CurrentRow.Cells[0].Value.ToString());
                Calendario cal = new Calendario(id);
                if (cal.Eliminar())
                {
                    txtHora.Clear();
                    MostrarDatos();
                }
                else
                {
                  //  MessageBox.Show("Error al eliminar en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorCalendario.SetError(btnEliminar, "Error al eliminar en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboFunciones.Text == "" || txtHora.Text == "" || cboEmpleados.Text == "")
            {
                errorCalendario.SetError(cboFunciones, "Los campos estan vacios, esto significa que no hay funciones por realizar ingresadas, se le recomienda hacer click al boton de funciones a realizar e ingresar las funciones por realizar.");
                errorCalendario.SetError(txtHora, "Los campos estan vacios");
                errorCalendario.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay empleados registrados, se le recomienda ingresar empleados por medio del formulario de registro de empleados");
            }
            else
            {
                try
                {
                    int id = int.Parse(dgvCalendario.CurrentRow.Cells[0].Value.ToString());
                    string Fecha = dtpFecha.Text;
                    string Hora = txtHora.Text;
                    int dia = (int)cboDia.SelectedValue;
                    int funcion = (int)cboFunciones.SelectedValue;
                    int empleados = (int)cboEmpleados.SelectedValue;

                    Calendario CAL = new Calendario(id, Fecha, Hora, dia, funcion, empleados);
                    if (CAL.Actualizar())
                    {
                        txtHora.Clear();
                        MostrarDatos();
                    }
                    else
                    {
                        //  MessageBox.Show("Hubo un error, debe seleccionar una fila para actualizar o debe poner el numero del id del empleado, si desea cambiarlo de departamento.", "Alerta de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorCalendario.SetError(btnActualizar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCalendario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha.Text = dgvCalendario.CurrentRow.Cells[1].Value.ToString();
            txtHora.Text = dgvCalendario.CurrentRow.Cells[2].Value.ToString();
            cboDia.Text = dgvCalendario.CurrentRow.Cells[3].Value.ToString();
            cboFunciones.Text = dgvCalendario.CurrentRow.Cells[4].Value.ToString();
            cboEmpleados.Text = dgvCalendario.CurrentRow.Cells[5].Value.ToString();
        }

        private void CalendarioTrabajo_Load(object sender, EventArgs e)
        {
            Calendario c = new Calendario();
            cboDia.DataSource = c.Dias();
            cboDia.DisplayMember = "dia";
            cboDia.ValueMember = "id_dia";

            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";

            cboFunciones.DataSource = c.Funciones();
            cboFunciones.DisplayMember = "funcionarealizar";
            cboFunciones.ValueMember = "idfuncion";

            dgvCalendario.Columns["id"].Visible = false;
            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;               
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;             
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;              
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;             
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;           
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;              
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelDivisor.BackColor = TemaColores.PanelContenedor;
                lblFecha.ForeColor = TemaColores.letra;
                lblDia.ForeColor = TemaColores.letra;
                lblFuncion.ForeColor = TemaColores.letra;
                lblHora.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;              
            }
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FuncionesARealizar());
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
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
            //Verifica que pueda ingresar punto y tambien que solo pueda ingresar un punto
            else if ((e.KeyChar == '.') && (!txtHora.Text.Contains(":")))
            {
                e.Handled = false;
            }
            //Si no cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                errorCalendario.SetError(txtHora, "Solo se admiten numeros");
            }
        }

        private void cboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string dia = dtpFecha.Value.DayOfWeek.ToString();
            //if (dia == "Sunday")
            //{
            //    cboDia.DisplayMember = "Domingo";
            //    cboDia.ValueMember = "6";
            //}
            //else if (dia == "Monday")
            //{
            //    cboDia.DisplayMember = "Lunes";
            //    cboDia.ValueMember = "0";
            //}
            //else if (dia == "Tuesday")
            //{
            //    cboDia.DisplayMember = "Martes";
            //    cboDia.ValueMember = "1";
            //}
            //else if (dia == "Wednesday")
            //{
            //    cboDia.DisplayMember = "Miercoles";
            //    cboDia.ValueMember = "2";
            //}
            //else if (dia == "Thursday")
            //{
            //    cboDia.DisplayMember = "Jueves";
            //    cboDia.ValueMember = "3";
            //}
            //else if (dia == "Friday")
            //{
            //    cboDia.DisplayMember = "Viernes";
            //    cboDia.ValueMember = "4";
            //}
            //else if (dia == "Saturday")
            //{
            //    cboDia.DisplayMember = "Sabado";
            //    cboDia.ValueMember = "5";
            //}
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
