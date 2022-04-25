using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static string timeConversion(string s)
        {
            if(s.Substring(s.Length-2,2)=="PM")
            {
                int tmp = Convert.ToInt32(s.Substring(0,2));
                if(tmp!=12) tmp = tmp+12;
                return tmp.ToString() + s.Substring(2,s.Length-4);    
            }
            else 
            {
                int tmp = Convert.ToInt32(s.Substring(0,2));
                if(tmp==12) return "00" + s.Substring(2,s.Length-4);
                else return "0" + tmp.ToString() + s.Substring(2,s.Length-4);
            }
        }
        public static string TimeConversion(string s)
        {
            var dt = DateTime.ParseExact(

                s,"hh:mm:sstt",
                CultureInfo.InvariantCulture);

            return $"{dt:HH:mm:ss}";          
            
        }

    }
}
