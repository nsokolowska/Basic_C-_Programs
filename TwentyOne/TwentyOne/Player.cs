using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player<T>
    {
        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivePlayer { get; set; }

        //public static Game operator+ (Game game, Player Player)
        //{
        //    game.Players.Add(Player);
        //    return game;
        //}
        //public static Game operator- (Game game, Player Player)
        //{
        //    game.Players.Remove(Player);
        //    return game;
        ////}

    }
}
