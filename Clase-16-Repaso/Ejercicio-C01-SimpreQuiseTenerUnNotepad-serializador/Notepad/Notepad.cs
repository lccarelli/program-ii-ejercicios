using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;
        private PuntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;
        const string JSON = ".json";
        const string XML = ".xml";
        const string TXT = ".txt";
        public Notepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            puntoJson = new PuntoJson<string>();
            puntoXml = new PuntoXml<string>();
            puntoTxt = new PuntoTxt();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                archivo = openFileDialog.FileName;
                Leer();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(archivo))
            {
                Guardar();
            }
            else
            {
                GuardarComo();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GuardarComo();
            }
        }

        private void Leer() 
        {
            try
            {
                switch (Path.GetExtension(archivo))
                {
                    case JSON:
                        contenido.Text = puntoJson.Leer(archivo);
                        break;
                    case XML:
                        contenido.Text = puntoXml.Leer(archivo);
                        break;
                    case TXT:
                        contenido.Text = puntoTxt.Leer(archivo);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void Guardar() 
        {
            try
            {
                switch (Path.GetExtension(archivo))
                {
                    case JSON:
                        puntoJson.Guardar(archivo, contenido.Text);
                        break;
                    case XML:
                        puntoXml.Guardar(archivo, contenido.Text);
                        break;
                    case TXT:
                        puntoTxt.Guardar(archivo, contenido.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void GuardarComo()
        {
            try
            {
                switch (Path.GetExtension(archivo))
                {
                    case JSON:
                        puntoJson.GuardarComo(archivo, contenido.Text);
                        break;
                    case XML:
                        puntoXml.GuardarComo(archivo, contenido.Text);
                        break;
                    case TXT:
                        puntoTxt.GuardarComo(archivo, contenido.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            statusStrip1.Text = "";
        }

        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
