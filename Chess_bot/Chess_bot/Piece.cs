using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_bot
{
    abstract class Piece
    {
        protected bool start;
        protected int x;
        protected int y;
        protected char color;

        public abstract void Move(Board board);

        public Piece(int x,int y,char color)
        {
            this.start = false;
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
