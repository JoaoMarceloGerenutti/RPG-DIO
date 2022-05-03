using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_RPG.src.VideoGame
{
    public class Map
    {
        private string MapName;

        public Map(string mapName)
        {
            GetMapName = mapName;
        }

        public string GetMapName { get => MapName; set => MapName = value; }

        public override string ToString()
        {
            return "----------------MAP: " + this.MapName + "---------------- \n";
        }
    }
}
