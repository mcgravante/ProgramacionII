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
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        private bool esProvincial = false;
        public String Centralita
        {
            get
            {
                return this.centralita.ToString();
            }
        }
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text != null && txtNroDestino.Text.Equals("#"))
            {
                esProvincial = true;
                cmbFranja.Enabled = true;
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Llamada llamada;
            if (esProvincial)
            {
                Provincial.Franja franja;
                Random auxDuracion = new Random();
                float duracion = (float)auxDuracion.Next(10, 500) / 10;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(txtNroOrigen.Text, franja, duracion, txtNroDestino.Text);
            }
            else
            {
                Random auxDuracion = new Random();
                float duracion = (float)auxDuracion.Next(10, 500) / 10;
                Random auxCosto = new Random();
                float costo = (float)auxCosto.Next(5, 56) / 10;
                llamada = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
            }
            this.centralita += llamada;
        }

        private void PanelANroDestino(Button button)
        {
            if (txtNroDestino.Text.Equals("Nro Destino"))
            {
                txtNroDestino.Clear();
            }
            txtNroDestino.Text += button.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn2);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn3);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn4);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn5);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn6);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn8);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn9);

        }

        private void btnAst_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btnAst);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btn0);

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            PanelANroDestino(btnNum);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Enabled = false;
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
