using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada pin koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud pin kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud Pin kood on vale ütleb programm "Vale PIN.Proovi uuesti"
            Console.WriteLine("Palun Sisesta Pin Kood");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale PIN.Proovi uuesti");
            }


        }
    }
}
