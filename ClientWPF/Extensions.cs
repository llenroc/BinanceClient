﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Net.ClientWPF
{
    public static class Extensions
    {
        public static TV GetValue<TK,TV>(this Dictionary<TK,TV> dictionary, TK key)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];
            return default(TV);
        }

        public static IEnumerable<Type> GetTypesWithAttribute(this Assembly assembly, Type attribute)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(attribute, true).Length > 0)
                {
                    yield return type;
                }
            }
        }
    }
}
