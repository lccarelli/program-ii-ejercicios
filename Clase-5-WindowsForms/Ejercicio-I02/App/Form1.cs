using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace App
{
    public partial class frmResgistro : Form
    {
        public frmResgistro()
        {
            InitializeComponent();
        }


        private string ObtenerGenero() 
        {
            string genero = "";

            foreach (Control item in gruopBoxGenero.Controls)
            {
                if (((RadioButton)item).Checked) {
                    genero = item.Text;
                }
            }

            return genero;
        }

        private List<string> ObtenerCursos() 
        {
            List<string> cursos = new List<string>();

            foreach (Control item in groupBoxCursos.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked) 
                {
                    cursos.Add(item.Text);
                }
            }

            return cursos;
        }

        private String ObtenerPais()
        {
            return (string)listPaises.SelectedItem;
        }

        private void frmResgistro_Load(object sender, EventArgs e)
        {
            listPaises.Items.Add("Argenitna");
            listPaises.Items.Add("Chile");
            listPaises.Items.Add("Uruguay");
        }

        private void btnIngrarClick(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            string direccion = txtBoxDireccion.Text;
            int edad = (int)nupEdad.Value;
            Ingresante ingresante = new Ingresante(ObtenerCursos(), direccion, edad, ObtenerGenero(), nombre, ObtenerPais());

            MessageBox.Show(Ingresante.Mostrar());
        }
    }
}
