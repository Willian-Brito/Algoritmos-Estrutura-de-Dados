using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ListaEncadeada Simples
            // var listaEncadeada = new ListaEncadeada();

            // listaEncadeada.adicionarInicio(1);
            // listaEncadeada.adicionarInicio(2);
            // listaEncadeada.adicionarInicio(3);
            // listaEncadeada.adicionarInicio(4);
            // listaEncadeada.adicionarInicio(5);

            // listaEncadeada.removerInicio();

            // listaEncadeada.removerPosicao(3);
            // listaEncadeada.removerPosicao(1);
            // listaEncadeada.removerPosicao(5);

            // var pesquisa = listaEncadeada.pesquisar(10);

            // if(pesquisa != null)
            //     Console.WriteLine($"Encontrado: {pesquisa.valor}");
            // else    
            //     Console.WriteLine("Não Encontrou");
            
            // listaEncadeada.mostrarLista();
            #endregion

            #region Lista Ecadeada com Extremidade Dupla

            // var listaEncadeadaExtremidadeDupla = new ListaEncadeadaExtremidadeDupla();

            // listaEncadeadaExtremidadeDupla.adicionarInicio(1);
            // listaEncadeadaExtremidadeDupla.adicionarInicio(2);
            // listaEncadeadaExtremidadeDupla.adicionarInicio(3);
            // listaEncadeadaExtremidadeDupla.adicionarInicio(4);
            // listaEncadeadaExtremidadeDupla.adicionarInicio(5);
            
            // listaEncadeadaExtremidadeDupla.adicionarFinal(3);
            // listaEncadeadaExtremidadeDupla.adicionarFinal(2);
            // listaEncadeadaExtremidadeDupla.adicionarFinal(3);
            // listaEncadeadaExtremidadeDupla.adicionarFinal(4);

            // listaEncadeadaExtremidadeDupla.removerInicio();
            // listaEncadeadaExtremidadeDupla.removerInicio();
            // listaEncadeadaExtremidadeDupla.removerInicio();
            // listaEncadeadaExtremidadeDupla.mostrarLista();
            #endregion
        
            #region Lista Duplamente Encadeada
            
            // var listaDuplamenteEncadeada = new ListaDuplamenteEncadeada();

            // listaDuplamenteEncadeada.adicionarInicio(1);
            // listaDuplamenteEncadeada.adicionarInicio(2);
            // listaDuplamenteEncadeada.adicionarInicio(3);
            // listaDuplamenteEncadeada.adicionarInicio(4);
            // listaDuplamenteEncadeada.adicionarInicio(5);

            // // listaDuplamenteEncadeada.adicionarFinal(3);
            // // listaDuplamenteEncadeada.adicionarFinal(4);

            // // listaDuplamenteEncadeada.removerInicio();
            // // listaDuplamenteEncadeada.removerFinal();

            // listaDuplamenteEncadeada.removerPosicao(3);
            // listaDuplamenteEncadeada.removerPosicao(5);
            // listaDuplamenteEncadeada.removerPosicao(1);

            // Console.WriteLine("===== MOSTRAR FRENTE =====");
            // listaDuplamenteEncadeada.mostrarListaFrente();
            
            // Console.WriteLine("");

            // Console.WriteLine("===== MOSTRAR TRAS =====");
            // listaDuplamenteEncadeada.mostrarListaTras();
            
            #endregion
        
            #region PilhaListaEncadeada
            
            // var pilhaListaEncadeada = new PilhaListaEncadeada();

            // pilhaListaEncadeada.empilhar(20);
            // pilhaListaEncadeada.empilhar(40);
            // pilhaListaEncadeada.empilhar(60);
            // pilhaListaEncadeada.empilhar(80);
 

            // pilhaListaEncadeada.desempilhar();
            // pilhaListaEncadeada.desempilhar();
            // pilhaListaEncadeada.desempilhar();
            // pilhaListaEncadeada.desempilhar();

            // var topo = pilhaListaEncadeada.verTopo();
            
            // System.Console.WriteLine(topo);

            #endregion
        
            #region FilaListaEncadeada

            var filaListaEncadeada = new FilaListaEncadeada();

            filaListaEncadeada.enfileirar(20);
            filaListaEncadeada.enfileirar(40);
            filaListaEncadeada.enfileirar(60);
            filaListaEncadeada.enfileirar(80);

            filaListaEncadeada.desenfileirar();
            filaListaEncadeada.desenfileirar();
            filaListaEncadeada.desenfileirar();
            filaListaEncadeada.desenfileirar();


            var inicio = filaListaEncadeada.verInicio();

            System.Console.WriteLine(inicio);

            #endregion
        }
    }
}
