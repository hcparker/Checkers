using System;
using SwinGameSDK;
namespace MyGame
{
    public abstract class Piece
    {
        Color clr = Color.Black;
        Point2D location;
        public Piece ()
        {
        }
        public abstract void Move ();
    }
}
