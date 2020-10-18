using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Program
    {
        static void Main(string[] args)
        {
           // Person hun = new Person("MF63051002", "GanBayar", 57, "Er");
           // Console.WriteLine(hun.Hunii_medeelel_avah());
            Student oyut = new Student("TA02122302", 
                "bataa","geRelMaa", 18, "Em", 
                "P.IT20D002", "IT", 2.97, 37);
            Console.WriteLine(oyut.Oyutnii_medeelel_avah());
            Worker ajil = new Worker("HG85021325", 
                "ganBAT","BATZOLBOO", 35, "Er", 
                "Tsahilgaan damjuulah vndesnii svljee", 
                "Undriin tsahilgaanchin", "VS1526", 
                70353500);
            Console.WriteLine(ajil.Ajiltnii_medeelel_avah());
            Console.ReadLine();
        }
    }
}
