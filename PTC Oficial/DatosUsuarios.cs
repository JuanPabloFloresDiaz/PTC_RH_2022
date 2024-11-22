using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PTC_Oficial
{
    internal class DatosUsuarios
    {
        Conexion c = new Conexion();
        public DataTable MostrarDatosContratacion()
        {
            string comando = "SELECT id_empleado AS 'id', fecha_ingreso AS 'Fecha de ingreso', nombres_y_apellidosUsuario AS 'Nombre completo', fecha_nacimiento_empleado AS 'Fecha de nacimiento', direccion_empleado AS 'Dirección de empleado', area_trabajo AS 'Area de trabajo', tipogenero AS 'Genero', nombreUsuario AS 'Nombre de usuario', correoElectronico AS 'Correo electronico' FROM Empleados AS pv INNER JOIN Usuarios AS u ON pv.id_Usuario = u.id_Usuario INNER JOIN Generos AS p ON pv.id_genero = p.id_genero INNER JOIN areasdetrabajo AS a ON a.idArea = pv.idArea;";
            MySqlConnection cnx = c.Conectar();
            DataTable dt = new DataTable();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando, cnx);
            adaptador.Fill(dt);

            return dt;
        }

    }
}
