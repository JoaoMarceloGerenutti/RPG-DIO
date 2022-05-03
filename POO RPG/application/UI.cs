using POO_RPG.src.Entities;
using POO_RPG.src.VideoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.application
{
    public class UI
    {
        public void CleanScreen()
        {
            Console.Clear();
        }

        public void PrintMenu()
        {
            Console.WriteLine("----------DIO DUNGEON---------- \n"
                + "CHOOSE A OPTION \n"
                + "\n"
                + "1) New Game \n"
                + "2) Credits \n"
                + "3) Quit \n"
                + "-------------------------------- \n");
        }

        public void PrintCredits()
        {
            Console.WriteLine("Credits: Created by João Marcelo Gerenutti - GFT START 5 \n");
        }

        public void PrintGameMenu()
        {
            Console.WriteLine("----------INVENTORY---------- \n"
                + "CHOOSE A OPTION \n"
                + "\n"
                + "1) Attack \n"
                + "2) Defend \n"
                + "3) Pass Turn \n"
                + "-------------------------------- \n");
        }

        public void PrintMatch(Map Map, List<Character> HeroesList, List<Character> VillainsList)
        {
            Console.WriteLine(Map);
            Console.WriteLine("----------------HEROES---------------- \n");
            foreach (Character Hero in HeroesList)
            {
                Console.WriteLine(Hero.ToString());
            }

            Console.WriteLine("------------------VS------------------ \n");

            foreach (Character Villain in VillainsList)
            {
                Console.WriteLine(Villain.ToString());
            }
        }
    }
}
