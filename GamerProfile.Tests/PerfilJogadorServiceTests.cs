using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    private readonly PerfilJogadorService _service = new();

    [Fact]
    public void GerarTagUsuario_DeveConcatenarNicknameECodigoComHashtag()
    {
        // Arrange
        string nickname = "Aragorn";
        string codigo = "1042";

        // Act
        string resultado = _service.GerarTagUsuario(nickname, codigo);

        // Assert
        Assert.Equal("Aragorn#1042", resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarFasesEAplicarBonusDe100()
    {
        // Arrange
        int valorEsperado = 600;

        // Act
        int resultado = _service.CalcularXPTotal(200, 300);

        // Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveRespeitarNivelMinimo15()
    {
        // Fronteira: 15 é elegível, 14 não
        Assert.True(_service.EEligivelParaRanked(15));
        Assert.True(_service.EEligivelParaRanked(30));
        Assert.False(_service.EEligivelParaRanked(14));
        Assert.False(_service.EEligivelParaRanked(0));
    }
}