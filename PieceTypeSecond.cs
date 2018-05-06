using System;
using SwinGameSDK;
namespace MyGame
{
    public class PieceTypeSecond: Piece
    {
        public PieceTypeSecond (Color clr, int locX, int locY) : base (clr, locX, locY, 20)
        {
        }

        public override void Move ()
        {
            throw new NotImplementedException ();
        }
    }
}
