using System.Diagnostics;
using System.Text.Json;
using rinha_de_compiladores;
using rinha_de_compiladores.Models;
using rinha_de_compiladores.Models.Base;

var stopWatch = new Stopwatch();
stopWatch.Start();
var expression = GetStdin().expression;
Eval(expression);

stopWatch.Stop();
Console.WriteLine("Time: " + stopWatch.Elapsed);

FileNode GetStdin()
{
    var json = Console.In.ReadToEnd();
    json = json.Replace("kind", "$type");
    return JsonSerializer.Deserialize<FileNode>(json);
}




dynamic Eval(Term term)
{
    var param = term.kind is not null ? term.kind : term.GetType().Name;
    switch (param)
    {
        case "Int":
            var number = (Int) term;
            return new Int(param, number.value, number.location);
        case "Str":
            var str = (Str)term;
            return new Str(str.value,param,str.location);
        case "Tuple":
            var tuple = (rinha_de_compiladores.Models.Tuple)term;
            return new rinha_de_compiladores.Models.Tuple(tuple.first, tuple.second, param, tuple.location);
        case "Print":
            var print = (Print)term;
            var value = Eval(print.value) as Term;
            Functions.HandlePrint(value);
            return null;
        case "Bool":
            var boolean = (Bool)term;
            return new Bool(boolean.value,param, boolean.location);
        case "Binary":
            var bin = (Binary) term;
            var lhs = Eval(bin.lhs);
            var rhs = Eval(bin.rhs);
            return Functions.HandleBinaryOp(lhs,rhs,bin.op);
        default:
            throw new NotSupportedException();
    }
}