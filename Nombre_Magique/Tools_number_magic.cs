using System;


namespace Nombre_Magique
{
    public class Tools_number_magic
    {
        public static int ask_number()
        {
            int number_int = 0;
            while (number_int == 0)
            {
                Displayer.displayer_ask_number();
                string number = Console.ReadLine();
                try
                {
                    number_int = int.Parse(number);
                    if (number_int <= 0 || number_int > 10)
                    {
                        Displayer.displayer_ask_number_condition();
                        number_int = 0;
                    }
                }
                catch
                {
                    Displayer.displayer_ask_number_condition(1);
                    number_int = 0;
                }
            }
            return number_int;


        }

       public static string ask_my_name()
        {
            string name = "";
            while (name == "")
            {
                Displayer.displayer_ask_name();
                name = Console.ReadLine();
                name = name.Trim();
                if (name == "")
                {
                    Displayer.displayer_ask_name_condition();
                }
            }
            return name;
        }
        public static bool check_game(int goal, int val)
        {
            bool condition = false;
            if (goal == val)
            {
                condition = true;
            }
            else if (goal < val)
            {
                Displayer.displayer_check_game(0);
            }
            else
            {
                Displayer.displayer_check_game(1);
            }
            return condition;
        }
    }
}
