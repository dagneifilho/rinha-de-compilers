using System;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models
{
	public class Binary : Term
	{
		public Binary(string kind, Term lhs, string op, Term rhs, Location? location = null) : base(kind, location)
		{
			this.lhs = lhs;
			this.op = op;
			this.rhs = rhs;
		}
		public Term lhs { get;set; }
		public string op { get;set; }
		public Term rhs { get;set; }
	}
}

