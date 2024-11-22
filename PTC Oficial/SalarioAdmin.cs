using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace PTC_Oficial
{
    public partial class SalarioAdmin : Form
    {
        public SalarioAdmin()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtHorasextra.Text == "" || txtSalarioBruto.Text == "" || txtSalarioNeto.Text == "" || cboPago.Text == "")
            {
                errorSalario.SetError(txtSalarioBruto, "Los campos estan vacios");
                errorSalario.SetError(txtHorasextra, "Los campos estan vacios");
                errorSalario.SetError(txtSalarioNeto, "Los campos estan vacios");
                errorSalario.SetError(cboPago, "Los campos estan vacios, esto significa que no hay ningun registro de pago, se le recomienda ir al formulario de registro de pagos y guardar un registro.");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pcbCotizaciones.Image.Save(ms, ImageFormat.Png);
                byte[] abyte = ms.ToArray();
                int id = int.Parse(dgvSalario.CurrentRow.Cells[0].Value.ToString());

                Salario sal = new Salario();
                sal.Salariobruto = txtSalarioBruto.Text;
                sal.Cotizaciones = abyte;
                sal.Salarioneto = txtSalarioNeto.Text;
                sal.horasextra = txtHorasextra.Text;
                sal.RegistroPago = (int)cboPago.SelectedValue;
                sal.descuento = (int)cboDescuento.SelectedValue;
                sal.idSalario = id;

                if (sal.Update() == true)
                {
                    MostrarDatos();
                }
                else
                {
                    errorSalario.SetError(dgvSalario, "Error en la conexión con la base de datos, no se puede actualizar el registro...");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvSalario.CurrentRow.Cells[0].Value.ToString());
                Salario sal = new Salario();
                sal.idSalario = id;
                if (sal.Eliminar())
                {
                    txtHorasextra.Clear();
                    txtSalarioBruto.Clear();
                    txtSalarioNeto.Clear();
                    pcbCotizaciones.Image = null;
                    MostrarDatos();
                }
                else
                {
                    errorSalario.SetError(dgvSalario, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtHorasextra.Text == "" || txtSalarioBruto.Text == "" || txtSalarioNeto.Text == "" || cboPago.Text == "" || pcbCotizaciones.Image == null)
            {
                errorSalario.SetError(txtSalarioBruto, "Los campos estan vacios");
                errorSalario.SetError(txtHorasextra, "Los campos estan vacios");
                errorSalario.SetError(txtSalarioNeto, "Los campos estan vacios");
                errorSalario.SetError(cboPago, "Los campos estan vacios, esto significa que no hay ningun registro de pago, se le recomienda ir al formulario de registro de pagos y guardar un registro.");
                errorSalario.SetError(pcbCotizaciones, "No se a elegido ninguna imagen...");
            }
            else
            {         
                MemoryStream ms = new MemoryStream();       
                pcbCotizaciones.Image.Save(ms, ImageFormat.Png);      
                byte[] aByte = ms.ToArray();      
                Salario sal = new Salario();       
                sal.Salariobruto = txtSalarioBruto.Text;
                sal.Cotizaciones = aByte;         
                sal.Salarioneto = txtSalarioNeto.Text;       
                sal.horasextra = txtHorasextra.Text;
                sal.RegistroPago = (int)cboPago.SelectedValue;        
                sal.descuento = (int)cboDescuento.SelectedValue;        
                if (sal.Agregar() == true)        
                {                            
                    MostrarDatos();          
                }           
                else           
                {
                errorSalario.SetError(dgvSalario, "Error en la conexión con la base de datos, no se puede ingresar el registro...");         
                }
            }
        }

        private void SalarioAdmin_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Salario s = new Salario();
            cboPago.DataSource = s.Pagos();
            cboPago.DisplayMember = "fecha_vencimiento";
            cboPago.ValueMember = "id_registroPago";
            
            cboDescuento.DataSource = s.Descuentos();
            cboDescuento.DisplayMember = "tipo_descuento";
            cboDescuento.ValueMember = "id_descuento";
        }
        private void MostrarDatos()
        {
            Salario s = new Salario();
            dgvSalario.DataSource = s.MostrarSalario();

            dgvSalario.Columns[0].Visible = false;
            txtHorasextra.Clear();
            txtSalarioBruto.Clear();
            txtSalarioNeto.Clear();
            pcbCotizaciones.Image = null;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdImagen = new OpenFileDialog();
            opdImagen.Filter = "Imagenes|*.jpg; *.png";
            opdImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            opdImagen.Title = "Seleccionar imagen";
            if (opdImagen.ShowDialog() == DialogResult.OK)
            {
                pcbCotizaciones.Image = Image.FromFile(opdImagen.FileName);
            }
        }

        private void txtSalarioBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorSalario.SetError(txtSalarioBruto, "Solo se admiten numeros y un decimal");
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                errorSalario.SetError(txtSalarioBruto, "Solo se admiten numeros y un decimal");
            }
        }

        private void txtSalarioNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorSalario.SetError(txtSalarioNeto,"Solo se admiten numeros");
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                errorSalario.SetError(txtSalarioNeto, "Solo se admiten numeros y un decimal");
            }
        }

        private void txtHorasextra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorSalario.SetError(txtHorasextra, "Solo se admiten numeros");
            }
        }

        private void dgvSalario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSalario_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
