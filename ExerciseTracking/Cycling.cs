using System;

namespace ExerciseTracking
{
    /// <summary>
    /// Ciclismo estacionário: recebe a velocidade (kph).
    /// </summary>
    public sealed class Cycling : Activity
    {
        private readonly double _speedKph;

        public Cycling(DateOnly date, int minutes, double speedKph)
            : base(date, minutes)
        {
            if (speedKph <= 0)
                throw new ArgumentOutOfRangeException(nameof(speedKph), "Speed must be positive.");

            _speedKph = speedKph;
        }

        public override double GetDistanceKm()
        {
            // distance = speed * hours
            double hours = Minutes / 60.0;
            return _speedKph * hours;
        }

        public override double GetSpeedKph() => _speedKph;

        public override double GetPaceMinPerKm()
        {
            // Pace = 60 / speed
            return 60.0 / _speedKph;
        }
    }
}
