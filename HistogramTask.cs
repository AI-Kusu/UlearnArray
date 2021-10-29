using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var date = 31;
            var dates = new string[date];
            for (int i = 0; i < date; i++)
            {
                dates[i] = (i + 1).ToString();
            }

            var numberOfBirths = new double[date];
            foreach (var person in names)
            {
                if (person.Name == name && person.BirthDate.Day != 1)
                    numberOfBirths[person.BirthDate.Day - 1]++;
            }



            return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), dates, numberOfBirths);
        }
    }
}