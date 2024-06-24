using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCS
{
    internal class ExemploBYD
    {
        public string nomeCarro;
        public string modeloCarro;
        public int anoCarro;
        public string corCarro;
        public string combustivel;

        public ExemploBYD(string nomeDoCarro, string modeloDoCarro, int anoDoCarro, string corDoCarro, string combustivelDoCarro) // Método construtor com passagem de parâmetros para facilitar a inserção de dados nos atributos de cada objeto criado.
        { 
            nomeCarro = nomeDoCarro;
            modeloCarro = modeloDoCarro;
            anoCarro = anoDoCarro;
            corCarro = corDoCarro;
            combustivel = combustivelDoCarro;
        }

        public static void Main (string [] args)
        {
            ExemploBYD BYD = new ExemploBYD("BYD", "Dolphin", 2025, "Vermelho", "Elétrico");
            Console.WriteLine("O nome do carro é " + BYD.nomeCarro);
            Console.WriteLine("O modelo do carro é " + BYD.modeloCarro);
            Console.WriteLine("O ano do carro é " + BYD.anoCarro);
            Console.WriteLine("A cor do carro é " + BYD.corCarro);
            Console.WriteLine("O tipo de combustível do carro é " + BYD.combustivel);
        }
    }
}
