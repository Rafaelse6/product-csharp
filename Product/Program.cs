﻿using System;
using System.Globalization;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.0, 10);
            p.SetNome("T");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}