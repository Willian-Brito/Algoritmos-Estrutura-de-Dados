using System;
using System.Collections.Generic;
using System.Linq;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade = 5;

            #region FilaCircular
            
            // var filaCircular = new FilaCircular(capacidade);

            // filaCircular.enfilerar(1);
            // filaCircular.enfilerar(2);
            // filaCircular.enfilerar(3);
            // filaCircular.enfilerar(4);
            // filaCircular.enfilerar(5);

            // filaCircular.desenfileirar();
            // filaCircular.desenfileirar();

            // filaCircular.enfilerar(6);
            // filaCircular.enfilerar(7);

            // Console.WriteLine(filaCircular.verInicio());

            // filaCircular.imprimirFila();       

            // Console.WriteLine($" Inicio: {filaCircular.posicaoInicial} | Final: {filaCircular.posicaoFinal}"); 
            #endregion

            #region Fila de Prioridade

            /* Prioridade: Numeros Menores com Prioridade Maior */
            var filaPrioridade = new FilaPrioridade(capacidade);

            filaPrioridade.enfileirar(30);
            filaPrioridade.enfileirar(50);
            filaPrioridade.enfileirar(10);
            filaPrioridade.enfileirar(40);
            filaPrioridade.enfileirar(20);
            filaPrioridade.enfileirar(2);

            filaPrioridade.desenfileirar();
            filaPrioridade.desenfileirar();
            filaPrioridade.desenfileirar();
            filaPrioridade.enfileirar(5);
            filaPrioridade.enfileirar(7);

            Console.WriteLine(filaPrioridade.verInicio());
            filaPrioridade.imprimirFila();
            #endregion   
        }
    }
}
