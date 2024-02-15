using System;


namespace Nombre_Magique
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //  Random classes instance
            Random random = new Random();
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;

            // Generation of number between 0 and 10
            int randomNumber = random.Next(MIN_NUMBER,MAX_NUMBER + 1);
            int NB_LIFE = 2;
            string my_name = Tools_number_magic.ask_my_name();
            bool win_lost_condition = false;
            Displayer.displayer_welcome_user(my_name);
            while (NB_LIFE  > 0)
            {
                Displayer.displayer_nb_life_user(NB_LIFE);
                int number_player = Tools_number_magic.ask_number();
                win_lost_condition = Tools_number_magic.check_game(randomNumber, number_player);

                if (win_lost_condition)
                {
                    break;
                }
                else
                {
                    Displayer.displayer_retry();
                    NB_LIFE--;
                }

            }
            if (win_lost_condition && NB_LIFE >= 0)
            {
                Displayer.displayer_win(my_name);
            }
            else
            {
                Displayer.displayer_lost(my_name, randomNumber);
            }

            
        }
    }
}



