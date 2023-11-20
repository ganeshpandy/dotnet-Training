using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
    class HashTableExample
    {
        static void Main(string[] args)
        {

            HashTableMain hashTableMain = new HashTableMain();//object class HashTableMain
            Hashtable hashtableObj = new Hashtable();

            hashtableObj = hashTableMain.LoadHashtable();

            hashTableMain.DisplayHashTable(hashtableObj);

        }
    }


    class HashTableMain
    {
        public Hashtable LoadHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("EmpID", "10001");
            hashtable.Add("ProjId", "P001");
            hashtable.Add("CompID", "C001");
            return hashtable;
        }


        public void DisplayHashTable(Hashtable hashtable)
        {
            if (hashtable != null && hashtable.Count > 0)
            {
                foreach (DictionaryEntry dictionaryEntry in hashtable)
                {
                    Console.WriteLine("Key  is " + dictionaryEntry.Key);
                    Console.WriteLine("Value  is " + dictionaryEntry.Value);
                }
            }
        }
    }
}
