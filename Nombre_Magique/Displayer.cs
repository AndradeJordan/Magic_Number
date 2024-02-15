using System;


namespace Nombre_Magique
{
    public class Displayer
    {
        public static void displayer_ask_number()
        {
            Console.WriteLine("Which is your number ? ");
        }
        public static void displayer_ask_number_condition(int condi = 0)
        {
            if (condi != 0)
            {
                Console.WriteLine("You need to take an integer !");
            }
            else
            {
                Console.WriteLine("Sorry !! You need to choose a number between 1 and 10 ");
            }
            
        }
        public static void displayer_ask_name()
        {
            Console.WriteLine("What's your name ?");
        }
        public static void displayer_ask_name_condition()
        {
            Console.WriteLine("Sorry your name cannot be empty :)");
        }
        public static void displayer_check_game(int condi )
        {
            if (condi == 0)
            {
                Console.WriteLine("the goal is lower :D !");
            }
            else
            {
                Console.WriteLine("The goal is higher :D !");
            }

        }

        public static void displayer_win(string name)
        {
            Console.WriteLine($"Congratulations {name} !!!");
        }

        public static void displayer_lost(string name, int randomvalue)
        {
            Console.WriteLine($"Sorry {name} !!! you lost :( !!!");
            Console.WriteLine($"a Random value Was :  {randomvalue} for {name}");
        }
        public static void displayer_welcome_user(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        public static void displayer_nb_life_user(int NB_LIFE)
        {
            Console.WriteLine($"Life's numbers : {NB_LIFE}");
        }

        public static void displayer_retry()
        {
            Console.WriteLine("Sorry let's retry !");
        }

    }
}
