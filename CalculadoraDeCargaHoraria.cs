//string InicioDeExpediente = "07:00", FimDeExpediente = "18:00";

//TimeSpan horasSemanais = CalcularHorasSemanais(InicioDeExpediente, FimDeExpediente);

//static TimeSpan CalcularHorasSemanais(string inicioDeExpediente, string fimDeExpediente)
//{
//    TimeSpan inicio = TimeSpan.Parse(inicioDeExpediente);
//    TimeSpan fim = TimeSpan.Parse(fimDeExpediente);
//    TimeSpan horaDiaria = fim.Subtract(inicio);

//    Console.WriteLine($"horas diarias: {horaDiaria.TotalHours}");

//    return horaDiaria * 5;
//}

//Console.WriteLine($"horas semanais: {horasSemanais.TotalHours}");
//Console.WriteLine($"horas mensais: {(horasSemanais * 4).TotalHours}");