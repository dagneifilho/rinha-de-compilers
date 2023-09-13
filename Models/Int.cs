using System;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models
{
	public class Int : Term
	{
		public Int(string kind, int value, Location? location = null) : base (kind, location)
		{
			this.value = value;
		}
		public int value { get;set;}
	}
}

