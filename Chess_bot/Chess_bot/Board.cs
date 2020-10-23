using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_bot
{
    class Board
    {
        public Piece[,] board = new Piece[8, 8];
        public List<aMove> moves = new List<aMove>();

        public Board()
        {
            //Create board here
        }

        public Board(Board oldBoard)
        {
        }
    }

    struct aMove
    {
        Piece piece;
        int x;
        int y;

        public aMove(Piece piece, int x, int y)
        {
            this.piece = piece;
            this.x = x;
            this.y = y;
        }
    }
}
