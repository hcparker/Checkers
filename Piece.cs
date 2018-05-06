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
        bool _select;
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
            if (Selected) {
                DrawOutline ();
            }
        }
        //
        // property to check if shape is selected
        public bool Selected {
            get {
                return _select;
            }
            set {
                _select = value;
            }
        }
        public int Xlocation{
            get{
                return _locationX;
            }
        }
        //
        //
        public int Ylocation{
            get{
                return _locationY;
            }
        }
        //
        //
        public int Radius{
            get{
                return _radius;
            }
        }
        //
        //
        public abstract void Move ();
        //
        //
        //
        // checks if mouse is on shape
        public bool IsAt (Point2D pt)
        {
            return SwinGame.PointInCircle (pt, _locationX + 100 / 2, _locationY + 100 / 2, Radius);
        }
        //
        //
        public void DrawOutline ()
        {
            SwinGame.DrawCircle (Color.DeepPink, _locationX + 100 / 2 - 2, _locationY + 100 / 2 - 2, Radius + 4);
        }

    }
}
