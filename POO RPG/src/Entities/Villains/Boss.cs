using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.Entities
{
    public class Boss : Character
    {
        public Boss(string Name, int HP, int Level, string HeroType) : base(Name, HP, Level, HeroType)
        {
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(string Opponent, int Damage)
        {
            return this.Name + " Attacked the Hero " + Opponent + "Dealing " + Damage + "HP!";
        }
    }
}
