using POO_RPG.application;
using POO_RPG.src.Entities;
using POO_RPG.src.VideoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandomico = new Random();

            // Map Selection.
            Map map = new Map("Florest");

            // Character Creation.
            List<Character> HeroesList = new List<Character>();
            Knight arus = new Knight("Arus", numeroRandomico.Next(42, 70), 42, "Knight");
            HeroesList.Add(arus);

            Wizard jennica = new Wizard("Jennica", numeroRandomico.Next(43, 70), 43, "Wizard");
            HeroesList.Add(jennica);

            Ninja naruto = new Ninja("Naruto", numeroRandomico.Next(41, 70), 41, "Ninja");
            HeroesList.Add(naruto);

            List<Character> VillainsList = new List<Character>();
            Knight maleficus = new Knight("Maleficus", numeroRandomico.Next(99, 200), 99, "Devil");
            VillainsList.Add(maleficus);

            GameMatch GameMatch = null;

            // Game Main Menu.
            UI ui = new UI();

            int menuOption = 0;
            do
            {
                ui.PrintMenu();

                menuOption = Convert.ToInt32(Console.ReadLine());
                ui.CleanScreen();
            } while (menuOption < 1 || menuOption > 3);

            switch (menuOption)
            {
                case 1:
                    GameMatch = new GameMatch(map.GetMapName, HeroesList, VillainsList);
                    break;

                case 2:
                    ui.PrintCredits();
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

            // New Game.
            while (GameMatch.EndGame == false)
            {
                ui.PrintMatch(map, HeroesList, VillainsList);

                GameMatch.EndGame = true;
            }
            Console.ReadKey();
        }
    }
}
