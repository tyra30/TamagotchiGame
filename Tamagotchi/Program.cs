using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
           tamagotchi avatar = new tamagotchi();

           avatar.name = ChooseName();
           Choices(avatar);
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
        //Choose name for tamagotchi

        static void Choices(tamagotchi tc)
        {
            string answer;
            tc.PrintStats();
           

            Console.WriteLine("Taking care of a tamagotchi is hard work, what would you like to do know, teach, feed, greet, or simply nothing");

            answer = Console.ReadLine();

            if (answer == "teach" || answer == "Teach")
            {
                tc.Teach(Console.ReadLine());
            }
            if (answer == "feed" || answer == "Feed")
            {
                tc.Feed();
            }
            if (answer == "greet" || answer == "Greet")
            {
                tc.Hi();
            }
            if (answer == "nothing" || answer == "Nothing" || answer == "simply nothing")
            {
                Console.WriteLine("alrighty, poor tamagotchi, arent you supposed to take care of you pet?");
            }
        }
        //What do you want to do for you tamagotchi
    }
}
