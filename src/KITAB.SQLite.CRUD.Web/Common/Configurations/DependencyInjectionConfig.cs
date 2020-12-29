using KITAB.SQLite.CRUD.Application.Notificadores;
using KITAB.SQLite.CRUD.Application.Produtos;
using KITAB.SQLite.CRUD.Infra.Produtos;
using KITAB.SQLite.CRUD.Web.Extensions;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace KITAB.SQLite.CRUD.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<INotificadorService, NotificadorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}
