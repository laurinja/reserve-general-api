using System;
using System.Collections.Generic;

namespace Modelos
{
    public class Reserva
    {
        private readonly ConfiguracaoReserva _config;
        public string DescricaoDaSala { get; }
        public DateTime Data { get; private set; }
        public TimeSpan Hora { get; private set; }
        public int Capacidade { get; private set; }

        public Reserva(ConfiguracaoReserva config, string descricao, DateTime data, TimeSpan hora, int capacidade)
        {
            _config = config;
            DescricaoDaSala = descricao;
            RegistrarData(data);
            RegistrarHora(hora);
            RegistrarCapacidade(capacidade);
        }

        public void RegistrarData(DateTime data) => Data = data;

        public void RegistrarHora(TimeSpan hora) => Hora = hora;

        public void RegistrarCapacidade(int capacidade)
        {
            if (capacidade <= 0 || capacidade >= 40)
                throw new ArgumentException("Capacidade deve estar entre 1 e 39.");
            Capacidade = capacidade;
        }

        public List<string> ValidarReserva()
        {
            List<string> erros = new List<string>();

            if (Data < _config.DataMinima || Data > _config.DataMaxima)
                erros.Add("Data da reserva fora do intervalo permitido.");

            if (Hora < _config.HoraMinima || Hora > _config.HoraMaxima)
                erros.Add("Hora da reserva fora do intervalo permitido.");

            if (Capacidade <= 0 || Capacidade >= 40)
                erros.Add("Capacidade da sala deve ser entre 1 e 39.");

            return erros;
        }

        public override string ToString()
        {
            return $"Sala: {DescricaoDaSala}\nData: {Data.ToShortDateString()}\nHora: {Hora}\nCapacidade: {Capacidade} alunos";
        }
    }
}
