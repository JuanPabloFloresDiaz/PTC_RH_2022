﻿using System;
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
    public partial class OtrasFunciones : Form
    {
        public OtrasFunciones()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            this.PanelDivisor.Visible = false;
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormContratacionEmpleado());
        }

        private void btnFuncionesEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FuncionesEmpleados());
        }

        private void OtrasFunciones_Load(object sender, EventArgs e)
        {
            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                PanelDivisor.BackColor = TemaColores.PanelContenedor;
            }
        }
    }
}
