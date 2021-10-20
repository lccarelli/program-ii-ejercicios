using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;
        public Notepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    archivo = openFileDialog.FileName;

                    using (StreamReader stream = new StreamReader(archivo))
                    {
                        richTextBox1.Text = stream.ReadToEnd();
                    }          
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))
            {
                GuardarArchivoFileDialog();
            }
            else
            {
                GuardarArchivo(archivo);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;
                GuardarArchivo(archivo);
            }
        }

        private void GuardarArchivoFileDialog() 
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                    archivo = saveFileDialog.FileName;

                    using (StreamWriter stream = new StreamWriter(archivo))
                    {
                        stream.Write(richTextBox1.Text);
                    }
            }
        }

        private void GuardarArchivo(string ruta) 
        {
                try
                {
                    using (StreamWriter stream = new StreamWriter(ruta))
                    {
                        stream.Write(richTextBox1.Text);
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
