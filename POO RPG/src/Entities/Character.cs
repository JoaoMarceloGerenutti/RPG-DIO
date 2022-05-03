using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.Entities
{
    public abstract class Character
    {
        public string Name;
        public int HP;
        public int Level;
        public string HeroType;

        public Character(string Name, int HP, int Level, string HeroType)
        {
            this.Name = Name;
            this.HP = HP;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public virtual string Attack(string Opponent, int Damage)
        {
            return this.Name + " Attacked the Enemy " + Opponent + ", Dealing " + Damage + "HP!";
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n"
                + "HP: " + this.HP + "\n"
                + "Level: " + this.Level + "\n"
                + "Hero Type: " + this.HeroType + "\n"
                + "--------------------------------------- \n";
        }
    }
}
