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
    public partial class FuncionesEmpleados : Form
    {
        public FuncionesEmpleados()
        {
            InitializeComponent();
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

        private void btnCrearHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new HorarioAdmin());
        }

        private void btnCrearSalarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new SalarioAdmin());
        }

        private void btnPERMISOSEMPLEADOS_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PermisosAdmin());
        }

        private void btnAdelantosEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AdelantosAdmin());
        }
    }
}
