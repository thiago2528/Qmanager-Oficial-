using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qmanager
{
    class Arbitro
    {
        public static int AgregarArbitro(CEArbitro arbitro)
        {
            int retorna = 1;

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "INSERT INTO `tb_arbitro`(`Cedula`, `Nombre`, `Apellido`, `Foto`, `Password`) VALUES (@Cedula, @Nombre, @Apellido, @Foto, @Password)";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", arbitro.Cedula);
                comando.Parameters.AddWithValue("@Nombre", arbitro.Nombre);
                comando.Parameters.AddWithValue("@Apellido", arbitro.Apellido);
                comando.Parameters.AddWithValue("@Foto", arbitro.Foto);
                comando.Parameters.AddWithValue("@Password", arbitro.Password);
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }

        public static List<CEArbitro> PresentarRegistro()
        {
            List<CEArbitro> lista = new List<CEArbitro>();
            using (MySqlConnection connection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT Cedula, Nombre, Apellido, Foto FROM tb_arbitro"; // Asegúrate de que los nombres de las columnas son correctos
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CEArbitro arbitro = new CEArbitro
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Foto = reader["Foto"].ToString() // Asumiendo que Foto es una cadena de texto
                    };
                    lista.Add(arbitro);
                }
            }
            return lista;
        }

        public static int EliminarArbitro(string cedula)
        {
            int retorna = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "DELETE FROM `tb_arbitro` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int ModificarArbitro(CEArbitro arbitro)
        {
            int result = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "UPDATE `tb_arbitro` SET `Nombre`=@Nombre, `Apellido`=@Apellido, `Foto`=@Foto WHERE Cedula=@Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Nombre", arbitro.Nombre);
                comando.Parameters.AddWithValue("@Apellido", arbitro.Apellido);
                comando.Parameters.AddWithValue("@Foto", arbitro.Foto);
                comando.Parameters.AddWithValue("@Cedula", arbitro.Cedula);

                result = comando.ExecuteNonQuery();
            }
            return result;
        }

        public static bool ExisteCedula(string cedula)
        {
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM `tb_arbitro` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0; // Devuelve verdadero si existe
            }
        }
        public static CEArbitro BuscarArbitroPorCedula(string cedula)
        {
            CEArbitro arbitro = null;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM `tb_arbitro` WHERE `Cedula` = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    arbitro = new CEArbitro
                    {
                        Cedula = reader.GetString("Cedula"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Foto = reader.GetString("Foto")
                    };
                }
            }
            return arbitro;
        }

       
        public static List<CEArbitro> BuscarArbitrosPorCedulaParcial(string cedulaParcial)
        {
            List<CEArbitro> resultados = new List<CEArbitro>();

            // Ajusta tu consulta para permitir búsqueda parcial
            string query = "SELECT * FROM tb_arbitro WHERE Cedula LIKE @cedulaParcial";

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                MySqlCommand command = new MySqlCommand(query, conection);
                command.Parameters.AddWithValue("@cedulaParcial", cedulaParcial + "%"); // Busca por coincidencias iniciales

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CEArbitro arbitro = new CEArbitro
                        {
                            Cedula = reader["Cedula"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Foto = reader["Foto"].ToString()
                        };
                        resultados.Add(arbitro);
                    }
                }
            }
            return resultados;
        }
    }
}

