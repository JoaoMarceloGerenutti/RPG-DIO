using POO_RPG.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.VideoGame
{
    public class GameMatch
    {
        private Map Map;
        private List<Character> HeroesList;
        private List<Character> VillainsList;
        public bool EndGame = false;

        public GameMatch(string MapName, List<Character> HeroesList, List<Character> VillainsList)
        {
            this.Map = new Map(MapName);
            this.HeroesList = new List<Character>(HeroesList);
            this.VillainsList = new List<Character>(VillainsList);
        }
    }
}
