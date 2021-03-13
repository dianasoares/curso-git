
using System;

namespace Primeiro
{
    class Produto
    {
      
        public string Nome { get;  set; }
        public double Preco { get;  set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void  RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public void MostraDados()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: {Preco} -  Qtde em estoque: {Quantidade} - Valor em estoque: {Quantidade*Preco}");
        }

    }

   
}
