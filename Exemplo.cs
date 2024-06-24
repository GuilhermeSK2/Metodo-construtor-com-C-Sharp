using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCS
{
    internal class Exemplo
    {
        public string modelo;

        public Exemplo() 
        {
            modelo = "Mustang";
        }
        public static void Main(string[] args)
        {
            Exemplo Ex01 = new Exemplo();
            Console.WriteLine("O modelo do carro é: " + Ex01.modelo);
        }
    }
}
