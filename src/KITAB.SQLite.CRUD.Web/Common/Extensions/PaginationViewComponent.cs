using Microsoft.AspNetCore.Mvc;

namespace KITAB.SQLite.CRUD.Web.Extensions
{
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
