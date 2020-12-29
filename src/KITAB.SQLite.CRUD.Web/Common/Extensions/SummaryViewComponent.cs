using KITAB.SQLite.CRUD.Application.Notificadores;
using KITAB.SQLite.CRUD.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KITAB.SQLite.CRUD.Web.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificadorService _notificadorService;

        public SummaryViewComponent(INotificadorService notificadorService)
        {
            _notificadorService = notificadorService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Notificacao> notificacoes = await Task.FromResult(_notificadorService.ObterNotificacoes()).ConfigureAwait(false);

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }
    }
}
