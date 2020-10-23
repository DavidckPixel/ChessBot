using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_bot
{
    static class BaseMove
    {
        public static void baseMove(Board board, int x, int y, int amount, Piece piece)
        {
            int tempx, tempy;

            for (int z = 1; z <= amount; z++)
            {
                tempx = piece.x + z * x;
                tempy = piece.y + z * y;

                if (board.board[tempy, tempx] != null)
                {
                    if (board.board[tempy, tempx].color != piece.color)
                    {
                        board.moves.Add(new aMove(piece, tempx, tempy));
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                board.moves.Add(new aMove(piece, tempx, tempy));
            }

        }
    }
}
