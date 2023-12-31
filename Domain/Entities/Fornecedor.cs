﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ListaH1.Domain.Entities { 

    public class Fornecedor : EntidadeBase
	{
		#region Construtor

		public Fornecedor(string nome, string cnpj, string razaoSocial, DateTime dataCadastro, bool ativo)
		{
			Nome = nome;
			Cnpj = cnpj;
			RazaoSocial = razaoSocial;
			DataCadastro = dataCadastro;
			Ativo = ativo;
		}
        public Fornecedor(Guid codigoID,string nome, string cnpj, string razaoSocial, DateTime dataCadastro, bool ativo)
        {
            CodigoID = codigoID;
            Nome = nome;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        #endregion

        #region propriedades

        public Guid CodigoID { get; private set; }
        public string Nome { get; private set; }
		public string Cnpj { get; private set; }
		public string RazaoSocial { get; private set; }
		public DateTime DataCadastro { get; private set; }
		public bool Ativo { get; private set; }


		#endregion

		#region comportamentos

		public void Ativar() => Ativo = true;

		public void Desativar() => Ativo = false;

		public void AlterarNome(string nome) => Nome = nome;
		public void AlterarRazaoSocial(string razaoSocial) => RazaoSocial = razaoSocial;
		public void AlterarCNPJ(string cnpj) => Cnpj = cnpj;


		#endregion
	}
}
