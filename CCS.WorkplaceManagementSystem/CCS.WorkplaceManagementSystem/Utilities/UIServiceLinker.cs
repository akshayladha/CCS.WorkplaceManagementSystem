using System;
using System.Collections.Generic;
using System.Linq;

namespace CCS.WorkplaceManagementSystem.Utilities
{
    public static class UIServiceLinker
    {
        static IDictionary<string, List<Action<object>>> containerDictionary = new Dictionary<string, List<Action<object>>>();

        public static void Register(string token, Action<object> callback)
        {
            if (!containerDictionary.ContainsKey(token))
            {
                containerDictionary.Add(token, new List<Action<object>>() { callback });
            }
            else
            {
                bool found = false;
                foreach (var item in containerDictionary[token].Where(item => item.ToString() == callback.Method.ToString()))
                {
                    found = true;
                }
                if (!found)
                    containerDictionary[token].Add(callback);
            }
        }

        public static void UnRegister(string token, Action<object> callback)
        {
            if (containerDictionary.ContainsKey(token))
                containerDictionary[token].Remove(callback);
        }

        public static void Notify(string token, object args)
        {
            if (containerDictionary.ContainsKey(token))
                foreach (var item in containerDictionary[token])
                {
                    item(args);
                }
        }
    }
}
