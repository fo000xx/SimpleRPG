using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineModelsNS;

namespace EngineViewModelsNS
{
    public class GameSession
    {
        Player CurrentPlayer { get; set; }
        public GameSession() 
        {
            var CurrentPlayer = new Player();
            CurrentPlayer.Name = "Ben";
            CurrentPlayer.Gold = 100000;
        }
    }
}
