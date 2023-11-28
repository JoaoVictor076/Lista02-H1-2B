
using ListaH1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Domain.Interfaces
{
	public interface IFornecedorRepository
	{
		IEnumerable<Fornecedor> ObterTodos();
        public Task Adicionar(Fornecedor fornecedor);
		public Task Atualizar(Fornecedor fornecedor);
        public Task Reativar(Fornecedor fornecedor);
        public Task Desativar(Fornecedor fornecedor);
		public Task<Fornecedor> ObterPorId(Guid id);
		public Task<IEnumerable<Fornecedor>> ObterPorNome(string nomeFornecedor);

	}
}


