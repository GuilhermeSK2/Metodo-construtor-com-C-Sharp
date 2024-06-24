using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCS
{
    internal class Musica
    {
        public string nomeMusica;
        public string generoMusical;
        public string artista;
        public int anoLancamento;

        public Musica(string nomeDaMusica, string generoDaMusica, string autorDaMusica,int anoDeLancamento)
        {
            nomeMusica = nomeDaMusica;
            generoMusical = generoDaMusica;
            artista = autorDaMusica;
            anoLancamento = anoDeLancamento;
        }

        public static void Main(string[] args)
        {
            Musica juicy = new Musica("Juicy", "Hip Hop","Notorious B.I.G" , 1994);
            Console.WriteLine("Nome da música: " + juicy.nomeMusica);
            Console.WriteLine("Gênero musical: " + juicy.generoMusical);
            Console.WriteLine("Artista: " + juicy.artista);
            Console.WriteLine("Ano de lançamento: " + juicy.anoLancamento);
        }
    }
}
