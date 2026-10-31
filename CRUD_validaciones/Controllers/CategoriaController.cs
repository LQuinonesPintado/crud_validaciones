using CRUD_validaciones.Datos;
using CRUD_validaciones.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_validaciones.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria;
            return View(lista);
        }
    }
}
