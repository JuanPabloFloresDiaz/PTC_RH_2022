using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace PTC_Oficial
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
            MostrarDatos();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroUsuarios reg = new RegistroUsuarios(txtNombre.Text, txtCorreo.Text, txtContraseña.Text, (int)cboTipoUsuario.SelectedValue);
            if (txtNombre.Text == "" || txtContraseña.Text == "" || txtCorreo.Text == "")
            {
                //  MessageBox.Show("Error los campos están vacíos...", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorRegistro.SetError(txtNombre,"Error los campos están vacíos...");
                errorRegistro.SetError(txtContraseña, "Error los campos están vacíos...");
                errorRegistro.SetError(txtCorreo, "Error los campos están vacíos...");
            }
            else
            {
                if (reg.Agregar() == true)
                {
                  //  MessageBox.Show("Usuario agregado exitosamente", " Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatos();
                }
                else
                {
                    //  MessageBox.Show("Hubo un error en el traspaso de información...", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorRegistro.SetError(btnRegistrar, "Hubo un error en el traspaso de información...");
                }
            }
        }
       
        public void MostrarDatos()
        {
            RegistroUsuarios reg = new RegistroUsuarios();
            try
            {
                dgvUsuarios.DataSource = reg.Mostrar();
            }
            catch
            {
                //  MessageBox.Show(ex.Message + "Error en la conexión con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorRegistro.SetError(dgvUsuarios, "Error en la conexión con la base de datos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                RegistroUsuarios reg = new RegistroUsuarios(id);
                if (reg.Eliminar())
                {
                //    MessageBox.Show("El usuario a sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtContraseña.Clear();
                    txtCorreo.Clear();
                    MostrarDatos();
                }
                else
                {
                    // MessageBox.Show("Error al eliminar en la conexion con la base de datos", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorRegistro.SetError(btnEliminar, "Error al eliminar en la conexion con la base de datos");
                }
            }
            catch
            {

            }
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            RegistroUsuarios reg = new RegistroUsuarios();
            cboTipoUsuario.DataSource = reg.tipousuario();
            cboTipoUsuario.DisplayMember = "tipousuario";
            cboTipoUsuario.ValueMember = "id_tipousuario";

            dgvUsuarios.Columns["id"].Visible = false;
            dgvUsuarios.Columns["Contraseña"].Visible = false;

            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                panelBotones.BackColor = TemaColores.PanelContenedor;
                PanelDoble.BackColor = TemaColores.PanelContenedor;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtContraseña.Text == "" || txtCorreo.Text == "")
            {
                //  MessageBox.Show("Error los campos están vacíos...", " Alerta de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorRegistro.SetError(txtNombre, "Error los campos están vacíos...");
                errorRegistro.SetError(txtContraseña, "Error los campos están vacíos...");
                errorRegistro.SetError(txtCorreo, "Error los campos están vacíos...");
            }
            else
            {
                try
                {
                    int id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());

                    string Nombre = txtNombre.Text;
                    string Correo = txtCorreo.Text;
                    string Contraseña = txtContraseña.Text;
                    int idtipouser = (int)cboTipoUsuario.SelectedValue;
                    RegistroUsuarios reg = new RegistroUsuarios(id, Nombre, Correo, Contraseña,idtipouser);
                    if (reg.Actualizar())
                    {
                    //    MessageBox.Show("Departamento actualizado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNombre.Clear();
                        txtContraseña.Clear();
                        txtCorreo.Clear();
                        MostrarDatos();
                    }
                    else
                    {
                        errorRegistro.SetError(btnActualizar, "Hubo un error al actualizar con la conexion a la base de datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        Encriptacion_De_Contraseñas_Por_MD5 encriptado = new Encriptacion_De_Contraseñas_Por_MD5();
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
       //     txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            cboTipoUsuario.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (validadaremail(txtCorreo.Text))
            {
               
            }
            else
            {
                errorRegistro.SetError(txtCorreo, "Dirección de correo no valida...");
                //MessageBox.Show("Dirección de correo no valida");
                txtCorreo.SelectAll();
                txtCorreo.Focus(); 
            }
        }
        public static bool validadaremail(string email)
        {
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9]+)*(.[a-z]{2,4})$";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
