using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orden_Pizza
{
    public partial class frmPrincipal : Form
    {

        Orden_Compra Orden;

        public frmPrincipal()
        {
            InitializeComponent();
            llenarcombotipo();
            llenarcomboPasta();

        }

        private void llenarcomboPasta()
        {
            cmbPasta.Items.Add(Pasta.Delgada);
            cmbPasta.Items.Add(Pasta.Gruesa);
            cmbPasta.SelectedIndex = -1;
        }

        private void llenarcombotipo()
        {

            cmbTipo.Items.Add(new Napolitana());
            cmbTipo.Items.Add(new Superma());
            cmbTipo.Items.Add(new Vaquera());
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ITamano tammano = null;


            if (rbtnPersonal.Checked)
            {
                tammano = new Personal();
            }

            if (rbtnMediana.Checked)
            {
                tammano = new Mediana();
            }

            if (rbtnGrande.Checked)
            {
                tammano = new Grande();
            }

            Orden = OrdenCompra_Factory.CrearOrden(Convert.ToInt32(npdCantidad.Text), (Pizza)cmbTipo.SelectedItem, (Pasta)cmbPasta.SelectedItem, tammano);

            llenarExtras();

            txtTotal.Text = Orden.CalcularTotal().ToString();
        }

        private void llenarExtras()
        {
            if (chkQueso.Checked)
            {
                Orden.AddExtras(Extra.Queso);
            }
            if (chkChile.Checked)
            {
                Orden.AddExtras(Extra.Chile);
            }
            if (chkEnsalada.Checked)
            {
                Orden.AddExtras(Extra.Ensalada);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Orden_Pizza.xml";
            if (Orden != null)
            {
                Orden.guardar(ruta);
                Orden.trasformarXMLaHTMl();
            }
            else
            {
                MessageBox.Show("No se a guardado la Orden");
                return;
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Orden_Compra orden = OrdenCompra_Factory.Calculadora();

            
           
        }
    }
}
