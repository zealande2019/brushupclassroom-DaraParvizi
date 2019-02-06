using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum K1 = new KlasseRum();
           
            K1.SemesterStart = new DateTime(2018,4,9);
            List<Studerende> KlasseListe = new List<Studerende>()
            {
                new Studerende("Dara", 23, 12),
                new Studerende("Mikaeil", 4, 12)
        };

           


            foreach (var st in KlasseListe)
            {
                Console.WriteLine(KlasseListe);
            }
         

            Console.ReadKey();

            
            
          

            


        }
    }
}
