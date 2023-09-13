using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models
{
    public class Str : Term
    {
        public Str(string value, string kind, Location? location = null) : base(kind, location)
        {
            this.value = value;
        }
        public string value {get;set;}
    }
}