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
    public partial class PermisosAdmin : Form
    {
        public PermisosAdmin()
        {
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            Permisos per = new Permisos();
            try
            {
                dgvPermisos.DataSource = per.MostrarPermisos();
            }
            catch
            {
                errorPermisos.SetError(dgvPermisos, "Error en la conexión con la base de datos");
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {        
                try
                {
                    int id = int.Parse(dgvPermisos.CurrentRow.Cells[0].Value.ToString());
                    int estatus = (int)cboEstatus.SelectedValue;
                    Permisos CAL = new Permisos(id, estatus);
                    if (CAL.ActualizarEstatus())
                    {                       
                        MostrarDatos();
                    }
                    else
                    {
                        errorPermisos.SetError(btnConfirmar, "Hubo un error en el traspaso de información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }            
        }

        private void PermisosAdmin_Load(object sender, EventArgs e)
        {
            dgvPermisos.Columns[0].Visible = false;
            Permisos c = new Permisos();
            cboEstatus.DataSource = c.Estatus();
            cboEstatus.DisplayMember = "estatu";
            cboEstatus.ValueMember = "idEstatus";
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboEstatus.Text = dgvPermisos.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
