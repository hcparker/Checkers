using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
    public static class BoardSetup
    {
        
        
        public static void SetUpBoard (Board board)
        {
            int x = 0;
            int y = 0;
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 100;
                    y = row * 100;
                    if ((row % 2) != (col % 2)) {
                        board.AddCellsToList (new WhiteCell (Color.White, x, y));


                    } else {
                        board.AddCellsToList (new BlackCell (Color.Black, x, y));
                    }
                }
            }


        }
        //
        // this will setup piece 
        // on top of board cells
        // 
        public static void SetupPices(Board board){
            //
            // calling PicesTypeOne method
            SetupPicesTypeOne (board);
            //
            // calling PicesTypeSecond method
            SetupPicesTypeSecond (board);
        }
        //
        //
        // calling PicesTypeOne method
        private static void SetupPicesTypeOne(Board board){
            int x, y;
            for (int row = 0; row < 3; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 200;
                    y = row * 100;
                    if(row%2!=0){
                        x = 100+ col *200;
                        y = row * 100;  
                    }
                    //
                    // 
                    // we adding piece to list
                    board.GetSingleCell.AddPieceToList (new PieceTypeOne (Color.Red, x, y));

                }
            }
        }
        //
        //
        //
        // calling PicesTypeSecond method
        private static void SetupPicesTypeSecond (Board board)
        {
            int x, y;
            for (int row = 5; row < 9; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 200;
                    y = row * 100;
                    if (row % 2 != 0) {
                        x = 100 + col * 200;
                        y = row * 100;
                    }
                    //
                    // 
                    // we adding piece to list
                    board.GetSingleCell.AddPieceToList (new PieceTypeSecond (Color.Yellow, x, y));

                }
            }
        }
  
    }
}