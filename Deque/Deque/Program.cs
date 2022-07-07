using System;

namespace Deques
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade = 5;
            var dequeCicular = new Deque(capacidade);

            dequeCicular.adicionarFinal(5);
            dequeCicular.adicionarFinal(10);
            dequeCicular.adicionarInicio(3);
            dequeCicular.adicionarInicio(2);
            dequeCicular.adicionarFinal(11);
            dequeCicular.removerInicio();
            dequeCicular.removerFinal();

            Console.WriteLine(dequeCicular.buscarValorInicio());
            Console.WriteLine(dequeCicular.buscarValorFinal());

            dequeCicular.imprimirDeque();

        }
    }
}

