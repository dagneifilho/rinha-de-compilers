using System.Diagnostics;
using System.Text.Json;
using rinha_de_compiladores.Models;
using rinha_de_compiladores.Models.Base;

var stopWatch = new Stopwatch();
stopWatch.Start();
var expression = ReadJson(@"/Users/macbook/Projects/rinha-de-compiladores/sourceRinha/source.rinha.json").expression;

Eval(expression);

stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed);

FileNode ReadJson(string path){
    using (StreamReader sr = new StreamReader(path)){
        string json = sr.ReadToEnd();
        json = json.Replace("kind","$type");
        return JsonSerializer.Deserialize<FileNode>(json);
    }
}



void Eval(Term term)
{
    switch (term.GetType().Name)
    {
        case "Print":
            var print = term as Print;
            print.Handle();
            break;
        default:
            throw new NotSupportedException();
    }
}