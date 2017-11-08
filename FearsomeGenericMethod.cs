using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class FearsomeGenericMethod
    {
        /// <summary>
        /// The List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter) method in action
        /// </summary>
        public static void Demo()
        {
            List<int> integers = GetListOfInts();

            Converter<int, double> converterDelegate2 = new Converter<int, double>(TakeSquareRoot);
            Converter<int, double> converterDelegate = TakeSquareRoot;

            // Using the List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter) method
            List<double> doubles = integers.ConvertAll<double>(converterDelegate);

            foreach(double d in doubles)
            {
                Console.WriteLine(d);
            }
        }

        static List<int> GetListOfInts()
        {
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            return integers;
        }

        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
