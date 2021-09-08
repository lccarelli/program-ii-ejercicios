using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmContadorPalabras : Form
    { 

        public FrmContadorPalabras()
        {
            InitializeComponent();

        }


        private Dictionary<string, int> contadorPalabras() 
        {
            string texto = richTxBoxPalabras.Text;
            Dictionary<String, int> dicPalabras = new Dictionary<string, int>();
            string[] palabras = texto.Split(' ');
            int contador = 1;

            foreach (string palabra in palabras)
            {
                if (dicPalabras.ContainsKey(palabra)) 
                {
                    dicPalabras[palabra]++;
                } else {
                    dicPalabras.Add(palabra, 1);
                }
            }

            return dicPalabras;

        }

        private List<KeyValuePair<string,int>> odernar(Dictionary<string, int> dic) 
        {
            List<KeyValuePair<string, int>> list = dic.ToList();
            list.Sort(CompararElemento);

            return list;
        }

        private int CompararElemento(KeyValuePair<string, int> primer, KeyValuePair<string,int> segundo) 
        {
            return primer.Value - segundo.Value;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio) 
        {
            StringBuilder sb = new StringBuilder();

            if (podio.Count == 0)
            {
                sb.Append("No se ingresaron palabras");
            }
            else
            { 
                
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"La cantidad de palabras son -> {count}");
        }
    }
}
