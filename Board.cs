using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
    public static class Board
    {
        static List<Cell> _Cells = new List<Cell> ();
        //
        //
        public static void AddCellsToList(Cell cell){
            _Cells.Add (cell);
        }
        //
        //
        public static List<Cell>GetCell{
            get{
                return _Cells;
            }
        }
        //
        // 
        public static void MovePiece(){
            
        }
    }
}
