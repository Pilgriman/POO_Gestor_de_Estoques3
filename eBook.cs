using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Estoques3
{
    [System.Serializable]
    class eBook: Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public eBook(string nome , float preco , string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
           
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possivel dar entrada no estoque de um E-book pois é um produto digital");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no E-book { nome } ");
            Console.WriteLine($"Digite a Qtd. de vendas que voçê quer dar entrada:");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($" Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("======================");
        }
    }
}
