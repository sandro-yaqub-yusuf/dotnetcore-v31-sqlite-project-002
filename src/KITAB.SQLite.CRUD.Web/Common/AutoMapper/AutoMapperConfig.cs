using KITAB.SQLite.CRUD.Domain.Models;
using KITAB.SQLite.CRUD.Web.ViewModels;
using AutoMapper;

namespace KITAB.SQLite.CRUD.Web.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
