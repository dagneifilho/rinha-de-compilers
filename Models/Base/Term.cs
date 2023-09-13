using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace rinha_de_compiladores.Models.Base;
[JsonDerivedType(typeof(Print),"Print")]
[JsonDerivedType(typeof(Str),"Str")]
[JsonDerivedType(typeof(Int), "Int")]
[JsonDerivedType(typeof(Binary), "Binary")]
[JsonDerivedType(typeof(Bool), "Bool")]
[JsonDerivedType(typeof(Tuple), "Tuple")]
public class Term
{
    public Term(string kind, Location? location)
    {
        this.kind = kind;
        this.location = location;
    }
    public Location? location { get;set;}
    public string kind { get;set;}
}
