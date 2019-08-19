using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCurso.Models;
using EFCurso.Database;
using Microsoft.EntityFrameworkCore;

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

            List<Categoria> catl = new List<Categoria>();
            catl.Add(cat1);
            catl.Add(cat2);
            catl.Add(cat3);
            catl.Add(cat4);

            database.AddRange(catl);
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

        public IActionResult Relacionamento()
        {

            Produto p1 = new Produto();
            p1.Nome = "Doritos";
            p1.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p2 = new Produto();
            p2.Nome = "Suco";
            p2.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p3 = new Produto();
            p3.Nome = "Bolo";
            p3.Categoria = database.Categorias.First(c => c.Id == 2);

            List<Produto> prodl = new List<Produto>();
            prodl.Add(p1);
            prodl.Add(p2);
            prodl.Add(p3);

            database.AddRange(prodl);
            database.SaveChanges();

            return Content("Relacionamnto");
        }

        public IActionResult ConsultaRelacionamento()
        {
            // o camando "Include(p => p.Categoria " diz para o EF que eu quero que ele inclua a categoria  para cada produto.
            var listaDeProdutos = database.Produtos.Include(p => p.Categoria).ToList();

            listaDeProdutos.ForEach(produto =>
            {
                Console.WriteLine(produto.ToString());
            }
            );

            return Content("Consulta Relacionamnto");
        }

        public IActionResult ConsultaUmParaMuitos()
        {
            Console.WriteLine("Monta Lista");
            var listaProdutos = database.Produtos.Include(p => p.Categoria).Where(p => p.Categoria.Id == 1).ToList();
            Console.WriteLine("VaiListar");
            listaProdutos.ForEach(produto =>
            {
                Console.WriteLine(produto.ToString());
            }
           );

            return Content("ConsultaUmParaMuitos");
        }

        public IActionResult LazyLoading()
        {
            Console.WriteLine("Monta Lista com Lazy ativado");
            var listaProdutos = database.Produtos.Where(p => p.Categoria.Id == 1).ToList();
            Console.WriteLine("Vai Listar");
            listaProdutos.ForEach(produto =>
            {
                Console.WriteLine(produto.ToString());
            }
           );
            return Content("LazyLoading");
        }
    }
}
