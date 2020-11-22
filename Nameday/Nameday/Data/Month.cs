using System;
using System.Collections.Generic;

namespace Nameday.Data
{
    public abstract class Month : IMonth
    {
        public abstract int NumberOfDays { get; }
        public abstract string Name { get; }

        protected abstract string[][] Names { get; }

        public string[] GetNamesForDay(int day)
        {
            if (day < 1 || day > NumberOfDays)
            {
                throw new ArgumentException($"{Name} has {NumberOfDays} days, please request a day between 1-{NumberOfDays}.");
            }

            return Names[day - 1];
        }
    }
}
