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
            this.board[7, 4] = new Pawn(4, 7, 'W');
            this.board[4, 4] = new Pawn(4, 4, 'B');
            this.board[6, 3] = new Pawn(3, 6, 'B');
            this.board[6, 5] = new Pawn(5, 6, 'B');

            this.board[7, 4].Move(this);

            foreach(aMove x in moves)
            {
                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
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

        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
