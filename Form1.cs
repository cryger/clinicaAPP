using System.Security.Cryptography.X509Certificates;

namespace ClinicaAPP
{
    public partial class Form1 : Form
    {
        //definicion de variables globales
        String usuario = "admin";
        String clave = "12345";

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            validacionUsuario();

        }
        public void validacionUsuario()
        {
            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {
               MessageBox.Show("Ingresaste correctamente","Ingreso Correcto!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                Principal ventana = new Principal();
                ventana.Show();

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al ingresar los datos, usuario y/o clave incorrectos","Error de inicio de sesion",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
