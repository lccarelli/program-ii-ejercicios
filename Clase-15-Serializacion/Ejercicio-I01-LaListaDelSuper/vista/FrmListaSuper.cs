﻿using System;
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
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSuper;

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSuper = new List<string>();
        }


        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion formAgregar = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar" );
            formAgregar.ShowDialog();

            if (formAgregar.DialogResult is DialogResult.OK) 
            {
                listaSuper.Add(formAgregar.TextoTxtObjeto);
            }
        }
    }
}
