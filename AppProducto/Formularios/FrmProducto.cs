using AppCore.Interfaces;
using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProducto.Formularios
{
    public partial class FrmProducto : Form
    {
        public ProductoModel PModel { get; set; }
        public IProductoService PService { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }


        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = PService.GetLastProductoId() + 1,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExist.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectedIndex
            };

            PService.Add(p);

            Dispose();
        }
    }
}
