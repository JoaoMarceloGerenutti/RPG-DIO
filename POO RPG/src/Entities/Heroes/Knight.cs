using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int HP, int Level, string HeroType) : base(Name, HP, Level, HeroType)
        {
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(string Opponent, int Damage)
        {
            return this.Name + " Attacked with his Great Sword the Villain " + Opponent + ", Dealing " + Damage + "HP!";
        }

        public string Attack(string Opponent, int Damage, int Bonus)
        {
            if (Bonus > 20)
            {
                return this.Name + " Attacked with his Great Sword the Villain " + Opponent + ", Dealing a Massive Damage of " + Damage + Bonus + "HP!";
            }
            else
            {
                return this.Name + " Attacked with his Great Sword the Villain " + Opponent + ", Dealing " + Damage + "HP!";
            }
        }
    }
}
