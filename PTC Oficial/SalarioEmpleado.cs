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
    public partial class SalarioEmpleado : Form
    {
        public SalarioEmpleado()
        {
            InitializeComponent();
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            Salario sal = new Salario();
            try
            {
               dgvSalario.DataSource = sal.MostrarSalario();
            }
           catch
           {
               // MessageBox.Show(ex.Message + "Error en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               errorSalario.SetError(dgvSalario, "Error en la conexión con la base de datos");
           }
        }

        private void SalarioEmpleado_Load(object sender, EventArgs e)
        {
            dgvSalario.Columns[0].Visible = false;
        }
    }
}
