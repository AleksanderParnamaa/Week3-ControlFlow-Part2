using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada tähte
            //programm kontrollib kas sisestatud täht on täishäälik või kaashäälik
            //kui sisetatud täht on täishäälik siis programm kuvab täishäälik
            //kui sisestatud täht on kaashäälik siis programm kuvab kaashäälik
            //kasutame Swtichi
            Console.WriteLine("sisesta täht");
            char Letter = Convert.ToChar(Console.ReadLine());
            switch (Letter)
            {
                case 'a':
                    Console.WriteLine("See on täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("See on täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("See on täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("See on täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("See on täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;
            }
           
        }
    }
}
