using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Estoques3
{
    [System.Serializable]
    class Curso: Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            
            Console.WriteLine($"Adicionar vagas no curso{nome}");
            Console.WriteLine($"Digite a Qtd. de vagas que voçê quer dar entrada:");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vagas no curso { nome } ");
            Console.WriteLine($"Digite a Qtd. de vagas que voçê quer dar baixa:");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($" Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("======================");

        }
    }
}
