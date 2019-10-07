using System;
using System.Threading;
using gregslist.Services;

namespace gregslist.Controllers
{
    public class CarController
    {
        private CarService _carService { get; set; } = new CarService();
        public void UserInput()
        {
            _carService.GetCars();
            Print();
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choice)
            {
                case "q":
                    Environment.Exit(1);
                    break;
                default:
                    if (int.TryParse(choice, out int index))
                    {
                        //print car details
                        _carService.GetCars(index - 1);
                        Print();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Command!");
                        // string f = "Failure";
                        // bool color = true;
                        // string message = "";
                        // foreach (char c in f)
                        // {
                        //     if (color)
                        //     {
                        //         Console.BackgroundColor = ConsoleColor.Magenta;
                        //         Console.ForegroundColor = ConsoleColor.Green;
                        //     }
                        //     else
                        //     {
                        //         Console.BackgroundColor = ConsoleColor.Green;
                        //         Console.ForegroundColor = ConsoleColor.Magenta;
                        //     }
                        //     color = !color;
                        //     Console.Clear();
                        //     message += c;
                        //     Console.WriteLine(message);
                        //     Console.Beep();
                        // }
                        // Thread.Sleep(1000);
                        // Console.ResetColor();
                        // Console.Clear();
                    }
                    break;

            }
        }

        private void Print()
        {
            foreach (string message in _carService.Messages)
            {
                System.Console.WriteLine(message);
            }
            _carService.Messages.Clear();
            System.Console.WriteLine();

        }
    }
}