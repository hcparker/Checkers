using System;
using SwinGameSDK;
namespace MyGame
{
    public class BoardDrawing
    {
        public BoardDrawing ()
        {
        }
        public void drawGreenShape(float x, float y){
            SwinGame.DrawRectangle (Color.Green, x, y, 100, 100);
        }
    }

}
