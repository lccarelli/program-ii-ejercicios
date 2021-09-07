using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy {nombre} {apellido}";

            FormSaludar frmSaludo = new FormSaludar(titulo, mensaje);
            frmSaludo.ShowDialog();
            
        }
    }
}
