using System;
using SwinGameSDK;
namespace MyGame
{
    public static class BoardDrawing
    {
     
      
        public static void DrawBoard(Board board){
            foreach (Cell cell in board.GetCell) {
                cell.drawShape ();
            }
        }
        //
        //
        public static void DrawPieces(Board board){
            foreach (Piece piece in board.GetSingleCell.GetPieces) {
                piece.DrawPiece ();
            }
        }
    }
}