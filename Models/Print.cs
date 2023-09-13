using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models;

public class Print : Term
{
    public Print(string kind, Term value, Location? location = null) : base(kind, location)
    {
        this.value = value;
    }
    public Term value {get;set;}

}
