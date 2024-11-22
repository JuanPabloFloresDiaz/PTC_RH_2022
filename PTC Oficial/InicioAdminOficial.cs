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
    public partial class InicioAdminOficial : Form
    {
        public InicioAdminOficial()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelCons.Controls.Count > 0)
                this.panelCons.Controls.RemoveAt(0);
            this.panelObjetos.Visible = false;
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCons.Controls.Add(fh);
            this.panelCons.Tag = fh;
            fh.Show();
        }
        private void InicioAdminOficial_Load(object sender, EventArgs e)
        {
            if(Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
               
                lblFechanacimiento.ForeColor = TemaColores.letra;
              
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if(Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
             
                lblFechanacimiento.ForeColor = TemaColores.letra;
            
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
           
                lblFechanacimiento.ForeColor = TemaColores.letra;
         
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
            
                lblFechanacimiento.ForeColor = TemaColores.letra;
           
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
               
                lblFechanacimiento.ForeColor = TemaColores.letra;

                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
            
                lblFechanacimiento.ForeColor = TemaColores.letra;
           
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelCons.BackColor = TemaColores.PanelContenedor;
                panelObjetos.BackColor = TemaColores.PanelContenedor;
                panelCampos.BackColor = TemaColores.PanelContenedor;
                btnActaadministrativa.BackColor = TemaColores.botones2;
                btnContratosEmpleados.BackColor = TemaColores.botones2;
                btnBaja.BackColor = TemaColores.botones2;
                btnGestion.BackColor = TemaColores.botones2;
                btnReconocimientos.BackColor = TemaColores.botones2;
                btnCumpli.BackColor = TemaColores.botones2;
                btnNom.BackColor = TemaColores.botones2;
                btnSancion.BackColor = TemaColores.botones2;
             
                lblFechanacimiento.ForeColor = TemaColores.letra;
              
                btnActaadministrativa.ForeColor = TemaColores.letra;
                btnContratosEmpleados.ForeColor = TemaColores.letra;
                btnBaja.ForeColor = TemaColores.letra;
                btnGestion.ForeColor = TemaColores.letra;
                btnReconocimientos.ForeColor = TemaColores.letra;
                btnCumpli.ForeColor = TemaColores.letra;
                btnNom.ForeColor = TemaColores.letra;
                btnSancion.ForeColor = TemaColores.letra;
            }
        }

        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCumpli_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CumplimientoEmpleados());
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new GestionVacaciones());
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BajasLaborales());
        }

        private void btnReconocimientos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reconocimientos());
        }

        private void btnContratosEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Contrato());
        }

        private void btnSancion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Sanciones());
        }

        private void btnActaadministrativa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ActasAdministrativas());
        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Nomina());
        }
    }
}
