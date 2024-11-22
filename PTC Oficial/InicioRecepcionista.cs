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
    public partial class InicioRecepcionista : Form
    {
        public InicioRecepcionista()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="" || txtTelefono.Text=="")
            {
                errorReportes.SetError(txtNombre,"Error los campos estan vacios");
                errorReportes.SetError(txtTelefono,"Error los campos estan vacios");
            }
               
            else 
            {
                ReportLLT f = new ReportLLT(txtNombre.Text, txtTelefono.Text);
                AbrirFormEnPanel(f);
            }
            
        }
    }
}
