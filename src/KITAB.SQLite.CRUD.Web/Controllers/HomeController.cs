﻿using KITAB.SQLite.CRUD.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KITAB.SQLite.CRUD.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projeto()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro/{id:length(3,3)}")]
        public IActionResult Errors(int id)
        {
            ErrorViewModel modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Mensagem = "Tente novamente mais tarde ou contate nosso suporte...";
                modelErro.Titulo = "Ocorreu um erro !!!";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Mensagem = "A página que está procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte...";
                modelErro.Titulo = "Ops !!! Página não encontrada...";
                modelErro.ErroCode = id;
            }
            else if (id == 403)
            {
                modelErro.Mensagem = "Você não tem permissão para fazer isto...";
                modelErro.Titulo = "<<< Acesso Negado >>>";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(500);
            }

            return View("Error", modelErro);
        }
    }
}
