using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    class SortedListMain
    {

        static void Main(string[] args)
        {
            SortedListExample sortedListExample = new SortedListExample();//object for SortedListExample
            SortedList sortedListobj = new SortedList();//SortedList object
            sortedListobj = sortedListExample.LoadSortedList();//storing LoadSortedList
            sortedListExample.DisplaySortedList(sortedListobj);

        }
    }
    class SortedListExample
    {
        public SortedList LoadSortedList()
        {
            SortedList sortedList = new SortedList() {
            { 101, "alex" }, { 102, "ban" }, { 103, "charles" },{104,"Daniel"},{105,"Ethy"} };
            Console.WriteLine();
            Console.WriteLine("ContainsKey");
            Console.WriteLine("=============");
            if (sortedList.ContainsKey(106))
            {
                sortedList[106] = "fazel";
            }
            
            DisplaySortedList(sortedList);
            Console.WriteLine("=============");
            Console.WriteLine("Remove");
            Console.WriteLine("=============");
            sortedList.Remove(101);
            DisplaySortedList(sortedList);
            return sortedList;
        }
        public void DisplaySortedList(SortedList sortedList)
        {
            if (sortedList != null && sortedList.Count > 0)
            {
                foreach (DictionaryEntry dictionaryEntry in sortedList)
                {
                    Console.WriteLine("Key  is " + dictionaryEntry.Key);
                    Console.WriteLine("Value  is " + dictionaryEntry.Value);
                }
            }
        }


    }

}