using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCS
{
    internal class Filme
    {
        public string nomeFilme;
        public string generoFilme;
        public int anoLancamento;

        public Filme (string nomeDoFilme, string generoDoFilme, int anoDeLancamento )
        {
            nomeFilme = nomeDoFilme;
            generoFilme = generoDoFilme;
            anoLancamento = anoDeLancamento;
        }

        public static void Main(string[] args)
        {
            Filme babyDriver = new Filme("Baby Driver", "Ação", 2017);
            Console.WriteLine("O gênero do filme é " + babyDriver.generoFilme);
        }
    }
}
