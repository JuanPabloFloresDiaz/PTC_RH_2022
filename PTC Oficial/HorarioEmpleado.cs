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
    public partial class HorarioEmpleado : Form
    {
        public HorarioEmpleado()
        {
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            Horario hor = new Horario();
            try
            {
                dgvHorario.DataSource = hor.MostrarHorario();
            }
            catch
            {
                //  MessageBox.Show(ex.Message + "Error en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorHorario.SetError(dgvHorario, "Error en la conexión con la base de datos");
            }
        }

        private void HorarioEmpleado_Load(object sender, EventArgs e)
        {
          dgvHorario.Columns[0].Visible = false;
        }
    }
}
