using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qmanager
{
    class Profesor
    {
        public static int AgregarProfesor(CEProfesor Profesor)
        {
            int retorna = 1;

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "INSERT INTO `tb_profesor`(`Cedula`, `Nombre`, `Apellido`, `Foto`,`Password`) VALUES (@Cedula, @Nombre, @Apellido, @Foto, @Password)";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", Profesor.Cedula);
                comando.Parameters.AddWithValue("@Nombre", Profesor.Nombre);
                comando.Parameters.AddWithValue("@Apellido", Profesor.Apellido);
                comando.Parameters.AddWithValue("@Foto", Profesor.Foto);
                comando.Parameters.AddWithValue("@Password", Profesor.Password);
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }

        public static List<CEProfesor> PresentarRegistro()
        {
            List<CEProfesor> lista = new List<CEProfesor>();
            using (MySqlConnection connection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT Cedula, Nombre, Apellido, Foto FROM tb_profesor"; // Asegúrate de que los nombres de las columnas son correctos
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CEProfesor profesor = new CEProfesor
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Foto = reader["Foto"].ToString() // Asumiendo que Foto es una cadena de texto
                    };
                    lista.Add(profesor);
                }
            }
            return lista;
        }

        public static int EliminarProfesor(string cedula)
        {
            int retorna = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "DELETE FROM `tb_profesor` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int ModificarProfesor(CEProfesor profesor)
        {
            int result = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "UPDATE `tb_profesor` SET `Nombre`=@Nombre, `Apellido`=@Apellido, `Foto`=@Foto WHERE Cedula=@Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Nombre", profesor.Nombre);
                comando.Parameters.AddWithValue("@Apellido", profesor.Apellido);
                comando.Parameters.AddWithValue("@Foto", profesor.Foto);
                comando.Parameters.AddWithValue("@Cedula", profesor.Cedula);


                result = comando.ExecuteNonQuery();
            }
            return result;
        }
        public static bool ExisteCedula(string cedula)
        {
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM `tb_profesor` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0; // Devuelve verdadero si existe
            }
        }
        public static CEProfesor BuscarProfesorPorCedula(string cedula)
        {
            CEProfesor profesor = null;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM `tb_profesor` WHERE `Cedula` = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    profesor = new CEProfesor
                    {
                        Cedula = reader.GetString("Cedula"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Foto = reader.GetString("Foto")
                    };
                }
            }
            return profesor;
        }

    
        public static List<CEProfesor> BuscarProfesorPorCedulaParcial(string cedulaParcial)
        {
            List<CEProfesor> resultados = new List<CEProfesor>();

            // Ajusta tu consulta para permitir búsqueda parcial
            string query = "SELECT * FROM tb_Profesor WHERE Cedula LIKE @cedulaParcial";

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                MySqlCommand command = new MySqlCommand(query, conection);
                command.Parameters.AddWithValue("@cedulaParcial", cedulaParcial + "%"); // Busca por coincidencias iniciales

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CEProfesor profesor = new CEProfesor
                        {
                            Cedula = reader["Cedula"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Foto = reader["Foto"].ToString()
                        };
                        resultados.Add(profesor);
                    }
                }
            }
            return resultados;
        }


    }
}



