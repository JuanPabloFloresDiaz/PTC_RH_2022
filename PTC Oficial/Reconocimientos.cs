using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    public partial class Reconocimientos : Form
    {
        public Reconocimientos()
        {
            InitializeComponent();
           
        }
        private void MostrarDatos()
        {
            dgvReconocimientos.DataSource = Reconocimientos.Mostrar();

            //dgvReconocimientos.Columns[0].Visible = false;
            //dgvReconocimientos.Columns[3].Visible = false;
        }
        public void MOSTRAR()
        {
            try
            {
                dgvReconocimientos.DataSource = Reconocimientos.Mostrar();
            }
            catch (Exception e)
            {
                errorReconocimiento.SetError(dgvReconocimientos, " Error en la conexion");
            }
        }

        public static DataTable Mostrar()
        {
            Conexion c = new Conexion();
            MySqlConnection conex = c.Conectar();
            try
            {
                string comando = "select idReconocimientos AS 'ID', Texto_Reconocimiento AS 'Texto Reconocimiento', " +
                    "FechadeReconocimiento AS 'FechadeReconocimiento', nombres_y_apellidosUsuario AS 'Nombre completo' FROM Historialdereconocimientos AS g INNER JOIN Empleados AS e ON e.id_empleado = g.id_empleado;";
                MySqlCommand cmd = new MySqlCommand(comando, conex);

                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                ad.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                conex.Close();
            }
        }
        private void Reconocimientos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            MOSTRAR();
            dgvReconocimientos.Columns[0].Visible = false;
            Reconocimiento r = new Reconocimiento();
            cboEmpleados.DataSource = r.Empleados();
            cboEmpleados.DisplayMember = "nombres_y_apellidosUsuario";
            cboEmpleados.ValueMember = "id_empleado";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MOSTRAR();
            Reconocimiento con = new Reconocimiento();
            con.Texto_Reconocimiento = txtReconocimiento.Text;
            con.FechadeReconocimiento = dtpFecha.Text;
            con.empleado = (int)cboEmpleados.SelectedValue;

            if (con.Agregar() == true)
            {
                
                MostrarDatos();
            }
            else
            {
                errorReconocimiento.SetError(btnIngresar, "Error en la conexión con la base de datos, no se puede ingresar el registro...");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                int id = int.Parse(dgvReconocimientos.CurrentRow.Cells[0].Value.ToString());
                Reconocimiento Rec = new Reconocimiento();
                Rec.idReconocimientos = id;
                if (Rec.Eliminar())
                {
                    MessageBox.Show("la solicitud de vacaciones ha sido eliminado exitosamente", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDatos();


                }
                else
                {
                    errorReconocimiento.SetError(btnEliminar, "Error en la conexión con la base de datos, no se puede eliminar el registro...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvReconocimientos.CurrentRow.Cells[0].Value.ToString());

            Reconocimiento con = new Reconocimiento();
            con.Texto_Reconocimiento = txtReconocimiento.Text;
            con.FechadeReconocimiento = dtpFecha.Text;
            con.empleado = (int)cboEmpleados.SelectedValue;
            con.idReconocimientos = id;
            if (con.Update() == true)
            {
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReconocimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReconocimiento.Text = dgvReconocimientos.CurrentRow.Cells[1].Value.ToString();
            dtpFecha.Text = dgvReconocimientos.CurrentRow.Cells[2].Value.ToString();
            cboEmpleados.Text = dgvReconocimientos.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
