using System.ComponentModel;

namespace Roshambo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a user player
            //allow user to select opponent
            //play the game
            //print results

            HumanPlayer player = new HumanPlayer();
            Player opponent = SelectOpponent();
            

            Player Winner = Play(player, opponent);

            if (Winner == null)
            {
                Console.WriteLine("It's a tie.");
            }
            else { Console.WriteLine($"{Winner.Name} is the winner."); }

        }

        private static Player Play(HumanPlayer player, Player opponent)
        {
            Roshambo userChoice = player.GenerateRoshambo();
            Roshambo opponentChoice = opponent.GenerateRoshambo();
            Console.WriteLine($"Your opponent '{opponent.Name}' selected {opponentChoice}.");
            Player winner = null;

            string result = player.Play(opponentChoice);

            if (result == "Winner")
            {
                winner = player;
            }
            else if (result == "lose")
            {
                winner = opponent;
            }
            return winner;
        }

        internal static Player SelectOpponent()
        {
            string oppInput = string.Empty;
            Player opponent = null;
            do
            {
                Console.WriteLine("Select your opponent: ");
                Console.WriteLine("1. RockPlayer or 2. RandomPlayer");
                oppInput = Console.ReadLine();

                if (oppInput == "1")
                {
                    // create rock player
                    opponent = new RockPlayer();
                }
                else if (oppInput == "2")
                {
                    // create random player
                    opponent = new RandomPlayer();
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            } while (oppInput != "1" && oppInput != "2" );

            return opponent;
        }
    }

}