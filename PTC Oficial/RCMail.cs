using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    public partial class RCMail : Form
    {
        RCCORREO c = new RCCORREO();
        Conexion conn = new Conexion();


        private string senderMail;
        private string password;
        private string host;
        private int port;
        private bool ssl;

        public RCMail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            senderMail = "soportejarrd@gmail.com";
            password = "xdzl prmd qomt porf";
            host = "smtp.gmail.com";
            port = 465;
            ssl = true;

            using (var connection = conn.Conectar())
            {
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuarios WHERE nombreUsuario=@user OR correoElectronico=@mail;";
                    command.Parameters.AddWithValue("@user", txtCorreo.Text);
                    command.Parameters.AddWithValue("@mail", txtCorreo.Text);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(2);
                        string accountPassword = reader.GetString(3);
                        Encriptacion_De_Contraseñas_Por_MD5 decrypt = new Encriptacion_De_Contraseñas_Por_MD5();
                        accountPassword = decrypt.LETMD5(accountPassword);

                        string mens = "Hola, " + txtCorreo.Text + "\nUsted ha solicitado recuperar su clave.\n" +
                        "Su actual clave es: '" + accountPassword + "' , " +
                        "\n Sin embargo,le recomendamos que solicite a un administrador que cambie su clave inmediatamente " +
                        "despues de entrar en el sistema y no compartir este mensaje con ninguna otra persona";
                        string subject = "SISTEMA: Solicitud de recuperación de clave";

                        c.enviarCorreo(senderMail, password, mens, subject, userMail, "");
                        Login ventanalogin = new Login();
                        ventanalogin.Show();
                        ventanalogin.FormClosed += delegate
                        {
                            Show();
                        };
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Verifique el nombre de usuario");
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login ventanalogin = new Login();
            ventanalogin.Show();
            ventanalogin.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }
    }
}
