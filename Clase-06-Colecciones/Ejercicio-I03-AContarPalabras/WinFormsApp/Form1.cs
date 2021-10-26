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


        private Dictionary<string, int> ContadorPalabras() 
        {
            string texto = richTxBoxPalabras.Text;
            Dictionary<String, int> dicPalabras = new Dictionary<string, int>();
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

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

        private List<KeyValuePair<string,int>> ObetenerPodio(Dictionary<string, int> dic) 
        {
            List<KeyValuePair<string, int>> list = dic.ToList();
            list.Sort(CompararElemento);

            return list;
        }

        private int CompararElemento(KeyValuePair<string, int> primer, KeyValuePair<string,int> segundo) 
        {
            return segundo.Value - primer.Value;
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
                for (int i = 0; i < 3 && i < podio.Count; i++) 
                {
                    sb.AppendLine($"Palabra: {podio[i].Key} - Cantidad: {podio[i].Value}");
                }
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                //}
            }
            MessageBox.Show(sb.ToString(), "Podio");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ContadorPalabras();
            List<KeyValuePair<string, int>> podio = ObetenerPodio(contadorPalabras);
            MostrarPodio(podio);
        }
    }
}
