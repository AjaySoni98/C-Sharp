using System;
using System.Collections.Generic;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var hTab = new Dictionary<object, object>();

            hTab.Add("DDR", "Dadar");
            hTab.Add("BDTS", "Bandra");
            hTab.Add("COR", "Chittorgarh");
            hTab.Add("BHL", "Bhilwara");
            hTab.Add("BER", "Beawar");

            foreach(KeyValuePair<object, object> de in hTab)
            {
                System.Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }

            System.Console.WriteLine("Count: {0}", hTab.Count);
            hTab.Remove("BER");
            System.Console.WriteLine("Removing one entry count: {0}", hTab.Count);
            System.Console.WriteLine("DDR present in hTab: {0}", hTab.ContainsKey("DDR"));
            System.Console.WriteLine("Dadar present in hTab: {0}", hTab.ContainsValue("Dadar"));
        }
    }
}