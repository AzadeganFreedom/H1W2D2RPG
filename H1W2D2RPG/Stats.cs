using System.Reflection.Metadata.Ecma335;

namespace H1W2D2RPG
{
    internal class Stats
    {
        private Random rnd = new Random();
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }



        public void GetRolled()
        {
            foreach (var property in GetType().GetProperties())
            {
                property.SetValue(this, rnd.Next(3, 19));
                
            }
        }
        public void ShowStats()
        {
            foreach (var property in GetType().GetProperties())
            {                
                Console.WriteLine(property.Name + ": " + property.GetValue(this));
            }
        }

    }
}
