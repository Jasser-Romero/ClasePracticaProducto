using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;

namespace AppProducto.Formularios
{
    public partial class FrmGestionProducto : Form
    {
        private ProductoModel productoModel;
        private IProductoService productoService;
        public FrmGestionProducto(IProductoService productoService)
        {
            this.productoService = productoService;
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );

        }

        private void CmbFinderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinderType.SelectedIndex)
            {
                case 0:
                    txtFinder.Visible = true;
                    cmbMeasureUnit.Visible = false;
                    break;
                case 3:
                    cmbMeasureUnit.Visible = true;
                    txtFinder.Visible = false;
                    break;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PService = productoService;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoService.GetProductosAsJson();
        }
    }
}
