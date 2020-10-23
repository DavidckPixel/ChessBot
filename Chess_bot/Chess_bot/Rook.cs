using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_bot
{
    class Rook : Piece
    {
        public Rook(int x, int y, char color) : base(x, y, color) { }

        public override void Move(Board board)
        {
            int getal = this.start ? 2 : 1;

            for(int x = 0; x<getal; x++) //Front walk move;
            {
                board.moves.Add(new aMove(this, this.x, this.y + x));
                if (board.board[this.x, this.y+x] != null) { break; }
            }

            if(board.board[this.x - 1, this.y + 1] != null) { board.moves.Add(new aMove(this, this.x - 1, this.y + 1)); }
            if (board.board[this.x + 1, this.y + 1] != null) { board.moves.Add(new aMove(this, this.x + 1, this.y + 1)); }
        }
    }
}
