using System;
using DelegateFunc.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * DELEGATE FUNC:
            - • Representa um método que recebe zero ou mais argumentos, e retorna um valor
                - public delegate TResult Func<out TResult>();
                - public delegate TResult Func<in T, out TResult>(T obj);
                - public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
                - public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
                - +12 sobrecargas mudando somente o numero de tipos e de argumentos.

            * PROBLEMA EXEMPLO:
            - Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
