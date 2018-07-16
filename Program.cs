using System;

namespace guessing_game {
    class Program {
        static void Main (string[] args) {
            // Random r = new Random ();
            // int randomNumber = r.Next (1, 100);

            int randomNumber = RandomPrime();
            int guess = GuessNum ();
            CheckNum (guess, randomNumber);
            

        }

        static void CheckNum (int guess, int answer) {
            int count = 0;
            while (guess != answer) {
                if (guess > answer) {
                    Console.WriteLine ("Your guess is too high!");
                    count++;
                } else if (guess < answer) {
                    Console.WriteLine ("Your guess is too low!");
                    count++;
                }
                guess = GuessNum ();
            }

            Console.WriteLine ("Your guess is correct! " + "It took " + count + " turns " );
        }

        static int GuessNum () 
        {
            Console.Write ("Pick a number between 1 and 100: ");
            string guess = Console.ReadLine ();
            return int.Parse (guess);
        }

        static bool IsPrime (int num)
        {
            for (int i = 2; i < num / 2; i++) 
            {
                if (num % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        static int RandomPrime ()
        {
            Random r = new Random ();
            int randomNumber = r.Next (1, 100);

            while(IsPrime(randomNumber) != true)
            {
                randomNumber = r.Next(1, 100);
            }
            return randomNumber;
        }

            // STRETCH: Add a wagering system.  
            // Start your player with 100 "coins".  
            // Allow them to bet as much as they want each turn.  
            // They win if they guess in under 8 tries and lose if not.
            // Keep count of their bankroll
    }
}