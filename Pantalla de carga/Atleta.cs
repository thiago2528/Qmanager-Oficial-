using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Qmanager
{
    public class Atleta
    {
        public static int AgregarAtleta(CEAtleta atleta)
        {
            int retorna = 1;

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "INSERT INTO `tb_atleta`(`Cedula`, `Nombre`, `Apellido`, `Foto`,`Password`) VALUES (@Cedula, @Nombre, @Apellido, @Foto, @Password)";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", atleta.Cedula);
                comando.Parameters.AddWithValue("@Nombre", atleta.Nombre);
                comando.Parameters.AddWithValue("@Apellido", atleta.Apellido);
                comando.Parameters.AddWithValue("@Foto", atleta.Foto);
                comando.Parameters.AddWithValue("@Password", atleta.Password);
                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }

        public static List<CEAtleta> PresentarRegistro()
        {
            List<CEAtleta> lista = new List<CEAtleta>();
            using (MySqlConnection connection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT Cedula, Nombre, Apellido, Foto FROM tb_atleta"; // Asegúrate de que los nombres de las columnas son correctos
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CEAtleta atleta = new CEAtleta
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Foto = reader["Foto"].ToString() // Asumiendo que Foto es una cadena de texto
                    };
                    lista.Add(atleta);
                }
            }
            return lista;
        }

        public static int EliminarAtleta(string cedula)
        {
            int retorna = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "DELETE FROM `tb_atleta` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static int ModificarAtleta(CEAtleta atleta)
        {
            int result = 0;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "UPDATE `tb_atleta` SET `Nombre`=@Nombre, `Apellido`=@Apellido, `Foto`=@Foto WHERE Cedula=@Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Nombre", atleta.Nombre);
                comando.Parameters.AddWithValue("@Apellido", atleta.Apellido);
                comando.Parameters.AddWithValue("@Foto", atleta.Foto);
                comando.Parameters.AddWithValue("@Cedula", atleta.Cedula);


                result = comando.ExecuteNonQuery();
            }
            return result;
        }
        public static bool ExisteCedula(string cedula)
        {
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM `tb_atleta` WHERE Cedula = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0; // Devuelve verdadero si existe
            }
        }
        public static CEAtleta BuscarAtletaPorCedula(string cedula)
        {
            CEAtleta atleta = null;
            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM `tb_atleta` WHERE `Cedula` = @Cedula";
                MySqlCommand comando = new MySqlCommand(query, conection);
                comando.Parameters.AddWithValue("@Cedula", cedula);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    atleta = new CEAtleta
                    {
                        Cedula = reader.GetString("Cedula"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Foto = reader.GetString("Foto")
                    };
                }
            }
            return atleta;
        }

        // En la clase AtletaAlta
public static List<CEAtleta> BuscarAtletasPorCedulaParcial(string cedulaParcial)
{
    List<CEAtleta> resultados = new List<CEAtleta>();
    
    // Ajusta tu consulta para permitir búsqueda parcial
    string query = "SELECT * FROM tb_atleta WHERE Cedula LIKE @cedulaParcial";

            using (MySqlConnection conection = BDgeneral.ObtenerConexion())
            {
        MySqlCommand command = new MySqlCommand(query, conection);
        command.Parameters.AddWithValue("@cedulaParcial", cedulaParcial + "%"); // Busca por coincidencias iniciales
        
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                CEAtleta atleta = new CEAtleta
                {
                    Cedula = reader["Cedula"].ToString(),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Foto = reader["Foto"].ToString()
                };
                resultados.Add(atleta);
            }
        }
    }
    return resultados;
}


    }
}
