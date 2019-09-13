using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                MessageBox.Show(string.Format("Key = {0}, Value ={1}", kvp.Key, kvp.Value));
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Quito los espacios en blanco a izquierda y derecha
            string texto = richTextBox1.Text.Trim();
            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, incremento mi acumulador
                if (!string.IsNullOrEmpty(s))
                {
                    if (dict.ContainsKey(s))
                    {
                        dict[s]++;
                    }
                    else
                    {
                        dict.Add(s, 1);
                    }
                }
            }
        }

    }
}
