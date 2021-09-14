using System;

namespace InstagramAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your year of birth");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number <2008)
            {
                Console.WriteLine("Oled Piisavalt vana et konto luua");
            }
            else if (Number >2008)
            {
                Console.WriteLine("Oled liiga noor et konto luua");
            }
            else
            {
                Console.WriteLine("oled piisavalt vana");
            }
        }
    }
}
