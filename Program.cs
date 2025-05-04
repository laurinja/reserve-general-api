using System;
using System.Globalization;
using Modelos;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CONFIGURAÇÃO DE RESERVAS ===");

        DateTime dataMin = LerData("Informe a data mínima permitida (dd/mm/yyyy): ");
        DateTime dataMax;

        while (true)
        {
            dataMax = LerData("Informe a data máxima permitida (dd/mm/yyyy): ");
            if (dataMax > dataMin) break;
            Console.WriteLine("A data máxima deve ser maior que a mínima.");
        }

        TimeSpan horaMin = LerHora("Informe a hora mínima permitida (hh:mm): ");
        TimeSpan horaMax;

        while (true)
        {
            horaMax = LerHora("Informe a hora máxima permitida (hh:mm): ");
            if (horaMax > horaMin) break;
            Console.WriteLine("A hora máxima deve ser maior que a mínima.");
        }

        ConfiguracaoReserva configuracao;
        try
        {
            configuracao = new ConfiguracaoReserva(dataMin, dataMax, horaMin, horaMax);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na configuração: {ex.Message}");
            return;
        }

        Console.WriteLine("\n=== DADOS DA RESERVA ===");

        string descricao = LerTexto("Descrição da sala: ");
        DateTime dataReserva = LerData("Data da reserva (dd/mm/yyyy): ");
        TimeSpan horaReserva = LerHora("Hora da reserva (hh:mm): ");
        int capacidade = LerCapacidade("Capacidade da sala (1 a 39): ");

        Reserva reserva = new Reserva(configuracao, descricao, dataReserva, horaReserva, capacidade);
        var erros = reserva.ValidarReserva();

        if (erros.Count == 0)
        {
            Console.WriteLine("\nReserva registrada com sucesso!");
            Console.WriteLine(reserva);
        }
        else
        {
            Console.WriteLine("\nErros ao registrar reserva:");
            foreach (var erro in erros)
            {
                Console.WriteLine($"- {erro}");
            }
        }
    }

    static DateTime LerData(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                return data;

            Console.WriteLine("Data inválida. Tente novamente (ex: 25/04/2025).");
        }
    }

    static TimeSpan LerHora(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            if (TimeSpan.TryParse(entrada, out TimeSpan hora))
                return hora;

            Console.WriteLine("Hora inválida. Tente novamente (ex: 14:30).");
        }
    }

    static string LerTexto(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

    static int LerCapacidade(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int capacidade) && capacidade > 0 && capacidade < 40)
                return capacidade;

            Console.WriteLine("Capacidade inválida. Deve estar entre 1 e 39.");
        }
    }
}
