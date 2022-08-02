using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string month;
            month = "May";
            switch (month)
            {
                case "January":
                    Console.WriteLine("31 days");
                    break;

                case "February":
                    Console.WriteLine("31 days");
                    break;

                case "March":
                    Console.WriteLine("28 or 29 days");
                    break;
                case "April":
                    Console.WriteLine("30 days");
                    break;
                case "May":
                    Console.WriteLine("31 days");
                    break;
                case "June":
                    Console.WriteLine("30 days");
                    break;
                case "July":
                    Console.WriteLine("31 days");
                    break;
                case "August":
                    Console.WriteLine("31 days");
                    break;
                case "September":
                    Console.WriteLine("30 days");
                    break;
                case "October":
                    Console.WriteLine("31 days");
                    break;
                case "November":
                    Console.WriteLine("30 days");
                    break;
                case "December":
                    Console.WriteLine("31 days");
                    break;
                        }
            }
    }
}
