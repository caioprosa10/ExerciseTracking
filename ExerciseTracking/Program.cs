using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    internal static class Program
    {
        private static void Main()
        {
            var activities = new List<Activity>
            {
                // Exemplo parecido com o do enunciado (métrico):
                new Running(new DateOnly(2022, 11, 3), minutes: 30, distanceKm: 4.8),
                new Cycling(new DateOnly(2022, 11, 3), minutes: 40, speedKph: 24.0),
                new Swimming(new DateOnly(2022, 11, 3), minutes: 25, laps: 30)
            };

            foreach (var a in activities)
            {
                Console.WriteLine(a.GetSummary());
            }
        }
    }
}
