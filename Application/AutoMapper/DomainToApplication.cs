using AutoMapper;

using ListaH1.Application.ViewModels;
using ListaH1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Application.AutoMapper
{
	public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<Produto, ProdutoViewModel>();
			CreateMap<Fornecedor, FornecedorViewModel>();
		}
	}
}
