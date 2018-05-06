using System;
using SwinGameSDK;
using System.Collections.Generic;
namespace MyGame
{
    public abstract class Cell
    {
        Color _color;
        int _loc_x;
        int _loc_y;
        int _height;
        int _width;
        List<Piece> _pieces = new List<Piece> ();
        public Cell(Color clr, int x, int y, int height, int width){
            _color = clr;
            _loc_x = x;
            _loc_y = y;
            _height = height;
            _width = width;
        }

        //
        //
        public  Color Color {
            get{
                return _color;
            }
        }
        //
        //
        public  int XLocation {
            get{
                return _loc_x;
            }
            set{
                _loc_x = value;
            }
           
        }
        //
        //
        public int YLocation {
            get {
                return _loc_y;
            }
            set {
                _loc_y = value;
            }

        }
        //
        //
        public int Width{
            get{
                return _width;
            }

        }
        //
        //
        public int Height{
            get{
                return _height;
            }
        }
        //
        //this is used to draw cells on the board
        public void drawShape ()
        {
            SwinGame.FillRectangle (Color, XLocation, YLocation, Width, Height);
        }
        //
        //
        public List<Piece> GetPieces{
            get{
                return _pieces;
            }

        }
        //
        // this will add piece to list 
        public void AddPieceToList (Piece piece){
            _pieces.Add (piece);
        }
        //
        //
        //
        // method which
        public void SelectedShapesAt (Point2D pt)
        {
            foreach (Piece s in _pieces) {
                s.Selected = s.IsAt (pt);
            }
        }
        public abstract bool DoYouHavePieceOnYou ();
        public abstract void MovePiece ();

    }
}
