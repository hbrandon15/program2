
using System;
namespace program2
{

    public class Time2Test
    {
        static void Main()
        {
            var t1 = new Time2();
            var t2 = new Time2(2);
            var t3 = new Time2(21, 34);
            var t4 = new Time2(12, 25, 42);
            var t5 = new Time2(t4);
            var t6 = new Time2(23, 59, 59);






            Console.WriteLine("Constructed with:\n");
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine($" {t1.ToUniversalString()}"); // 00:00:00
            Console.WriteLine($" {t1.ToString()}\n"); // 12:00:00 AM

            Console.WriteLine(
            "t2: hour specified; minute and second defaulted");
            Console.WriteLine($" {t2.ToUniversalString()}"); // 02:00:00
            Console.WriteLine($" {t2.ToString()}\n"); // 2:00:00 AM

            Console.WriteLine(
            "t3: hour and minute specified; second defaulted");
            Console.WriteLine($" {t3.ToUniversalString()}"); // 21:34:00
            Console.WriteLine($" {t3.ToString()}\n"); // 9:34:00 PM

            Console.WriteLine("t4: hour, minute and second specified");
            Console.WriteLine($" {t4.ToUniversalString()}"); // 12:25:42
            Console.WriteLine($" {t4.ToString()}\n"); // 12:25:42 PM

            Console.WriteLine("t5: Time2 object t4 specified");
            Console.WriteLine($" {t5.ToUniversalString()}"); // 12:25:42
            Console.WriteLine($" {t5.ToString()}"); // 12:25:42 PM

            // trying my addtime method
            //try
            //{
            //    Console.WriteLine("t1 before: ");
            //    Console.WriteLine($" {t1.ToUniversalString()}");
            //    t1.addtime(1, 1, 1);
            //    Console.WriteLine("t1 after: ");
            //    Console.WriteLine($" {t1.ToUniversalString()}");

            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("\nException while initializing t6:");
            //    Console.WriteLine(ex.Message);
            //}

            //// trying my overloaded addtime method
            //try
            //{
            //    Console.WriteLine("t1 before: ");
            //    Console.WriteLine($" {t1.ToUniversalString()}");
            //    t1.addtime(t1);
            //    Console.WriteLine("t1 after: ");
            //    Console.WriteLine($" {t1.ToUniversalString()}");

            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("\nException while initializing t6:");
            //    Console.WriteLine(ex.Message);
            //}

            Console.WriteLine("\n");
            Console.WriteLine("t4 before: ");
            Console.WriteLine($" {t4.ToUniversalString()}");
            t4.addtime(0, 60, 0);
            Console.WriteLine("t4 after: ");
            Console.WriteLine($" {t4.ToUniversalString()}");
        }
    }
}