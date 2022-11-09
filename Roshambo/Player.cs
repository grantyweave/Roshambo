using System.ComponentModel;
using System.Numerics;
using System.Reflection;

namespace Roshambo
{
    internal abstract class Player
    {
        internal string Name { get; set; }
        internal Roshambo Value { get; set; }
        internal abstract Roshambo GenerateRoshambo();

        internal string Play(Roshambo opponentRoshambo)
        {
            
            if (Value == Roshambo.Rock && opponentRoshambo == Roshambo.Paper)
            {
                return "lose";
            }

            if (Value == Roshambo.Rock && opponentRoshambo == Roshambo.Scissors)
            {
                return "Winner";
            }

            if (Value == Roshambo.Paper && opponentRoshambo == Roshambo.Rock)
            {
                return "Winner";
            }
            if (Value == Roshambo.Paper && opponentRoshambo == Roshambo.Scissors)
            {
                return "lose";
            }

            if (Value == Roshambo.Scissors && opponentRoshambo == Roshambo.Paper)
            {
                return "Winner";
            }
            if (Value == Roshambo.Scissors && opponentRoshambo == Roshambo.Rock)
            {
                return "lose";
            }
            
                return "Tie";
            

        }
        
    }
}