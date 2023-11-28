using AutoMapper;
using ListaH1.Data.Providers.MongoDb.Collections;
using ListaH1.Domain.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Data.AutoMapper
{
	public class DomainToCollection : Profile
	{
		public DomainToCollection()
		{
			CreateMap<Produto, ProdutoCollection>();
			CreateMap<Categoria, CategoriaCollection>();
			CreateMap<Fornecedor, FornecedorCollection>();
		}
	}
}