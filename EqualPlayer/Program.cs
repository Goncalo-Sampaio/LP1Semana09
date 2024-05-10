using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(PlayerClass.Tank, "Ana");
            Player player2 = new Player(PlayerClass.Slayer, "Paulo");
            Player player3 = new Player(PlayerClass.Tank, "Ana");
            HashSet<Player> setOfPlayers = new HashSet<Player>()
                { player1, player2, player3 };

            foreach(Player p in setOfPlayers){
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
