using System;
using SwinGameSDK;
namespace MyGame
{
    public class HumanPlayer: Player
    {
        
        public HumanPlayer (string name) : base (name)
        {
        }
		public override void MovePieces ()
		{
            //
            // should ask the piece to move itself
            // then player needs to know which piece belongs to which player
            throw new NotImplementedException ();
		}
	}
}
