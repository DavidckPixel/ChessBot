using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_bot
{
    class Pawn : Piece
    {
        public Pawn(int x, int y, char color) : base(x, y, color) { }

        public override void Move(Board board)
        {
            int getal = this.start ? 1 : 2;

            BaseMove.baseMove(board, 0, -1, getal, this);
            BaseMove.baseMove(board, -1, -1, 1, this);
            BaseMove.baseMove(board, 1, -1, 1, this);
        }
    }
}
