using System;
using SwinGameSDK;
namespace MyGame
{
    public class BoardDrawing
    {
        public BoardDrawing ()
        {
        }
        public void drawGreenShape (float x, float y)
        {
            SwinGame.FillRectangle (Color.Green, x, y, 100, 100);
            SwinGame.FillRectangle (Color.Green, x, y, 100, 100);
        }
        public void drawYellowShape (float x, float y)
        {
            SwinGame.DrawRectangle (Color.Yellow, x, y, 100, 100);
            SwinGame.FillRectangle (Color.Yellow, x, y, 100, 100);
        }
        //
        //
        public void SetUpBoard (float x, float y)
        {
            for (int row = 0; row < 8; row++) {
                for (int col = 0; col < 8; col++) {
                    x = col *  100;
                    y = row * 100;
                    if ((row % 2) == (col % 2)){
                        drawGreenShape (x, y);
                    } else{
                        drawYellowShape (x, y);
                    }
                }
            }


        }

    }
}