using System;
using System.Windows.Forms;

namespace Pampazon.Prototipo
{
    public partial class GestionPedidosSeleccionForm : Form
    {
        public GestionPedidosSeleccionForm()
        {
            InitializeComponent();
            AjustePantalla.Aplicar(this);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabGestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar cambio de pestaña si es necesario
        }
    }
}
