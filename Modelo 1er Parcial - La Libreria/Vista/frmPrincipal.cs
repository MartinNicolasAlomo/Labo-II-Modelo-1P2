using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmPrincipal : Form
    {

        private Vendedor vendedor;


        public frmPrincipal()
        {
            InitializeComponent();
            vendedor = new Vendedor("Martin");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)"; // No debe poder vender, no tiene stock.
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5); // No debe poder vender
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            lbx_Stock.Items.Add(p1);
            lbx_Stock.Items.Add(p2);
            lbx_Stock.Items.Add(p3);
            lbx_Stock.Items.Add(p4);
            lbx_Stock.Items.Add(p5);
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            int indice = lbx_Stock.SelectedIndex;
            if (indice >= 0)
            {
                //Publicacion publicacion = lstStock.SelectedItem as Publicacion;
                Publicacion publicacionElegida = (Publicacion)lbx_Stock.SelectedItem;
                if (publicacionElegida is not null && vendedor + publicacionElegida)
                {
                    MessageBox.Show("Venta exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La venta no pudo realizarse por falta de stock.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_VerInforme_Click(object sender, EventArgs e)
        {
            rtb_Informe.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro/a que desea cerrar el programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
