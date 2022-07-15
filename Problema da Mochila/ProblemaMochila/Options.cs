using CommandLine;

namespace ProblemaMochila
{ 
    public class Options
    {
        [Option('a', "algorithm", Required = true, HelpText = "Algoritmos possíveis (dumb, recursive, dynamic)")]
        public string Algorithm { get; set; }

        [Option('t', "totalItems", Required = false, HelpText = "Total de Itens")]
        public int TotalItems { get; set; }

        [Option('s', "seed", Required = false, HelpText = "Semente")]
        public int Seed { get; set; }
        
        [Option('v', "values", Required = false, HelpText = "Vetor com valores de cada item entre colchetes e com virgula (ex: [60, 100, 120])")]
        public string Values { get; set; }

        [Option('w', "weights", Required = false, HelpText = "Vetor com pesos de cada item entre colchetes e com virgula (ex: [10, 20, 30])")]
        public string Weights { get; set; }

        [Option('W', "teste", Required = false, HelpText = "Capacidade da mochila")]
        public int Store { get; set; }
    }
}