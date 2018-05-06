using System;
using SwinGameSDK;
namespace MyGame
{
    public static class BoardDrawing
    {
     
        public static void DrawRedPieces (float x, float y)
        {

            for (int row = 0; row < 2; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 100;
                    y = row * 100;
                    SwinGame.FillCircle (Color.Red, x + 100 / 2, y + 100 / 2, 20);
                }
            }
          
        }
        public static void DrawWhitePieces (float x, float y)
        {
            int count =4;
            for (int row = 0; row < 2; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col * 100;
                    y = row + count * 100;
                    //SwinGame.FillCircle (Color.Green, x + 100 / 2, y + 100 / 2, 20);
                }
                //for (int irow = 0; irow < 2; irow++) {
                //    for (int col = 0; col < 8; col++) {
                //        x = col * 100;
                //        y = irow + 5 * 100;
                //        SwinGame.FillCircle (Color.Green, x + 100 / 2, y + 100 / 2, 20);
                //    }

                //}
            }

        }
        public static void DrawBoard(){
            foreach (Cell cell in Board.GetCell) {
                cell.drawShape ();
            }
        }

    }
}