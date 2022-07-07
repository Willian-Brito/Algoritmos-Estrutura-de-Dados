using System;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade = 5;

            var pilha = new Pilha(capacidade);

            #region Teste Pilha

            // pilha.empilhar(1);
            // pilha.empilhar(2);
            // pilha.empilhar(3);
            // pilha.empilhar(4);
            // pilha.empilhar(6);
            // pilha.empilhar(7);
            // Console.WriteLine(pilha.verTopo());

            // pilha.desempilhar();
            // pilha.desempilhar();
            // pilha.desempilhar();
            // pilha.desempilhar();
            // pilha.desempilhar();
            // pilha.desempilhar();
            // Console.WriteLine(pilha.verTopo());
            #endregion

            #region Teste de Validador de Expressao

            /* 
                0- Ignorar caracteres invalidos
                1- caracter de abertura tem que empilhar
                2- caracter de fechamento tem que desempilhar obs: o fechamento tem que casa com o topo da pilha
            */

            // c[d]        - correto
            // a{b[c]d}e   - correto
            // a{b(c]d}e   - incorreto
            // a[b{c}d]e}  - incorreto 
            // a{b(c)      - incorreto

            var expressao = "a{b(c)";

            Console.WriteLine(pilha.validarExpressao(expressao));
            #endregion
        }
    }
}
