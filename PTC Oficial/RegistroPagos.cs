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
    public partial class RegistroPagos : Form
    {
        public RegistroPagos()
        {
            InitializeComponent();
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            Pagos pago = new Pagos();
            try
            {
                dgvRegistroPago.DataSource = pago.Mostrar();
            }
            catch
            {
                //  MessageBox.Show(ex.Message + "Error en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorPago.SetError(dgvRegistroPago, "Error en la conexión con la base de datos");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboEmpleados.Text == "")
            {
                errorPago.SetError(cboEmpleados, "Los campos estan vacios, esto significa que no hay empleados registrados, se le recomienda ingresar empleados por medio del formulario de registro de empleados");
            }
            else
            {


                Pagos pago = new Pagos(dtpFechapago.Text, dtpFechavencimiento.Text, (int)cboFormadepago.SelectedValue, (int)cboEmpleados.SelectedValue);
                if (pago.Agregar() == true)
                {
                    //  MessageBox.Show("Usuario agregado exitosamente", " Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();

                }
                else
                {
                    //  MessageBox.Show("Hubo un error en el traspaso de información...", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorPago.SetError(btnAgregar, "Hubo un error en el traspaso de información...");
                }
            }
        }
        
        private void RegistroPagos_Load(object sender, EventArgs e)
        {
            Pagos reg = new Pagos();
            cboFormadepago.DataSource = reg.formaPago();
            cboFormadepago.DisplayMember = "tipoForma_pago";
            cboFormadepago.ValueMember = "id_formaPago";

            cboEmpleados.DataSource = reg.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
            dgvRegistroPago.Columns["id"].Visible = false;


            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelContenedor.BackColor = TemaColores.PanelContenedor;
                panelSubcontenedor.BackColor = TemaColores.PanelContenedor;
                lblTitulo.ForeColor = TemaColores.letra;
                lblForma.ForeColor = TemaColores.letra;
                lblFecha.ForeColor = TemaColores.letra;
                lblFechavencimiento.ForeColor = TemaColores.letra;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvRegistroPago.CurrentRow.Cells[0].Value.ToString());
                Pagos pago = new Pagos(id);
                if (pago.Eliminar())
                {
                    //    MessageBox.Show("El usuario a sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar en la conexion con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorPago.SetError(btnEliminar, "Error al eliminar en la conexion con la base de datos");
                }
            }
            catch
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvRegistroPago.CurrentRow.Cells[0].Value.ToString());

                string FechaPago = dtpFechapago.Text;
                string FechaVencimiento = dtpFechavencimiento.Text;
                int idTipoFormaPago = (int)cboFormadepago.SelectedValue;
                int empleados = (int)cboEmpleados.SelectedValue;

                Pagos Pago = new Pagos(id, FechaPago, FechaVencimiento, idTipoFormaPago,empleados);
                if (Pago.Actualizar())
                {
                    //    MessageBox.Show("Departamento actualizado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                }
                else
                {
                    errorPago.SetError(btnActualizar, "Hubo un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRegistroPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpFechapago.Text = dgvRegistroPago.CurrentRow.Cells[1].Value.ToString();
            dtpFechavencimiento.Text = dgvRegistroPago.CurrentRow.Cells[2].Value.ToString();
            cboFormadepago.Text = dgvRegistroPago.CurrentRow.Cells[3].Value.ToString();
            cboEmpleados.Text = dgvRegistroPago.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
