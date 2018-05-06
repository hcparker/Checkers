using System;
using SwinGameSDK;
namespace MyGame
{
    public abstract class Piece
    {
        Color color;
        int _locationX;
        int _locationY;
        int _radius;
        // this can have list which player can access 
        public Piece (Color clr, int locX, int locY, int radius)
        {
            color = clr;
            _locationX= locX;
            _locationY = locY;
            _radius = radius;


        }
        //
        // it will draw the pieces to passed location
        public void DrawPiece(){
            SwinGame.FillCircle (color, _locationX + 100 / 2, _locationY + 100 / 2, _radius);
        }
        //
        //
        public abstract void Move ();
    }
}
