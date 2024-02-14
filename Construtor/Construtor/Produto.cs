﻿using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto() 
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this ()
        {
            Nome = nome;
            Preco = preco;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}