namespace Roshambo
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
        }

        internal override Roshambo GenerateRoshambo()
        {
            Roshambo userSelection = Roshambo.Unknown;
            do
            {
                Console.WriteLine("Enter: ");
                Console.WriteLine("1. Rock, 2. Paper, 3. Scissors");
                string userInput = Console.ReadLine();

                //if (userInput == "1")
                //{
                //    userSelection = Roshambo.Rock;
                //}
                 
                //else if (userInput == "2")
                //{
                //    userSelection = Roshambo.Paper;
                //}
                //else if (userInput == "3")
                //{
                //    userSelection = Roshambo.Scissors;
                //}

                //else
                //{
                //    Console.WriteLine("Invalid Input.");
                //}

                userSelection = userInput switch
                {
                    "1" => Roshambo.Rock,
                    "2" => Roshambo.Paper,
                    "3" => Roshambo.Scissors,
                    _ => Roshambo.Unknown
                };
                Console.WriteLine($"You selected {userInput}");

            } while (userSelection == Roshambo.Unknown);
            Value = userSelection;
            return Value;


        }
    }
}