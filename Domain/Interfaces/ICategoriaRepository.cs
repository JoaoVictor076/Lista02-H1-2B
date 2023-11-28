
using ListaH1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Domain.Interfaces
{
	public interface ICategoriaRepository
	{
		IEnumerable<Categoria> ObterTodas();
		Task<Categoria> ObterPorId(Guid id);
		Task Adicionar(Categoria categoria);
		Task Desativar(Categoria categoria);
		void Atualizar(Categoria categoria);
	}
}
