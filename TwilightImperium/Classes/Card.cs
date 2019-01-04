namespace TwilightImperium.Classes
{
    using System;

    internal abstract class Card
    {
        public Action<Player> OnGain;
        public Action<Player> OnLose;
    }
}