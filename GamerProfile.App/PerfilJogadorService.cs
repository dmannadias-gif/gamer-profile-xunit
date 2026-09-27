namespace GamerProfile.App;

public class PerfilJogadorService
{
    private const int BonusXP = 100;
    private const int NivelMinimoRanked = 15;

    public string GerarTagUsuario(string nickname, string codigo)
    {
        return $"{nickname}#{codigo}";
    }

    public int CalcularXPTotal(int xpFase1, int xpFase2)
    {
        return xpFase1 + xpFase2 + BonusXP;
    }

    public bool EEligivelParaRanked(int nivelJogador)
    {
        return nivelJogador >= NivelMinimoRanked;
    }
}