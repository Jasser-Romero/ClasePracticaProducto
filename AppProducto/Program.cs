using AppCore.Interfaces;
using AppCore.Services;
using AppProducto.Formularios;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProducto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductoModel>().As<IProductoModel>();
            builder.RegisterType<ProductoService>().As<IProductoService>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmGestionProducto());
        }
    }
}
