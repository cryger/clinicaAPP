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
    public partial class paciente : Form
    {
        public paciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = this.txtNombre.Text;
            //string apellido = this.txtApellido.Text;
            DateTime dtfechaNacimiento2 = dtFechaNacimiento.Value;
            string fechanaNacimiento = dtfechaNacimiento2.ToString();
            string sexo = cbSexo.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;


            Database db = new Database();
            db.OpenConnection();

            string query = "INSERT INTO Pacientes (id_Paciente,Nombre, fecha_nacimiento, Direccion, Telefono, sexo, correo) VALUES (@identificacion, @nombre, @fecha_nacimiento, @direccion, @telefono,@sexo, @correo)";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@identificacion", identificacion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", dtfechaNacimiento2);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@correo", correo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT Id_Paciente, Nombre, DATE_FORMAT(Fecha_Nacimiento, '%Y-%m-%d') AS FechaNacimiento, Direccion, Telefono, Sexo, Correo FROM Pacientes";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                // Adaptador de datos para ejecutar la consulta y llenar el DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // DataTable para almacenar los resultados
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los datos
                adapter.Fill(dataTable);

                // Asignar el DataTable como fuente de datos del DataGridView
                dataGridViewPacientes.DataSource = dataTable;

                // Opcional: Ajustar las columnas automáticamente según el contenido
                dataGridViewPacientes.AutoResizeColumns();
                dataGridViewPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar pacientes: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validamos que los campos requeridos estén completos antes de intentar actualizar
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor selecciona un paciente.");
                return;
            }

            // Recolectar los datos del formulario
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtFechaNacimiento.Value; // Convertir el DateTimePicker
            string sexo = cbSexo.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            Database db = new Database();
            db.OpenConnection();

            // Consulta SQL para actualizar el paciente
            string query = "UPDATE Pacientes SET Nombre = @nombre,  Sexo = @sexo, " +
                           "Direccion = @direccion, Telefono = @telefono, Correo = @correo WHERE id_paciente = @identificacion";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nombre", nombre);
            //cmd.Parameters.AddWithValue("@fecha_Nacimiento", fechaNacimiento.ToString("yyyy-MM-dd")); // Formato de fecha
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@identificacion", identificacion);

            try
            {
                // Ejecutamos la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paciente actualizado exitosamente.");
                    // Recargar los datos del DataGridView para reflejar los cambios
                    CargarDatosPacientes();
                }
                else
                {
                    MessageBox.Show("No se encontró el paciente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message);
                MessageBox.Show(dtFechaNacimiento.ToString());
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void dataGridViewPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewPacientes.Rows[e.RowIndex];

                // Asignamos los valores de la fila seleccionada a los campos correspondientes del formulario

                txtIdentificacion.Text = row.Cells["Id_Paciente"].Value.ToString(); // ID del paciente
                txtNombre.Text = row.Cells["Nombre"].Value.ToString(); // Nombre

                //txtApellido.Text = row.Cells["Apellido"].Value.ToString(); // Apellido (omitido si ya no se usa)

                // Convertimos el campo FechaNacimiento a DateTime y lo asignamos al DateTimePicker
                if (row.Cells["FechaNacimiento"].Value != DBNull.Value)
                {
                    DateTime fechaNacimiento = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                    dtFechaNacimiento.Value = fechaNacimiento; // Campo tipo DateTimePicker
                }

                cbSexo.Text = row.Cells["Sexo"].Value.ToString(); // Sexo
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString(); // Dirección
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString(); // Teléfono
                txtCorreo.Text = row.Cells["Correo"].Value.ToString(); // Correo electrónico
            }
        }

        private void CargarDatosPacientes()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_paciente, Nombre, Fecha_Nacimiento, Direccion, Telefono, Sexo, Correo FROM Pacientes";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Convertir el tipo DateTime en las columnas del DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime fechaNacimiento = Convert.ToDateTime(row["Fecha_Nacimiento"]);
                    row["Fecha_Nacimiento"] = fechaNacimiento.ToString("yyyy-MM-dd");
                }

                dataGridViewPacientes.DataSource = dataTable;

                dataGridViewPacientes.AutoResizeColumns();
                dataGridViewPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar pacientes: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dataGridViewPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un paciente para eliminar.");
                return;
            }

            // Obtenemos el ID del paciente desde la fila seleccionada
            int identificacion = Convert.ToInt32(dataGridViewPacientes.SelectedRows[0].Cells["id_paciente"].Value); // Asegúrate de que la columna se llama "PacienteID"

            // Confirmamos que el usuario realmente desea eliminar al paciente
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();

                string query = "DELETE FROM Pacientes WHERE id_paciente = @identificacion";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@identificacion", identificacion);

                try
                {
                    // Ejecutamos la consulta de eliminación
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paciente eliminado exitosamente.");

                        // Refrescamos el DataGridView para reflejar los cambios
                        CargarDatosPacientes();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente a eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
