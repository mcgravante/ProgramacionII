using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefónica
{
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipoLlamada;
        private Centralita centralita;
        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }
        public FrmMostrar(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
                richTextBox1.Text = this.centralita.GananciasPorTotal.ToString();
            if (this.tipoLlamada == Llamada.TipoLlamada.Local)
                richTextBox1.Text = this.centralita.GananciasPorLocal.ToString();
            if (this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                richTextBox1.Text = this.centralita.GananciasPorProvincial.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
