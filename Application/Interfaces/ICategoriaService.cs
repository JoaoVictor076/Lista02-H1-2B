
using ListaH1.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Application.Interfaces
{
	public interface ICategoriaService
	{
		IEnumerable<CategoriaViewModel> ObterTodas();
		Task<CategoriaViewModel> ObterPorId(Guid id);

		Task Adicionar(NovaCategoriaViewModel categoriaViewModel);
		void Atualizar(NovaCategoriaViewModel categoriaViewModel);
	}
}
