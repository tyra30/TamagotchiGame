using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
           tamagotchi avatar = new tamagotchi();

           avatar.name = ChooseName();
           
            Console.ReadLine();



        }

        static string ChooseName()
        {
        string name = "";
        Console.WriteLine("Hello, congrats on becoming a tamagotchi parent, what would you like to call your little friend?");

        name = Console.ReadLine();

        Console.WriteLine($"What a cute name, take good care of {name}");

        return name;
        }

        static string Choices(tamagotchi tc)
        {
            tc.PrintStats();

            Console.WriteLine("")
        }
    }
}
