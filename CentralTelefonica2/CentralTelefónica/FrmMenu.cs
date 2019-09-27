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
    public partial class FrmMenu : Form
    {
        private Centralita centralita = new Centralita("CentralitaEj40");

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(this.centralita);
            frmLlamador.ShowDialog();
            frmLlamador.MdiParent = this;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
