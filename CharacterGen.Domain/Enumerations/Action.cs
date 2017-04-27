using Headspring;

namespace CharacterGen.Domain.Enumerations
{
    public class Action : Enumeration<Action, string>
    {
        public Action(string value, string displayName) : base(value, displayName)
        {
            
        }

        public static readonly Action StandardAction = new Action("ACTION", "Action");
        public static readonly Action MoveAction = new Action("MOVE", "Move Action");
        public static readonly Action BonusAction = new Action("BONUS", "Bonus Action");

    }
}