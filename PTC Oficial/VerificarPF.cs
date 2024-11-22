using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    internal class VerificarPF
    {
        Conexion c = new Conexion();
        public DataTable preguntas()
        {
            MySqlConnection CON = c.Conectar();
            string comando = "SELECT * FROM preguntas;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando, CON);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
