using KITAB.SQLite.CRUD.Application.Notificadores;
using Microsoft.AspNetCore.Mvc;

namespace KITAB.SQLite.CRUD.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotificadorService _notificadorService;

        protected BaseController(INotificadorService notificadorService)
        {
            _notificadorService = notificadorService;
        }

        protected bool OperacaoValida()
        {
            return !_notificadorService.TemNotificacao();
        }
    }
}
