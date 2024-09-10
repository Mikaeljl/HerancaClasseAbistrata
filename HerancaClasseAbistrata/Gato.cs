using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaClasseAbistrata
{
    internal class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} Esta latindo");
        }
    }
}
