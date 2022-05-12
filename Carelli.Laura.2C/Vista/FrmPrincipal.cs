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

namespace Vista
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }

        private PersonalMedico ObtenerMedico()
        {
            PersonalMedico personalMedico = (PersonalMedico)lstMedicos.SelectedItem;
            return personalMedico;
        }

        private void ShowFichaMedico()
        {
            if(lstMedicos.SelectedItem is not null)
            {
                PersonalMedico personalMedico = (PersonalMedico)lstMedicos.SelectedItem;
                rtbInfoMedico.Text = personalMedico.FichaPersonal();
            }            
        }

        private Paciente ObtenerPaciente()
        {
            Paciente paciente = (Paciente)lstPacientes.SelectedItem;
            paciente.Diagnostico = "Paciente curado";
            return paciente;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            PersonalMedico personalMedico = ObtenerMedico();
            Paciente paciente = ObtenerPaciente();

            if(personalMedico is null || paciente is null)
            {
                MessageBox.Show(
                    "Debe seleccionar un Medico y un Paciente para continuar", 
                    "Error en los datos", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            } else
            {
                //me quedo haciendo el punto 13b
                Consulta consulta = (personalMedico + paciente);
                MessageBox.Show(consulta.ToString());

            }
        }

        /// <summary>
        /// Metodo que abre una ventada y pregunta si se quiere salir de la aplicacion.
        /// </summary>
        /// <returns>
        /// DialogResult -> DialogResult.Yes || Dialog.Result.NO
        /// </returns>
        private DialogResult QuererSalir()
        {
            return MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        ///  Boton de cerrar aplicación.
        /// </summary>
        /// <param name="sender">Instancia del boton.</param>
        /// <param name="e">Informacion del evento.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  Metodo que cierra el formulario desde la 'x'.
        /// </summary>
        /// <param name="sender">Instancia del form.</param>
        /// <param name="e">Informacion del evento.</param>
        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.QuererSalir() == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFichaMedico();

        }
    }
}
