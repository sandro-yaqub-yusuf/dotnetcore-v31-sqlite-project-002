using KITAB.SQLite.CRUD.Domain.Models;
using KITAB.SQLite.CRUD.Infra.Paginacoes;
using System.Collections.Generic;

namespace KITAB.SQLite.CRUD.Application.Produtos
{
    public interface IProdutoService
    {
        void Inserir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(int id);
        Produto ObterPorId(int id);
        List<Produto> ObterTodos();
        PaginacaoLista<Produto> ObterTodosPaginado(string filtro, string ordem, int pagina, int tamanhoPagina);
        void ExecuteSQL(string sql);
        void CriarTabelaProduto();
    }
}
