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
    public partial class FormContratacionEmpleado : Form
    {
        public FormContratacionEmpleado()
        {
            InitializeComponent();
        }

        public FormContratacionEmpleado(string nombre)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
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
        private void btnTabla_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new DGVContratos());
            //DGVContratos ventanaDGVContratos = new DGVContratos();
            //ventanaDGVContratos.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados(dtpIngreso.Text, txtNombre.Text,dtpNacimiento.Text, txtDireccion.Text, (int)cboArea.SelectedValue, (int)cboGenero.SelectedValue, (int)cboUsuario.SelectedValue);
            if (txtNombre.Text == "" || txtDireccion.Text == "")
            {
                errorContratos.SetError(txtNombre, "Los campos estan vacios");
                errorContratos.SetError(txtDireccion, "Los campos estan vacios");               
            }
            else
            {
                if (emp.Agregar() == true)
                {
                    txtNombre.Clear();
                    txtDireccion.Clear();
                }
                else
                {
                    errorContratos.SetError(btnIngresar, "Hubo un error en el traspaso de información");
                }
            }
        }

        private void PanelDivisor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDashboard2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void FormContratacionEmpleado_Load(object sender, EventArgs e)
        {
            Empleados em = new Empleados();
            cboArea.DataSource = em.Areas();
            cboArea.DisplayMember = "area_trabajo";
            cboArea.ValueMember = "idArea";

            cboGenero.DataSource = em.Generos();
            cboGenero.DisplayMember = "tipogenero";
            cboGenero.ValueMember = "id_genero";

            cboUsuario.DataSource = em.Usuarios();
            cboUsuario.DisplayMember = "nombreUsuario";
            cboUsuario.ValueMember = "id_Usuario";
        }
       
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            DGVContratos dgv = new DGVContratos();
            if (txtNombre.Text == "" || txtDireccion.Text == "")
            {
                errorContratos.SetError(txtNombre, "Los campos estan vacios");
                errorContratos.SetError(txtDireccion, "Los campos estan vacios");
            }
            else
            {
                try
                {
                    
                    int id = int.Parse(dgv.dgvEmpleados.CurrentRow.Cells[0].Value.ToString()); ; 
                    string Ingreso = dtpNacimiento.Text;
                    string Nombres = txtNombre.Text;
                    string Nacimiento = dtpNacimiento.Text;
                    string Direccion = txtDireccion.Text;
                    int Area = (int)cboArea.SelectedValue;
                    int Genero = (int)cboGenero.SelectedValue;
                    int Usuario = (int)cboUsuario.SelectedValue;

                    Empleados emp = new Empleados(id, Ingreso, Nombres, Nacimiento, Direccion, Area, Genero, Usuario);
                    if (emp.Actualizar())
                    {
                        txtNombre.Clear();
                        txtDireccion.Clear();
                    }
                    else
                    {
                        errorContratos.SetError(btnIngresar, "Hubo un error en el traspaso de información");
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
                DGVContratos dgv = new DGVContratos();
                int id = int.Parse(dgv.dgvEmpleados.CurrentRow.Cells[0].Value.ToString()); 
                Empleados emp = new Empleados(id);
                if (emp.Eliminar())
                {
                    txtNombre.Clear();
                    txtDireccion.Clear();
                }
                else
                {
                    //  MessageBox.Show("Error al eliminar en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorContratos.SetError(btnElminar, "Error al eliminar en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorContratos.SetError(txtNombre,"Solo se admiten letras");
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
           
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else if ((e.KeyChar == ',') && (!txtDireccion.Text.Contains(":")))
            {
                e.Handled = false;
            }

            else if ((e.KeyChar == '#'))
            {
                e.Handled = false;
            }
            //Si no cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                errorContratos.SetError(txtNombre, "Solo se admiten letras, numeros,comas y hashtags...");
            }
        }
    }
}
