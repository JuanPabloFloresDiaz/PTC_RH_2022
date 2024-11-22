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
    public partial class TiempoPorTarea : Form
    {
        public TiempoPorTarea()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtSubtarea.Text == "" || txtTarea.Text == "")
            {
                errorTiempo.SetError(txtDescripcion, "Los campos estan vacios.");
                errorTiempo.SetError(txtTarea, "Los campos estan vacios.");
                errorTiempo.SetError(txtSubtarea, "Los campos estan vacios.");
            }
            else
            {
                tiempotarea tar = new tiempotarea();
                tar.tarea = txtTarea.Text;
                tar.descripcion = txtDescripcion.Text;
                tar.subtarea = txtSubtarea.Text;
                tar.Fecha = dtpFecha.Text;
                tar.Horainicio = dtpInicio.Text;
                tar.Horafinal = dtpFinal.Text;
                if (tar.Agregar() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorTiempo.SetError(dgvTiempotarea, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
                }
            }
        }
        private void MostrarDatos()
        {
            tiempotarea s = new tiempotarea();
            dgvTiempotarea.DataSource = s.MostrarTiempoTarea();

            dgvTiempotarea.Columns[0].Visible = false;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvTiempotarea.CurrentRow.Cells[0].Value.ToString());
                tiempotarea tar = new tiempotarea();
                tar.idTiempo = id;
                if (tar.Eliminar())
                {
                     MostrarDatos();
                }
                else
                {
                    errorTiempo.SetError(dgvTiempotarea, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtSubtarea.Text == "" || txtTarea.Text == "")
            {
                errorTiempo.SetError(txtDescripcion, "Los campos estan vacios.");
                errorTiempo.SetError(txtTarea, "Los campos estan vacios.");
                errorTiempo.SetError(txtSubtarea, "Los campos estan vacios.");
            }
            else
            {

                int id = int.Parse(dgvTiempotarea.CurrentRow.Cells[0].Value.ToString());
                tiempotarea tar = new tiempotarea();
                tar.tarea = txtTarea.Text;
                tar.descripcion = txtDescripcion.Text;
                tar.subtarea = txtSubtarea.Text;
                tar.Fecha = dtpFecha.Text;
                tar.Horainicio = dtpInicio.Text;
                tar.Horafinal = dtpFinal.Text;
                tar.idTiempo = id;

                if (tar.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorTiempo.SetError(dgvTiempotarea, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }
    }
}
