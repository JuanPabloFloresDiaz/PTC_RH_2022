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
    public partial class AdelantosAdmin : Form
    {
        public AdelantosAdmin()
        {
            InitializeComponent();
            MostrarDatos();
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
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvAdelantos.CurrentRow.Cells[0].Value.ToString());
                int Estatus = (int)cboEstatus.SelectedValue;
                Adelantos CAL = new Adelantos(id, Estatus);
                if (CAL.ActualizarEstatus())
                {
                    MostrarDatos();
                }
                else
                {
                    errorAdelantos.SetError(btnConfirmar, "Hubo un error en el traspaso de información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdelantosAdmin_Load(object sender, EventArgs e)
        {
            dgvAdelantos.Columns[0].Visible = false;
            Adelantos c = new Adelantos();
            cboEstatus.DataSource = c.Estatus();
            cboEstatus.DisplayMember = "estatu";
            cboEstatus.ValueMember = "idEstatus";
        }

        private void dgvAdelantos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboEstatus.Text = dgvAdelantos.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
