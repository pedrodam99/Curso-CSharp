using System;
using System.Collections.Generic;

namespace Secao_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<string> list = new List<string>();

         list.Add("mario");
         list.Add("joao");
         list.Add("ana");

         foreach (string item in list)
         {
            System.Console.WriteLine(item);
         }
        }
    }
}
