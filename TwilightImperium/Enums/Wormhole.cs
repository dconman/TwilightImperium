namespace TwilightImperium.Enums
{
    using System;

    [Flags]
    internal enum Wormhole
    {
        None = 0,
        Alpha = 1 << 0,
        Beta  = 1 << 1,
        Delta = 1 << 2
    }

}