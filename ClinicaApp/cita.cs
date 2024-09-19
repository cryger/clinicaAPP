using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaAPP
{
    public partial class cita : Form
    {
        public cita()
        {
            InitializeComponent();
            cargarInformacionPacientes();
            cargarInformacionMedicos();
        }
        private void cargarInformacionPacientes()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_paciente FROM pacientes"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdCita.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdCita.Items.Add(reader["id_paciente"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_paciente de paciente: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void cargarInformacionMedicos()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_medico FROM medicos"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdCita.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdCita.Items.Add(reader["id_medico"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_medico de Medicos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
