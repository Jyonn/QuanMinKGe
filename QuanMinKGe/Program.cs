using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanMinKGe
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            try
            {
                result = NetConnect.HttpGet("http://kg.qq.com/node/play?s=2uhejv2QKwzLA2zh&g_f=personal");
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Connect Error...");
            }
            bool isMatch = Regex.IsMatch(result, "window.__DATA__ = (.*?); </script>");
            Console.WriteLine(isMatch);
            MatchCollection matchCollection = Regex.Matches(result, "window.__DATA__ = (.*?); </script>");
            Console.WriteLine(matchCollection.Count);
        }
    }
}
