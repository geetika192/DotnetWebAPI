using System;
using System.Collections;
namespace Hashtablep
{
    class Program
    {
        static void Main(string[] args)
        {
           var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};
           // foreach(DictionaryEntry kvp in city)
               // Console.WriteLine("key:{0} , value : {1}",kvp.Key,kvp.Value);
            /* Dictionary<int,string> dictionary=new Dictionary<int, string>();
            dictionary.Add(3,"Bihar");
            dictionary.Add(4,"Gorakhpur");
            dictionary.Add(5,"Kanpur");
            Hashtable ht =new Hashtable(dictionary);
            Console.WriteLine(ht.Count); */
            //UPDATE
           /*  city["India"]="noida";
            if(city.ContainsKey("Mumbai"))
            {
                city["Mumbai"]="Kolkata";
            }
            foreach(DictionaryEntry kvp in city)
                Console.WriteLine("key:{0} , value : {1}",kvp.Key,kvp.Value);
 */
        }
    }
}