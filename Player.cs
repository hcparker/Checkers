using System;
namespace MyGame
{
    public abstract class Player
    {
        string _name;
        public Player (string nme)
        {
            _name = nme;
        }
        public abstract void MovePieces ();
    }
}
