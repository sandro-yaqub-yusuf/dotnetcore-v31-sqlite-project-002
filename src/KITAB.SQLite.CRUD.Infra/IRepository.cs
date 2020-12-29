using KITAB.SQLite.CRUD.Infra.Paginacoes;
using System.Collections.Generic;

namespace KITAB.SQLite.CRUD.Infra
{
    public interface IRepository<T> where T : class
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(int id);
        T ObterPorId(int id);
        List<T> ObterTodos();
        void ExecuteSQL(string sql);
        PaginacaoLista<T> ObterTodosPaginado(string filtro, string ordem, int pagina, int tamanhoPagina);
    }
}
