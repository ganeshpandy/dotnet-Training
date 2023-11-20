using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using System.IO;

namespace hashtable
{
     class Program
    {
        static void Main(string[] args)
        {
            Hashtable Teams = new Hashtable();
            Console.WriteLine("Finals");
            Teams.Add(0,"India");
            Teams.Add(1, "Austraila");            
            foreach(DictionaryEntry entry in Teams) 
            {
                Console.WriteLine("Teams: {0}, Teams: {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("======================================================");
            Console.WriteLine("Squads");
            var squad = new Hashtable()
            { 
                {"India","Rohit,Gill,Iyer ,kohil,Rahul,Surya,jadeja,shami,Bumrah,Kuldeep,siraj"},
                {"Austraila","Pat Cummins, Steve Smith, Alex Carey, Josh Inglis, Sean Abbott, Ashton Agar, Cameron Green, Josh Hazlewood, Travis Head, Mitch Marsh, Glenn Maxwell, Marcus Stoinis, David Warner, Adam Zampa, Mitchell Starc" }
            };
            foreach(DictionaryEntry entry in squad)
            {
                Console.WriteLine("Squad:{0},Squad:{1}",entry.Key,entry.Value);
            }
            if (!squad.ContainsKey("Surya"))
            {
                squad["Surya"] = "Ashwin";
            }
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("ContainsKey");
            Console.WriteLine("====================================");
            foreach (DictionaryEntry entry in squad)
            {
                Console.WriteLine("squad:{0},squad:{1}", entry.Key, entry.Value);
            }
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("ContainsValue");
            Console.WriteLine("====================================");
            if (!squad.ContainsValue("Surya"))
            {
                squad["Surya"] = "Ashwin";
            }
            foreach (DictionaryEntry entry in squad)
            {
                Console.WriteLine("squad:{0},squad:{1}", entry.Key, entry.Value);
            }
            
            Console.WriteLine("====================================");
            Console.WriteLine("Remove");
            Console.WriteLine("====================================");
            //squad.Remove("Surya");
            if (squad.ContainsKey("Surya"))
            {
                squad.Remove("Surya");
                foreach (DictionaryEntry entry in squad)
                {
                    Console.WriteLine("squad:{0},squad:{1}", entry.Key, entry.Value);
                }
            }
        }
    }
}