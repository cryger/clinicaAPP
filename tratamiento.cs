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
    public partial class tratamiento : Form
    {
        public tratamiento()
        {
            InitializeComponent();
            CargarNombresMedicos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idTratamiento = txtIdTratamiento.Text;
            string idCita = cbIdCita.Text;
            string descripcion = txtDescripcion.Text;
            string costo = txtCosto.Text;

            Database db = new Database();
            db.OpenConnection();

            string query = "INSERT INTO Tratamientos (id_tratamiento,id_cita, Descripcion,costo) VALUES (@idTratamiento,@idCita,@descripcion,@costo)";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@idTratamiento", idTratamiento);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@costo", costo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tratamiento agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tratamiento: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Método para cargar los nombres de los médicos en el ComboBox
        private void CargarNombresMedicos()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_cita FROM tratamientos"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdCita.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdCita.Items.Add(reader["id_cita"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_cita de tratamientos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void CargarDatosTratamientos()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_tratamiento, id_cita, descripcion,costo FROM tratamientos";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewTratamientos.DataSource = dataTable;

                dataGridViewTratamientos.AutoResizeColumns();
                dataGridViewTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar medicos: " + ex.Message);
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

            string query = "SELECT * FROM tratamientos";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable al DataGridView
                dataGridViewTratamientos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar médicos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dataGridViewTratamientos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un paciente para eliminar.");
                return;
            }

            // Obtenemos el ID del paciente desde la fila seleccionada
            int identificacion = Convert.ToInt32(dataGridViewTratamientos.SelectedRows[0].Cells["id_tratamiento"].Value);

            // Confirmamos que el usuario realmente desea eliminar al paciente
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();

                string query = "DELETE FROM tratamientos WHERE id_tratamiento = @idTratamiento";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@idTratamiento", identificacion);

                try
                {
                    // Ejecutamos la consulta de eliminación
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medico eliminado exitosamente.");

                        // Refrescamos el DataGridView para reflejar los cambios
                        CargarDatosTratamientos();
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

        private void button2_Click(object sender, EventArgs e)
        {
            int idTratamiento = int.Parse(txtIdTratamiento.Text);
            string idCita = cbIdCita.Text;
            string descripcion = txtDescripcion.Text;
            string costo = txtCosto.Text;

            Database db = new Database();
            db.OpenConnection();

            string query = "UPDATE Tratamientos SET id_tratamiento = @idTratamiento, id_cita = @idCita, Descripcion = @descripcion, costo = @costo WHERE id_tratamiento = @idTratamiento";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@idTratamiento", idTratamiento);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@costo", costo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tratamiento actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar tratamiento: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void dataGridViewTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewTratamientos.Rows[e.RowIndex];

                // Asignamos los valores de la fila seleccionada a los campos correspondientes del formulario

                txtIdTratamiento.Text = row.Cells["id_tratamiento"].Value.ToString(); // ID del Tratamiento
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString(); // Descripcion


                cbIdCita.Text = row.Cells["id_cita"].Value.ToString(); // Sexo
                txtCosto.Text = row.Cells["costo"].Value.ToString(); // Teléfono
                
            }
        }
    }
}
