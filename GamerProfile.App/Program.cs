using GamerProfile.App;

var service = new PerfilJogadorService();
Console.WriteLine(service.GerarTagUsuario("Aragorn", "1042"));
Console.WriteLine(service.CalcularXPTotal(200, 300));
Console.WriteLine(service.EEligivelParaRanked(15));