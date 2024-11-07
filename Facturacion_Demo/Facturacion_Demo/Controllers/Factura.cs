using Microsoft.AspNetCore.Mvc;

namespace Facturacion_Demo.Controllers
{
    public class Factura : Controller
    {
        public IActionResult IndexFactura()
        {
            return View();
        }
    }
}
