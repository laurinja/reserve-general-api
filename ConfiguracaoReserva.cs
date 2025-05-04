using System;

namespace Modelos
{
    public class ConfiguracaoReserva
    {
        public DateTime DataMinima { get; }
        public DateTime DataMaxima { get; }
        public TimeSpan HoraMinima { get; }
        public TimeSpan HoraMaxima { get; }

        public ConfiguracaoReserva(DateTime dataMinima, DateTime dataMaxima, TimeSpan horaMinima, TimeSpan horaMaxima)
        {
            if (dataMinima >= dataMaxima)
                throw new ArgumentException("A data mínima deve ser menor que a data máxima.");

            if (horaMinima >= horaMaxima)
                throw new ArgumentException("A hora mínima deve ser menor que a hora máxima.");

            DataMinima = dataMinima;
            DataMaxima = dataMaxima;
            HoraMinima = horaMinima;
            HoraMaxima = horaMaxima;
        }
    }
}
