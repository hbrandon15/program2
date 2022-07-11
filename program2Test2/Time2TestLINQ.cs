
using System;
using System.Linq;

namespace program2
{

    public class Time2TestLINQ
    {
        static void Main()
        {
            List<Time2> TimeList = new List<Time2>();
            int flag = 0;
            int hour, minute, second, milisecond;
            do
                {
                Console.WriteLine("Which type of object do you wish to enter?");
                Console.WriteLine("1 - Time2");
                Console.WriteLine("2 - Time2sw");
                Console.WriteLine("3 - Stop entering data");
                int response = Convert.ToInt32(Console.ReadLine());
                

               switch(response)
                {
                    case 1:
                        Console.WriteLine("You have selected Time2");
                        
                        Console.WriteLine("Enter Hours:");
                        hour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered: '{hour}' for hours");
                        Console.WriteLine("Enter Minutes:");
                        minute = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered: '{minute}' for minutes");
                        Console.WriteLine("Enter Seconds:");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered '{second}' for seconds");
                        var t1 = new Time2(hour, minute, second);
                        TimeList.Add(t1);
                        break;

                    case 2:
                        Console.WriteLine("You have selected Time2sw");
                        Console.WriteLine("Enter Hours:");
                        hour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered: '{hour}' for hours");
                        Console.WriteLine("Enter Minutes:");
                        minute = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered: '{minute}' for minutes");
                        Console.WriteLine("Enter Seconds:");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You have entered '{second}' for seconds");
                        Console.WriteLine("Enter Miliseconds:");
                        milisecond = Convert.ToInt32(Console.ReadLine());
                        var t2 = new Time2sw(hour, minute, second, milisecond);
                        TimeList.Add(t2);
                        break;
                    case 3:
                        Console.WriteLine("You have selected to stop entering data");
                        selectReport(TimeList);
                        flag = 1;
                        break;
                }
           
            } while (flag == 0);

            int finalFlag = 0;

            do
            {
                Console.WriteLine("\nWould you like to run another report or QUIT the application?");
                Console.WriteLine("1 - Another Report");
                Console.WriteLine("2 - QUIT");
                int finalResponse = Convert.ToInt32(Console.ReadLine());
                switch(finalResponse)
                {
                    case 1:
                        selectReport(TimeList);
                        break;
                    case 2:
                        Console.WriteLine("You have selected to QUIT the application\n Goodbye!");
                        finalFlag = 1;
                        break;
                    default:
                        Console.WriteLine("Please select either 1 or 2");
                        break;
                }

            } while (finalFlag == 0);
           
           




        }

        private static void selectReport(List<Time2> TimeList)
        {
            Console.WriteLine("\nWhat report would you like to generate?");
            Console.WriteLine("1 - All objects");
            Console.WriteLine("2 - All Time2 Objects");
            Console.WriteLine("3 - All Time2sw Objects");
            Console.WriteLine("4 - All Objects with an AM Time (Time earlier than 11:59:59)");
            Console.WriteLine("5 - QUIT");
            int reportResponse = Convert.ToInt32(Console.ReadLine());
            switch (reportResponse)
            {
                case 1:
                    Console.WriteLine("You have selected 'All objects report'");
                    generateAllObjectsReport(TimeList);
                    break;
                case 2:
                    Console.WriteLine("You have selected 'All Time2 Objects report'");
                    generateAllTime2ObjectsReport(TimeList);
                    break;
                case 3:
                    Console.WriteLine("You have selected 'All Time2sw Objects report'");
                    generateAllTime2swObjectsReport(TimeList);
                    break;
                case 4:
                    Console.WriteLine("You have selected 'All Objects with an AM Time (Time earlier than 11:59:59) report'");
                    generateAllObjectsAmReport(TimeList);
                    break;
                case 5:
                    Console.WriteLine("You have selected 'QUIT'\n!");

                    break;
            }
        }

        private static void generateAllObjectsReport(List<Time2> TimeList)
        {
            var filtered =
                from t in TimeList
                select t;
            Console.WriteLine("-------------------\n-------------------\nGENERATING REPORT\n-------------------\n-------------------\n");
            foreach (var element in filtered)
            {
                Console.WriteLine(element);
            }
        }
        private static void generateAllTime2ObjectsReport(List<Time2> TimeList)
        {
            var filtered =
                from t in TimeList
                let value1 = typeof(Time2)
                where t.GetType() == value1
                select t;
            Console.WriteLine("-------------------\n-------------------\nGENERATING REPORT\n-------------------\n-------------------\n");
            foreach (var element in filtered)
            {
                Console.WriteLine(element);
            }
        }
        private static void generateAllTime2swObjectsReport(List<Time2> TimeList)
        {
            var filtered =
                from t in TimeList
                let value1 = typeof(Time2sw)
                where t.GetType() == value1
                select t;
            Console.WriteLine("-------------------\n-------------------\nGENERATING REPORT\n-------------------\n-------------------\n");
            foreach (var element in filtered)
            {
                Console.WriteLine(element);
            }
        }
        private static void generateAllObjectsAmReport(List<Time2> TimeList)
        {
            var filtered =
                from t in TimeList
                where t.Hour < 12
                select t;
            Console.WriteLine("-------------------\n-------------------\nGENERATING REPORT\n-------------------\n-------------------\n");
            foreach (var element in filtered)
            {
                Console.WriteLine(element);
            }
        }
    }
}