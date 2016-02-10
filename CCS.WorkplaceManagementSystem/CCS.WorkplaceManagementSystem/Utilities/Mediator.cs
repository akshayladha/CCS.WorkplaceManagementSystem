using System;
using System.Collections.Generic;
using System.Linq;

namespace CCS.WorkplaceManagementSystem.Utilities
{
    public static class Mediator
    {
        static IDictionary<string, List<Action<object>>> pl_Dict = new Dictionary<string, List<Action<object>>>();

        public static void Register(string token, Action<object> callback)
        {
            if (!pl_Dict.ContainsKey(token))
            {
                pl_Dict.Add(token, new List<Action<object>>() { callback });
            }
            else
            {
                bool found = false;
                foreach (var item in pl_Dict[token].Where(item => item.ToString() == callback.Method.ToString()))
                {
                    found = true;
                }
                if (!found)
                    pl_Dict[token].Add(callback);
            }
        }

        public static void UnRegister(string token, Action<object> callback)
        {
            if (pl_Dict.ContainsKey(token))
                pl_Dict[token].Remove(callback);
        }

        public static void NotifyColleagues(string token, object args)
        {
            if (pl_Dict.ContainsKey(token))
                foreach (var item in pl_Dict[token])
                {
                    item(args);
                }
        }
    }
}
