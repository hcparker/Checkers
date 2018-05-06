using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
    public class Board
    {
        static List<Cell> _Cells = new List<Cell> ();
        //
        //
        public  void AddCellsToList(Cell cell){
            _Cells.Add (cell);
        }
        //
        //
        public  List<Cell>GetCell{
            get{
                return _Cells;
            }
        }
        public Cell GetSingleCell{
            get{
                return _Cells[0];
            }
        }
        //
        // 
        public void MovePiece(){
            
        }
    }
}
