using System;
using SwinGameSDK;

namespace MyGame
{
    public static class BoardSetup
    {
        
        
        public static void SetUpBoard ()
        {
            int x = 0;
            int y = 0;
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 100;
                    y = row * 100;
                    if ((row % 2) != (col % 2)) {
                        Board.AddCellsToList (new WhiteCell (Color.White, x, y));


                    } else {
                        Board.AddCellsToList (new BlackCell (Color.Black, x, y));
                    }
                }
            }


        }
        //
        // this will setup piece 
        // on top of board cells
        //Cell cell
        public static void SetupPices(Cell cell){
            int x, y;
            for (int row = 0; row < 3; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 200;
                    y = row * 100;
                   //SwinGame.FillCircle (Color.Red, x + 100 / 2, y + 100 / 2, 20);

                }
            }
        }
    }
}