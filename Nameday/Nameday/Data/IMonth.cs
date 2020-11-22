using System.Collections.Generic;

namespace Nameday.Data
{
    public interface IMonth
    {
        int NumberOfDays { get; }
        string Name { get; }
        string[] GetNamesForDay(int day);
    }
}
