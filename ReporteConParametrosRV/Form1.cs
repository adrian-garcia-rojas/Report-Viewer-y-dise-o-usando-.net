using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteConParametrosEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.mostrarTodos(this.NorthwindDataSet.Products);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string productName = txbBuscar.Text;
            if(productName.Length > 0)
            {
                this.ProductsTableAdapter.filtroPorProducto(this.NorthwindDataSet.Products,productName); //el parametro lo antecede una coma
                this.reportViewer1.RefreshReport();
                txbBuscar.Text = "";
            }
            else
            {
                MessageBox.Show("Debes de escribir un producto a buscar");
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            this.ProductsTableAdapter.mostrarTodos(this.NorthwindDataSet.Products);

            this.reportViewer1.RefreshReport();
        }

    }
}
