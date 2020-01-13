using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Models
{
    public class Filter<T> where T : class, new()
    {
        Dictionary<string, object> properties;

        void gg()
        {
            int x = 3;
            properties.Add("hi", x);
        }
        //string getProperties()
        //{
        //    PropertyInfo[] s = typeof(T).GetProperties();
        //}
    }
}
