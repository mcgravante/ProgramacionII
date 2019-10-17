using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;

namespace CantinaFrm
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {

            InitializeComponent();
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella = null;
            if (rBtnAgua.Checked)
            {
                botella = new Agua((int)numUpDwCapacidad.Value, txtBoxMarca.Text, (int)numUpDwContenido.Value);
            }
            else if (rBtnCerveza.Checked)
            {
                botella = new Cerveza((int)numUpDwCapacidad.Value, txtBoxMarca.Text, (Botella.Tipo)cmbBotellaTipo.SelectedValue, (int)numUpDwContenido.Value);

            }
            this.barra1.AgregarBotella(botella);
        }
    }
}
