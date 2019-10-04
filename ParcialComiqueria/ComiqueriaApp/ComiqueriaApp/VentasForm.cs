using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Comiqueria comiqueria;
        private Producto productoSeleccionado;
        public VentasForm(Comiqueria comiqueria, Producto productoSeleccionado)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
            lblPrecioFinal.Text = "Precio Final: $" +
                (productoSeleccionado.Precio * (double)numericUpDownCantidad.Value).ToString();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = productoSeleccionado.Descripcion;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidad = ((int)numericUpDownCantidad.Value);
            if (cantidad <= productoSeleccionado.Stock)
            {
                comiqueria.Vender(productoSeleccionado, cantidad);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Superó el stock disponible. Dismunuir cantidad de unidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = "Precio Final: $" +
                (productoSeleccionado.Precio * (double)numericUpDownCantidad.Value).ToString();
        }
    }
}
