using System;

namespace _240464
{
    class Program
    {
        static void Main(string[] args)
        {     
            int Day = int.Parse(Console.ReadLine());
            int Time = int.Parse(Console.ReadLine());
            string set = Console.ReadLine();

            while (set != "End")
            {
                string set01 = Console.ReadLine();
                set = set01;
                int BreakfastSet = 5;
                int WeekendSet = 2;
                int Coffee = 3;

                if (Day == 1 || Day == 2 || Day == 3 || Day == 4 || Day == 5)
                {
                    if (set == "Breakfast Set")
                    {
                        if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else if (Time > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else
                        {
                            BreakfastSet--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid menu");
                    }
                }
                else if (Day == 5 || Day == 6)
                {
                    if (set == "Breakfast Set")
                    {
                        if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else if (Time > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        else
                        {
                            BreakfastSet--;
                        }
                    }
                    else if(set == "Breakfast Set")
                    {
                        if (WeekendSet <= 0)
                        {
                           Console.WriteLine("Sorry your order is out of stock");
                        }
                        else
                        {
                            WeekendSet--;
                        }             
                    }
                    else if(set == "Coffee")
                    {
                        if(Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else
                        {
                            Coffee--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid menu");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            }
            Console.ReadLine();
        }   
    }
}
