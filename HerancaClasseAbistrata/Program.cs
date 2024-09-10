using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaClasseAbistrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal MeuCachorro = new Cachorro();
            MeuCachorro.Nome="Rex";
            MeuCachorro.FazerSom();

            Animal MeuGato = new Gato();
            MeuGato.Nome = "miauzin";
            MeuGato.FazerSom();
            


        }
    }
}
