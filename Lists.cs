using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Lists
    {
        List<string> list = new List<string>();

        public Lists()
        {}

        /// <summary>
        ///     Arrays derive from System.Array.  They're the only collections with direct support from CLR.
        /// For example, it can create and index them, and support them directly in foreach loops, meaning
        /// that it uses the Length property and the array indexer, rather than creating an iterator object.
        /// But the performance difference is usually negligible.
        ///     Like List<T> class, arrays support methods such as ConvertAll, FindAll, and BinarySearch, 
        /// but these methods are static methods of the Array class, taking the array as the first parameter.
        /// </summary>
        public void PlayWithArray()
        {
            string[] listArray = new string[10];

            listArray[0] = "a";
            listArray[1] = "a";
            listArray[2] = "a";
            listArray[3] = "a";
            listArray[4] = "a";
            listArray[5] = "a";
            listArray[6] = "a";
            listArray[7] = "a";
            listArray[8] = "a";
            listArray[9] = "a";

            foreach (var s in listArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(listArray.Count());

            Console.WriteLine(listArray.Length);
        }

        /// <summary>
        /// LinkedList<T> does not implement IList<T>.
        /// This is because it doesn't obey the implied contract of efficient access by index.
        /// The extension method ElementAt<T> supports access by index.
        /// It is a doubly-linked list, each node has a reference to next and previous.
        /// Each node is a LinkedListNode<T>
        /// </summary>
        public void PlayWithLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddFirst("Mercury");
            linkedList.AddAfter(linkedList.Last, "Venus");
            linkedList.AddAfter(linkedList.Last, "Earth");
            linkedList.AddAfter(linkedList.Last, "Mars");
            linkedList.AddAfter(linkedList.Last, "Jupiter");
            linkedList.AddAfter(linkedList.Last, "Saturn");
            linkedList.AddAfter(linkedList.Last, "Uranus");
            linkedList.AddAfter(linkedList.Last, "Neptune");

            ((ICollection<string>)linkedList).Add("Pluto");

            (linkedList as ICollection<string>).Add("MakeMake");

            foreach (var node in linkedList)
            {
                Console.WriteLine(node);
            }

            string ourPlanet = linkedList.ElementAt(2);
            Console.WriteLine($"Our planet is {ourPlanet}");

        }


    }
}
