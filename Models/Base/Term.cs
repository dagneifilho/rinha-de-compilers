using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace rinha_de_compiladores.Models.Base;
[JsonDerivedTypeAttribute(typeof(Print),"Print")]
[JsonDerivedTypeAttribute(typeof(Str),"Str")]
public class Term
{
    public Term() { }
    public Location location { get;set;}
}
