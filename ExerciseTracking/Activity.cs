using System;
using System.Globalization;

namespace ExerciseTracking
{
    /// <summary>
    /// Base abstrata para qualquer atividade.
    /// Contém atributos comuns (data e duração em minutos)
    /// e declara métodos de cálculo a serem sobrescritos.
    /// </summary>
    public abstract class Activity
    {
        private readonly DateOnly _date;
        private readonly int _minutes;

        protected Activity(DateOnly date, int minutes)
        {
            if (minutes <= 0)
                throw new ArgumentOutOfRangeException(nameof(minutes), "Minutes must be positive.");

            _date = date;
            _minutes = minutes;
        }

        // Encapsulamento: membros privados com acesso protegido somente se necessário
        protected DateOnly Date => _date;
        protected int Minutes => _minutes;

        // Métodos de cálculo (polimorfismo por sobrescrita)
        public abstract double GetDistanceKm();     // km
        public abstract double GetSpeedKph();       // kph
        public abstract double GetPaceMinPerKm();   // min/km

        // Polimorfismo: método na base que usa os virtuais/abstratos
        public virtual string GetSummary()
        {
            string datePart = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
            double distance = GetDistanceKm();
            double speed = GetSpeedKph();
            double pace = GetPaceMinPerKm();

            return $"{datePart} {GetType().Name} ({_minutes} min): " +
                   $"Distance {distance:0.0} km, Speed {speed:0.0} kph, Pace: {pace:0.00} min per km";
        }
    }
}
