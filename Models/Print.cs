using rinha_de_compiladores.Models.Base;

namespace rinha_de_compiladores.Models;

public class Print : Term
{
    public Term value {get;set;}
    public void Handle()
    {
        string output = string.Empty;
        switch (value.GetType().Name)
        {
            case "Str":
                Str str = (Str)value;
                output = str.value;
                break;
            default:
                throw new NotSupportedException();
        }
        Console.WriteLine(output);
    }
}
