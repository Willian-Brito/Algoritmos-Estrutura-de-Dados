using System;

namespace TabelaHash
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var TabelaHash = new Dicionario();
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"=> Tabela Hash");
                PularLinha(1);

                Console.WriteLine("1- Inserir Elemento");
                Console.WriteLine("2- Remover Elemento");
                Console.WriteLine("3- Buscar Elemento");
                Console.WriteLine("4- Imprimir Elementos");
                Console.WriteLine("0- Sair");

                PularLinha(1);
                Console.Write("-> ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1 : Inserir(TabelaHash); break;
                    case 2 : Remover(TabelaHash); break;
                    case 3 : Buscar(TabelaHash); break;
                    case 4 : Imprimir(TabelaHash); break;
                }
            }
            while (opcao != 0);            
        }

        #region Metodos
        
        #region Inserir
        private static void Inserir(Dicionario TabelaHash)
        {
            Console.Write("Qual é a Palavra do Dicionario: ");
            var palavra = Console.ReadLine();

            Console.Write("Qual é o Significado da Palavra: ");
            var descricao =  Console.ReadLine();

            TabelaHash.Adicionar(palavra, descricao);
        }
        #endregion

        #region Remover
        private static void Remover(Dicionario TabelaHash)
        {
            Console.Write("Qual é a Palavra do Dicionario: ");
            var palavra = Console.ReadLine();

            TabelaHash.Remover(palavra);
        }
        #endregion

        #region Buscar
        private static void Buscar(Dicionario TabelaHash)
        {
            Console.Write("Qual é a Palavra do Dicionario: ");
            var palavra = Console.ReadLine();

            var No = TabelaHash.Buscar(palavra);

            if(No.palavra == palavra)
            {
                Console.WriteLine($"=> Palavra Encontrada: {No.palavra} - {No.descricao}");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Aluno não encontrado!");
            Console.ReadKey();
        }
        #endregion

        #region Imprimir
        private static void Imprimir(Dicionario TabelaHash)
        {
            TabelaHash.Imprimir();
            Console.ReadKey();
        }        
        #endregion

        #region PularLinha
        private static void PularLinha(int quantidade)
        {
            for(int i = 0; i < quantidade; i++)
                System.Console.WriteLine("");
        }
        #endregion

        #endregion
    }
}
