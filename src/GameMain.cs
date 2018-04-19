using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 1800, 1600);
           // SwinGame.ShowSwinGameSplashScreen();
            BoardDrawing drawing = new BoardDrawing ();

            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);

                //drawing.drawYellowShape (0, 120);
                SwinGame.DrawFramerate(0,0);
                drawing.SetUpBoard (0, 20);
                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}