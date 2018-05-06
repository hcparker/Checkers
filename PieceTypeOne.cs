using System;
using SwinGameSDK;
namespace MyGame
{
    public class PieceTypeOne : Piece
    {
        public PieceTypeOne (Color clr, int locX, int locY) : base (clr, locX,locY, 20)
        {
        }

        public override void Move ()
        {
            //
            // this should only move diagnal and forward
            // where to move can be obtaine from mouse position
            // if mouseposition is on rectange and rectangle has no other piece then move piece
            throw new NotImplementedException ();
        }
    }
}
