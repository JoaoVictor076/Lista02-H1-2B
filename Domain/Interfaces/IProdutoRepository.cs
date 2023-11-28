
using ListaH1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Domain.Interfaces
{
	public interface IProdutoRepository
	{
		IEnumerable<Produto> ObterTodos();
        Task<Produto> ObterProdutoCodigo(Guid id);
        Task<IEnumerable<Produto>> ObterPorNome(string nomeProduto);


		Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
        Task Ativar(Produto produto);
        Task Desativar(Produto produto);
        Task AlterarPreco(Produto produto, decimal valor);
        Task AtualizarEstoque(Produto produto, int quantidade);



    }
}
