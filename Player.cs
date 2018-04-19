using System;
namespace MyGame
{
    public abstract class Player
    {
        string _name;
        public Player ()
        {
        }
        public abstract void MovePieces ();
    }
}
