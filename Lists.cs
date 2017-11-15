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
        string[] listArray = new string[10];
        LinkedList<string> listLinked = new LinkedList<string>();

        public Lists()
        {}

        /// <summary>
        /// Arrays derive from System.Array.  They're the only collections with direct support from CLR.
        /// </summary>
        public void PlayWithArray()
        {
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


    }
}
