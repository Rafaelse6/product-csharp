using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Produto
    {
        public string Nome;
        public double Preco;

        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
    }
}