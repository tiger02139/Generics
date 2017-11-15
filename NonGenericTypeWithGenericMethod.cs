using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class NonGenericTypeWithGenericMethod
    {
        static List<T> MakeList<T>(T first, T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

        public static void PrintList()
        {
            List<string> list = MakeList<string>("Uranus", "Neptune");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
