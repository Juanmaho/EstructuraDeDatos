using System;
using System.Windows.Forms;

namespace EPS_SalvandoVidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize components or set initial state
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Implementation if needed
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "unad")
            {
                FormIngresoDatos formularioDatos = new FormIngresoDatos();
                formularioDatos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso: Estructura de Datos\nEstudiante: Juan Martin Hincapie O.\nGrupo: 301305A_1704", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}