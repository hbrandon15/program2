
using System;
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
                        Console.WriteLine("What report do you want?");
                        Console.WriteLine("1 - All objects");
                        Console.WriteLine("2 - All Time2 Objects");
                        Console.WriteLine("3 - All Time2sw Objects");
                        Console.WriteLine("4 - All Objects with an AM Time (Time earlier than 11:59:59)");
                        Console.WriteLine("5 - QUIT");
                        int reportResponse = Convert.ToInt32(Console.ReadLine());
                        switch(reportResponse)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break; 
                        }
                        flag = 1;
                        break;
                }
               



            } while (flag == 0);


            for (int i = 0; i < TimeList.Count; i++)
            {
                Console.WriteLine(TimeList[i]);
            }




        }
    }
}