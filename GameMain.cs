using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 800);
            // SwinGame.ShowSwinGameSplashScreen();
            Board board = new Board ();
            BoardSetup.SetUpBoard (board);
            BoardSetup.SetupPices (board);

            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                SwinGame.DrawFramerate(0,0);
                //
                // drawing cells on the board
                BoardDrawing.DrawBoard (board);
                BoardDrawing.DrawPieces (board);
                //BoardSetup.SetupPices (board);
                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}