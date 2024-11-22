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
    public partial class FuncionesARealizar : Form
    {
        public FuncionesARealizar()
        {
            InitializeComponent();
        }
        public void MostrarDatos()
        {
            FuncionaRealizar FNC = new FuncionaRealizar();
            try
            {
                dgvFunciones.DataSource = FNC.MostrarFunciones();
                dgvFunciones.Columns[0].Visible = false;
            }
            catch
            {
                errorFunciones.SetError(dgvFunciones, "Error en la conexión con la base de datos");
            }
        }
        private void FuncionesARealizar_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtFuncion.Text == "")
            {
                errorFunciones.SetError(txtFuncion, "Los campos estan vacios");
            }
            else
            {
                try
                {
                    int id = int.Parse(dgvFunciones.CurrentRow.Cells[0].Value.ToString());
                    string funcion = txtFuncion.Text;

                    FuncionaRealizar FNC = new FuncionaRealizar(id, funcion);
                    if (FNC.Actualizar())
                    {
                        txtFuncion.Clear();
                        MostrarDatos();
                    }
                    else
                    {
                        //  MessageBox.Show("Hubo un error, debe seleccionar una fila para actualizar o debe poner el numero del id del empleado, si desea cambiarlo de departamento.", "Alerta de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorFunciones.SetError(btnActualizar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FuncionaRealizar fnc = new FuncionaRealizar(txtFuncion.Text);
            if (txtFuncion.Text == "")
            {
               errorFunciones.SetError(txtFuncion, "Los campos estan vacios");
           }
            else
            {
                if (fnc.Agregar() == true)
                {
                    MostrarDatos();
                    txtFuncion.Clear();
                }
                else
                {
                    errorFunciones.SetError(btnAgregar, "Hubo un error en el traspaso de información");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvFunciones.CurrentRow.Cells[0].Value.ToString());
                FuncionaRealizar cal = new FuncionaRealizar(id);
                if (cal.Eliminar())
                {
                    txtFuncion.Clear();
                    MostrarDatos();
                }
                else
                {
                    //  MessageBox.Show("Error al eliminar en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorFunciones.SetError(btnEliminar, "Error al eliminar en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFuncion.Text = dgvFunciones.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
