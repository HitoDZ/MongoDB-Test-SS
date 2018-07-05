using System;
using System.Collections;
using System.Collections.Generic;

namespace DBEntities
{
    internal static class NameGenerator
    {
        private static List<string> _names;

        static NameGenerator()
        {
            _names = new List<string>{"Vitia", "Colia", "Anatoliy", "Petro", "Pavlo"};
        }

        public static string GetName()
        {
            var next = new Random().Next(0, _names.Count);

            return _names[next];
        }
        
    }
}