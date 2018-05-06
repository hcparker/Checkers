using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class BlackCell: Cell
    {
        
        public BlackCell (Color clr, int x, int y):base(clr,x,y,100, 100) 
        {
        }

        public override bool DoYouHavePieceOnYou ()
        {
            throw new NotImplementedException ();
        }

        public override void MovePiece ()
        {
            throw new NotImplementedException ();
        }
    }
}
