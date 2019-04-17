using Loja.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;
        public int ProdPorPage = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.OrderBy(p => p.Nome)
            .Skip((pagina - 1) * ProdPorPage).Take(ProdPorPage);

            return View(produtos);
        }
    }
}