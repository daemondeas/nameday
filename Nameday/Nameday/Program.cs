using System;
using System.Text;
using Nameday.Data;

namespace Nameday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var jan = new January();
            var random = new Random();
            var a = string.Empty;
            while(a != " ")
            {
                var day = random.Next(1, jan.NumberOfDays + 1);
                PrintNames(day, jan.Name, jan.GetNamesForDay(day));
                a = Console.ReadLine();
            }
        }

        private static void PrintNames(int day, string month, string[] names)
        {
            var message = new StringBuilder();
            message.Append($"Den {day}:");
            message.Append((day % 10) > 2 || (day % 10) == 0 ? 'e' : 'a');
            message.Append($" {month} har ");
            switch (names.Length)
            {
                case 0:
                    message.Append("ingen");
                    break;
                case 3:
                    message.Append($"{names[2]}, ");
                    goto case 2;
                case 2:
                    message.Append($"{names[1]} och ");
                    goto case 1;
                case 1:
                    message.Append(names[0]);
                    break;
            }

            message.Append(" namnsdag.");
            Console.WriteLine(message.ToString());
        }
    }
}
