using rinha_de_compiladores.Models;
using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores;

public static class Functions
{
    public static void HandlePrint(Term term)
    {
        string output = string.Empty;
        switch (term.kind)
        {
            case "Str":
                Str str = (Str)term;
                output = str.value;
                break;
            case "Int":
                Int number = (Int)term;
                output = number.value.ToString();
                break;
            case "Bool":
                Bool boolean = (Bool) term;
                output = boolean.value.ToString();
                break;
            case "Tuple":
                Models.Tuple tuple = (Models.Tuple)term;
                dynamic first = tuple.first;
                dynamic second = tuple.second;


                output = $"({first.value}, {second.value})";
                break;
           default:
                throw new NotSupportedException();
        }
        Console.WriteLine(output);
    }
    public static Term HandleBinaryOp(Term lhs, Term rhs, string operation)
    {
        switch (operation)
        {
            case "Add":
                return Soma(lhs,rhs);
                
            default:
                throw new NotSupportedException();
        }
    }

    private static Term Soma(Term lhs, Term rhs)
    {
        switch ((lhs.kind, rhs.kind))
        {
            case ("Int", "Int"):
                Int lhsI = (Int)lhs;
                Int rhsI = (Int)rhs;
                int rtnInt = lhsI.value + rhsI.value;
                return new Int("Int",rtnInt,null);
            case ("Str", "Int"):
                Str lhsS = (Str)lhs;
                rhsI = (Int)rhs;
                string rtnStr = lhsS.value + rhsI.value.ToString();
                return new Str(rtnStr, "Str", null);
            case ("Int", "Str"):
                lhsI = (Int)lhs;
                Str rhsS = (Str)rhs;
                rtnStr = lhsI.value.ToString() + rhsS;
                return new Str(rtnStr,"Str",null);
                
            default:
                throw new NotSupportedException();
        }
    }
}
