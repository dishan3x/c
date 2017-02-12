using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double pi = 3.14;
             int intpi = (int)pi;

             Random ran = new Random();

             Console.WriteLine("random number is = " +( ran.Next(1,100)));
             Console.WriteLine(ran.Next(1, 15));
             Console.WriteLine(intpi);

             int age =16;

             if((age<14) && (age> 17)) {
                 Console.WriteLine("You are in the right age");
             }else{
                 Console.WriteLine("You are not in the right age");
             }

             int i = 0;
             while (i < 10) {  // this while will run only if only the the condition is true
                 i++;
                 Console.WriteLine(i);
             }

             string guess = "";
             do
             {
                 Console.WriteLine("guess a random number");
                 guess = Console.ReadLine();
             } while (!guess.Equals("15"));


             */

            /*   string sampString = "A bunch of morons";

               Console.WriteLine(String.IsNullOrEmpty(sampString));
               Console.WriteLine(string.IsNullOrWhiteSpace(sampString));
               Console.WriteLine(sampString.Length);

               Console.WriteLine("INdex ofbunch : " + sampString.IndexOf("bunch"));

               string format =  String.Format("")

               */



            // string builder is editing a string instead creating a new one

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence.");
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Pennsylvenica");

            sb.Replace("a", "e");
            sb.Remove(5, 7);
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.ToString());
            string test = Console.ReadLine();




        }
    }
}
