using E_Commeric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = "Hello";
            var s2 = "Hello";
            User user1 = new User(3);
            User user2 = new User(9);
            //Console.WriteLine(s1.Equals(s2)); 
            //Console.WriteLine(ReferenceEquals(s1, s2)); 
            //Console.WriteLine(ReferenceEquals(user1, user2));
            //Console.WriteLine((user1== user2));


            int[] arr = {9,4,1,7};
            //try
            //{
            //  //  Console.WriteLine(arr.GetValue(5));
            //    Console.WriteLine(arr);
            //}
            //catch(Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //int[,] a= new int[2, 3];
            //int day = 2;

            //string result = day switch
            //{
            //    1 => "Saturday",
            //    2 => "Sunday",
            //    _ => "Unknown"
            //};

            //Console.WriteLine(result);

            //string s = "123455";
            ////int n= Convert.ToInt32(s);
            ////int n=int.Parse(s);

            //double num = Convert.ToDouble(s);
            //try
            //{
            //    Console.WriteLine($"num is {n}");
            //    Console.WriteLine(n + 1);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Is invalid");
            //}
            //int x = 13;

            //string binary = Convert.ToString(x, 2).PadLeft(8,'0');// بضيف من الشمال اصفاؤ لو الحجم لسه مش 8
            //Console.WriteLine(binary);
            //string b = "1101";
            //int number = Convert.ToInt32(b, 2);

            const double x = 9.8;
            Console.WriteLine(x + 2); //عادي لكن لما اغير فيه ذات نفسه مينفعش طبعا 








        }
    }
}
