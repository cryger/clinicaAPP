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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cierra el menu de seleccion y abre una nueva ventana
            this.Hide();
            paciente ventana1 = new paciente();
            ventana1.Show();
        }

        private void btnPanelMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            medico ventana2 = new medico();
            ventana2.Show();
        }

        private void btnPanelTratamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            tratamiento ventan3 = new tratamiento();
            ventan3.Show();
        }

        private void btnPanelCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            cita ventana4 = new cita(); ;
            ventana4.Show();
        }
    }
}
