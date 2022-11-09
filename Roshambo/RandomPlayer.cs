using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Roshambo
{
    internal class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            Name = "random";
        }

        internal override Roshambo GenerateRoshambo()
        {
            Roshambo userSelection = Roshambo.Unknown;

            Random random = new Random();
            int rInt = random.Next(1, 3);

            Value = (Roshambo)rInt;
            return Value;


        }
    }
}

