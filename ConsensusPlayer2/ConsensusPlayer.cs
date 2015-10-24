﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsensusPlayer2
{
    public class ConsensusPlayer
    {
        public static int Main(string[] args)
        {
            ConsensusPlayer player = new ConsensusPlayer();
            Board board = JsonConvert.DeserializeObject<Board>(args[0]);
            return player.chooseMove(board);
        }
        public int chooseMove(Board board)
        {
            bool[] moves = board.ValidMoves("w");
            for (int i = 0; i < 64; i++)
            {
                if (moves[i])
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
