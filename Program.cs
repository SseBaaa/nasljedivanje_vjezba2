using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_vjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Unesi x: ");
            x.Postotak =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi y: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi z: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());

            double zbroj = x.Postotak + y.Postotak + z.Postotak;

            if(zbroj!= 100)
            {
                Console.WriteLine("Neispravan unos podataka");
            }
            if(zbroj == 100)
            {
                if(x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima procedurarlno sa: " + x.Postotak);
                }
                if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima Objektno sa: " + y.Postotak);
                }
                if (z.Postotak > y.Postotak && z.Postotak > x.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima Funkcionalno sa: " + z.Postotak);
                }
            }
            Console.ReadKey();

        }
    }

    class ProgramskiJezik
    {
        double postotak;

        public double Postotak { get => postotak; set => postotak = value; }
    }

    class Proceduralni : ProgramskiJezik
    {

    }

    class Objektni : ProgramskiJezik
    {

    }

    class Funkcionalni : ProgramskiJezik
    {

    }
}
