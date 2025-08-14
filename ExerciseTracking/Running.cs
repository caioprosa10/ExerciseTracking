using System;

namespace ExerciseTracking
{
    /// <summary>
    /// Corrida: recebe a distância (em km).
    /// </summary>
    public sealed class Running : Activity
    {
        private readonly double _distanceKm;

        public Running(DateOnly date, int minutes, double distanceKm)
            : base(date, minutes)
        {
            if (distanceKm <= 0)
                throw new ArgumentOutOfRangeException(nameof(distanceKm), "Distance must be positive.");

            _distanceKm = distanceKm;
        }

        public override double GetDistanceKm() => _distanceKm;

        public override double GetSpeedKph()
        {
            // Speed = (distance / minutes) * 60
            return (_distanceKm / Minutes) * 60.0;
        }

        public override double GetPaceMinPerKm()
        {
            // Pace = minutes / distance
            return Minutes / _distanceKm;
        }
    }
}
