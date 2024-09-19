using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClinicaAPP
{
    public class Database
    {
        private MySqlConnection connection;

        // Constructor: Inicia la conexión con la base de datos
        public Database()
        {
            string connectionString = "Server=localhost;Database=clinica;User ID=root;Password='';";
            connection = new MySqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }

        // Obtener la conexión
        public MySqlConnection GetConnection()
        {
            return connection;
        }


    }
}
