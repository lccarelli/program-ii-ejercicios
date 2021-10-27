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

        public FrmAltaModificacion()
        {
            InitializeComponent();
        }

        public FrmAltaModificacion(string titulo, string textoTxtObjeto, string textoBttnConfirmar)
        {
            this.Text = titulo;
            txtObjeto.Text = textoTxtObjeto;
            bttnConfirmar.Text = textoBttnConfirmar;
        }

        public string TextoObjeto 
        {
            get 
            {
                return txtObjeto.Text;
            }
        }
        private void bttnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Confirmar() 
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("NO PUEDE ESTAR VACIO", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
