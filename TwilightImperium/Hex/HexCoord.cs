namespace TwilightImperium.Hex
{
    using System;

    public struct HexCoord
    {
        public static readonly HexCoord CreussLocation = new HexCoord(512, 512, 512);

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public HexCoord(int x, int y, int z)
        {
            if(x + y + z != 0) throw new ArgumentException($"Arguments were {x}, {y}, {z}. Arguments must sum to zero.");
            X = x;
            Y = y;
            Z = z;
        }

        public static HexCoord operator +(HexCoord lhs, HexCoord rhs) => new HexCoord(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        public static HexCoord operator -(HexCoord lhs, HexCoord rhs) => new HexCoord(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType()) return false;
            var rhs = (HexCoord) obj;
            return X == rhs.X && Y == rhs.Y && Z == rhs.Z;
        }

        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }

        public override int GetHashCode()
        {
            return ((X + 512) << 20) + (Y + 512 << 10) + Z + 512;
        }

        private static int Distance(HexCoord start, HexCoord end) =>
            (Math.Abs(start.X - end.X) + Math.Abs(start.Y - end.Y) + Math.Abs(start.Z - end.Z)) / 2;

        private static HexCoord DirectionToCoord(Direction dir)
        {
            switch (dir)
            {
                case Direction.Self:
                    return new HexCoord(0,0,0);
                case Direction.N:
                    return new HexCoord(0,1,-1);
                case Direction.NE:
                    return new HexCoord(1,0,-1);
                case Direction.SE:
                    return new HexCoord(1,-1,0);
                case Direction.S:
                    return new HexCoord(0,-1,1);
                case Direction.SW:
                    return new HexCoord(-1,0,1);
                case Direction.NW:
                    return new HexCoord(-1,1,0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(dir), dir, "Invalid Direction");
            }
        }
    }
}