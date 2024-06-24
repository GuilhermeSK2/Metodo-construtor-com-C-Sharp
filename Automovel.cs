using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCS
{
    internal class Automovel
    {
            string marca;
            string modelo;
            int ano;
        public Automovel() 
        {
            marca = "Toyota";
            modelo = "Supra";
            ano = 1994;
        }

        public static void Main(string[] args)
        {
            Automovel Carro01 = new Automovel();
            Console.WriteLine(Carro01.marca);
            Console.WriteLine(Carro01.modelo);
            Console.WriteLine(Carro01.ano);
        }
    }
}
