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
    public partial class DGVContratos : Form
    {
        public DGVContratos()
        {
            InitializeComponent();
            MostrarDatos();
            dgvEmpleados.Columns["id"].Visible = false;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            this.panelObjetos.Visible = false;
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        public void MostrarDatos()
        {
            DatosUsuarios emp = new DatosUsuarios();
            try
            {
                dgvEmpleados.DataSource = emp.MostrarDatosContratacion();
            }
            catch
            {
                errorDatosRegistrados.SetError(dgvEmpleados, "Error en la conexión con la base de datos");
            }
        }

        private void DGVContratos_Load(object sender, EventArgs e)
        {
            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
            }
        }
       
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormContratacionEmpleado EmpleadosContratados = new FormContratacionEmpleado();
            EmpleadosContratados.dtpIngreso.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            EmpleadosContratados.txtNombre.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            EmpleadosContratados.dtpNacimiento.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            EmpleadosContratados.txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            EmpleadosContratados.cboArea.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            EmpleadosContratados.cboGenero.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            EmpleadosContratados.cboUsuario.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            //EmpleadosContratados.btnActualizar.Enabled = true;
            //EmpleadosContratados.Show();
            //txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormContratacionEmpleado());
            //this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            //Lo active por error
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
               
                errorDatosRegistrados.SetError(txtDireccion, "Los campos estan vacios");
            }
            else
            {
                try
                {

                    int id = int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString()); ;
                    string Direccion = txtDireccion.Text;

                    Empleados emp = new Empleados(id, Direccion);
                    if (emp.ActualizarF())
                    {
                        MostrarDatos();
                        txtDireccion.Clear();
                    }
                    else
                    {
                        errorDatosRegistrados.SetError(btnActualizar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            try
            {               
                int id = int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
                Empleados emp = new Empleados(id);
                if (emp.Eliminar())
                {
                    MostrarDatos();
                    txtDireccion.Clear();
                }
                else
                {
                    //  MessageBox.Show("Error al eliminar en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorDatosRegistrados.SetError(btnElminar, "Error al eliminar en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            //Lo abri por error
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {
            //Lo abri por error
        }
    }
}
