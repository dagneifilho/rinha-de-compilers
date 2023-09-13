using System;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models
{
	public class Bool : Term
	{
		public Bool(bool value, string kind, Location? location = null) : base(kind, location)
		{
			this.value = value;
		}
		public bool value { get;set; }
	}
}

