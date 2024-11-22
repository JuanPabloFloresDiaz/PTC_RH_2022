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
    public partial class LlegadasTarde : Form
    {
        public LlegadasTarde()
        {
            InitializeComponent();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEmpleados.Text == "")
            {
                errorLlegadasTarde.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay ningun dato de algun empleados registrados, se le recomienda comunicarse con un administrador, para que este ingrese datos de empleados.");
            }
            else
            {
                Tarde tar = new Tarde();
                tar.Fecha = dtpFecha.Text;
                tar.Hora = dtpHora.Text;
                tar.Texto = txtJustificacion.Text;
                tar.Empleado = (int)cboEmpleados.SelectedValue;
                if (tar.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorLlegadasTarde.SetError(dgvLlegadasTarde, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvLlegadasTarde.CurrentRow.Cells[0].Value.ToString());
                Tarde sal = new Tarde();
                sal.idLlegadasTarde = id;
                if (sal.Eliminar())
                {
                   
                    MostrarDatos();
                }
                else
                {
                    errorLlegadasTarde.SetError(dgvLlegadasTarde, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarDatos()
        {
            Tarde s = new Tarde();
            dgvLlegadasTarde.DataSource = s.MostrarLlegadasTarde();
        }
        private void LlegadasTarde_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Tarde c = new Tarde();
            cboEmpleados.DataSource = c.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
            dgvLlegadasTarde.Columns[0].Visible = false;
        }

        private void dgvLlegadasTarde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFecha.Text = dgvLlegadasTarde.CurrentRow.Cells[1].Value.ToString();
            dtpHora.Text = dgvLlegadasTarde.CurrentRow.Cells[2].Value.ToString();
            txtJustificacion.Text = dgvLlegadasTarde.CurrentRow.Cells[3].Value.ToString();
            cboEmpleados.Text = dgvLlegadasTarde.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
