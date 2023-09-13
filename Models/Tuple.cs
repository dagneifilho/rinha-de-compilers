using System;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models
{
	public class Tuple : Term
	{
		public Tuple(Term first, Term second, string kind, Location? location = null) : base(kind, location)
		{
			this.first = first;
			this.second = second;
		}
		public Term first { get;set; }
		public Term second { get;set; }
	}
}

