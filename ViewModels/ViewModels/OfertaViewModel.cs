using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class OfertaViewModel
    {
        public Oferta Oferta { get; set; } //datos de la oferta
        public List<Producto> Productos { get; set; }

        public List<Proveedor> Proveedores { get; set; } 

    }
}