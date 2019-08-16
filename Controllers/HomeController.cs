using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCurso.Models;
using EFCurso.Database;

namespace EFCurso.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext database;


        public HomeController(ApplicationDBContext database)
        {
            this.database = database;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Teste()
        {
            /*
            Categoria cat1 = new Categoria();
            cat1.Nome = "Categoria 1";
            Categoria cat2 = new Categoria();
            cat2.Nome = "Categoria 1";
            Categoria cat3 = new Categoria();
            cat3.Nome = "Categoria 3";

            Categoria cat4 = new Categoria();
            cat4.Nome = "Categoria 4";

            List<Categoria> cat = new List<Categoria>();
            cat.Add(cat1);
            cat.Add(cat2);
            cat.Add(cat3);
            cat.Add(cat4);

            database.AddRange(cat);
            database.SaveChanges();
            */

            Console.WriteLine("======================Obtendo categorias======================");
            var listaDeCategotias = database.Categorias.Where(cat => cat.Nome == "Categoria 1").ToList<Categoria>();


            Console.WriteLine("======================Categorias================");
            listaDeCategotias.ForEach(categoria =>
            {
                Console.WriteLine(categoria.ToString());
            });

            Console.WriteLine("======================================");

            return Content("Dados Salvos");
        }
    }
}
