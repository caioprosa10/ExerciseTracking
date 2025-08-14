using System;

namespace ExerciseTracking
{
    /// <summary>
    /// Natação em piscina: recebe número de voltas (laps).
    /// Tamanho da piscina: 50 m por volta (0,05 km).
    /// </summary>
    public sealed class Swimming : Activity
    {
        private const double LapLengthKm = 0.05; // 50 m = 0,05 km
        private readonly int _laps;

        public Swimming(DateOnly date, int minutes, int laps)
            : base(date, minutes)
        {
            if (laps <= 0)
                throw new ArgumentOutOfRangeException(nameof(laps), "Laps must be positive.");

            _laps = laps;
        }

        public override double GetDistanceKm() => _laps * LapLengthKm;

        public override double GetSpeedKph()
        {
            double distance = GetDistanceKm();
            return (distance / Minutes) * 60.0;
        }

        public override double GetPaceMinPerKm()
        {
            double distance = GetDistanceKm();
            return Minutes / distance;
        }
    }
}
