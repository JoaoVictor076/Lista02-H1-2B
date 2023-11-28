﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Domain.ValueObjects
{
	public class Dimensoes
	{
		public decimal Altura { get; private set; }
		public decimal Largura { get; private set; }
		public decimal Profundidade { get; private set; }

		public Dimensoes(decimal altura, decimal largura, decimal profundidade)
		{
			Altura = altura;
			Largura = largura;
			Profundidade = profundidade;
		}

		public string DescricaoFormatada()
		{
			return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
		}

		public override string ToString()
		{
			return DescricaoFormatada();
		}
	}
}