using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Generics
{
    /// <summary>
    /// This is the C#1 analog of GenericStaticClass.
    /// Notice that I had to cast the key and value because
    /// they are intrinsically objects.
    /// 1. Execution-time type checking as opposed to compile-time type checking.
    /// 2. All of the casts make code harder to read and understand
    /// 3. Performance hit because of type-checking and boxing/unboxing.
    /// </summary>
    public static class NonGenericStaticClass
    {
        public static void GreenEggsAndHam()
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";

            Hashtable frequencies = CountWords(text);
            foreach (DictionaryEntry entry in frequencies)
            {
                string word = (string)entry.Key;
                int frequency = (int)entry.Value;  //unboxing int
                Console.WriteLine("{0}:{1}", word, frequency);
            }
        }

        private static Hashtable CountWords(string text)
        {
            Hashtable frequency = new Hashtable();

            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word] = (int)frequency[word] + 1;  //boxing int
                }
                else
                {
                    frequency[word] = 1; //boxing int
                }
            }

            return frequency;
        }
    }
}
