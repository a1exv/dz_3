using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.WorldOfTanks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] t34 = new Tank[5]{new Tank(), new Tank(), new Tank(), new Tank(), new Tank()};
            Tank[] Pantera = new Tank[5] { new Tank(), new Tank(), new Tank(), new Tank(), new Tank() };
            int wincountt34 = 0;
            
                for (var i = 0; i < 5; i++)
                {
                    if ((t34[i] ^ Pantera[i]) == true)
                    {
                        wincountt34++;
                    }
                }
                if (wincountt34 > 2) Console.WriteLine("T34 win!");
                else Console.WriteLine("Pantera win!");
            
            
            //atch (Exception e)
            //
            //   Console.WriteLine(e.Message);
            //
        }
    }
}
