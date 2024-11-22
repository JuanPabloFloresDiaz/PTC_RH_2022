using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PTC_Oficial
{
    public partial class ReportLLT : Form
    {
        string Nombre, Telefono;

        private void ReportLLT_Load(object sender, EventArgs e)
        {
            reportViewerlLlegadatarde.LocalReport.DataSources.Clear();
            Tarde t = new Tarde();
            DataTable dt = t.LeerLlegadasTarde();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            //Crear parametros
            ReportParameter parameterNombre = new ReportParameter("nom", Nombre);
            ReportParameter parameterTelefono = new ReportParameter("tel", Telefono);
            //Asignar parametros
            reportViewerlLlegadatarde.LocalReport.SetParameters(parameterNombre);
            reportViewerlLlegadatarde.LocalReport.SetParameters(parameterTelefono);

            reportViewerlLlegadatarde.LocalReport.DataSources.Add(rp);
            reportViewerlLlegadatarde.RefreshReport();
        }

        public ReportLLT(string nombre, string telefono)
        {
            InitializeComponent();
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
