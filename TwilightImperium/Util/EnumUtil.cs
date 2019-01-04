namespace TwilightImperium.Util
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("ReSharper", "SuspiciousTypeConversion.Global")]
    static class EnumUtil
    {
        public static List<T> GetValues<T>()
        {
            return new List<T>((IList<T>) Enum.GetValues(typeof(T)));
        }
        public static IReadOnlyList<T> GetValuesReadOnly<T>()
        {
            return (IReadOnlyList<T>) Enum.GetValues(typeof(T));
        }

        public static bool Comp<T>(T lhs, T rhs) where T : IConvertible
        {
            return (Convert.ToInt32(lhs) & Convert.ToInt32(rhs)) != 0;
        }
    }
}
