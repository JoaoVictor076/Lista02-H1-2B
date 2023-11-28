using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Domain.Entities
{
	public abstract class EntidadeBase
	{
		public Guid CodigoId { get; set; }

		protected EntidadeBase()
		{
			CodigoId = Guid.NewGuid();
		}

	}
}
