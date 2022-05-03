using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int HP, int Level, string HeroType) : base(Name, HP, Level, HeroType)
        {
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(string Opponent, int Damage)
        {
            return this.Name + " Cast a Spell on the Villain " + Opponent + ", Dealing " + Damage + "HP!";
        }

        public string Attack(string Opponent, int Damage, int Bonus)
        {
            return this.Name + " Cast a Spell on the Villain " + Opponent + ", Dealing " + Bonus + "HP!";
        }
    }
}
