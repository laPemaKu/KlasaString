using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo sa klasom string";

            //ispis broja znakova u stringu
            Console.WriteLine("Broj znakova u recenici: {0}", recenica.Length );

            //ispis malim i velikim slovima
            Console.WriteLine("Ispis velikim slovima: {0}" +
                "\nIspis malim slovima: {1}", recenica.ToUpper(), recenica.ToLower());

            //substring metoda
            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(recenica.Length-5, 5));

            //zamjena znakova u stringu
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            //Razdvajanje stringa u više stringova
            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            //umetanje znakova u string
            Console.WriteLine(recenica.IndexOf("radimo"));
            Console.WriteLine(recenica.Insert(recenica.IndexOf("radimo")-1, "intezivno "));

            Console.ReadKey();
        }
    }
}
