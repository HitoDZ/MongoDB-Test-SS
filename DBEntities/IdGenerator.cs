using System;

namespace DBEntities
{
    internal static class IdGenerator
    {
        public static long GetId()
        {
            return new Random().Next(0, int.MaxValue);
        }
    }
}