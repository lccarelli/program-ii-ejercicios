using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class FrmAltaModificacion : Form
    {
        private string titulo;
        private string textoTxtObjeto;
        private string textoBttnConfirmar;

        public FrmAltaModificacion()
        {
            InitializeComponent();
        }

        public FrmAltaModificacion(string titulo, string textoTxtObjeto, string textoBttnConfirmar)
        {
            Titulo = titulo;
            TextoTxtObjeto = textoTxtObjeto;
            TextoBttnConfirmar = textoBttnConfirmar;
        }

        public string Titulo { get => titulo; set => this.Text = value; }
        public string TextoTxtObjeto 
        { 
            get => textoTxtObjeto;
            set => txtObjeto.Text = value;
        }
        public string TextoBttnConfirmar { get => textoBttnConfirmar; set => bttnConfirmar.Text = value; }

        private void bttnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtObjeto is null)
            {
                throw new Exception("El texto del box se encuentra vacio.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
