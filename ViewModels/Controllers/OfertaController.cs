using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;
using ViewModels.ViewModels;

namespace ViewModels.Controllers
{
    public class OfertaController : Controller
    {
        // GET: Oferta
        public ActionResult Index()
        {
            return View();
        }
        // GET: Nuevo
        public ActionResult Nuevo()
        {
            //Instanciamos BD y ViewModel
            PromocionesConnection BD = new PromocionesConnection();
            OfertaViewModel viewModel = new OfertaViewModel();
            viewModel.Productos = BD.Producto.ToList();
            viewModel.Proveedores = BD.Proveedor.ToList();
            return View(viewModel);
        }
    }
}