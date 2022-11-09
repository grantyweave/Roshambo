namespace Roshambo
{
    internal class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "Always Rock";
        }

        internal override Roshambo GenerateRoshambo()
        {
            Value = Roshambo.Rock;
            return Value;
        }
    }
}

