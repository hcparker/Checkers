using System;
using SwinGameSDK;
namespace MyGame
{
    public abstract class Piece
    {
        Color color;
        Point2D location;
        // this can have list which player can access 
        public Piece (Color clr, Point2D loc)
        {
            color = clr;
            location = loc;
        }
        public abstract void Move ();
    }
}
