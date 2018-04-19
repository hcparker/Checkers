using System;
using SwinGameSDK;
namespace MyGame
{
    public abstract class Piece
    {
        Color clr;
        Point2D location;
        public Piece ()
        {
        }
        public abstract void Move ();
    }
}
