using System;
namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(4, 2, 2020);
            Console.WriteLine($"Today's date is:\n {date.GetDate()}");
        }
    }
}





