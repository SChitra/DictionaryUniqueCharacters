using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueStringDictionary
{
    class Program
    {
        /***Implement an algorithm to determine if a string has all unique characters.
        What if you cannot use additional data structures? ***/
        public static bool UniqueCharacters(string str)
        {
            //Create a dictionary to store each character
            Dictionary<char, int> StringDictionary = new Dictionary<char, int>();
            foreach(char character in str)
            {
                //Check the dictionary for duplicate characters
                if (StringDictionary.ContainsKey(character))
                    return false;
                StringDictionary.Add(character, 1);
                
            }
            return true;

        }

        static void Main(string[] args)
        {
            string str = "chittra";
            bool result = UniqueCharacters(str);
            if(result)
                Console.WriteLine("Given string has all Unique Characters");
            else
                Console.WriteLine("String does not have unique characters");
        }
    }
}
