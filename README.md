# gamer-profile-xunit

Serviço de cadastro de jogadores em .NET 10 com testes unitários em xUnit, desenvolvido para a disciplina de Gestão e Qualidade de Software (UNA).

## Estrutura
- `GamerProfile.App` — código de produção (`PerfilJogadorService`)
- `GamerProfile.Tests` — testes unitários (`PerfilJogadorServiceTests`)

## Métodos e testes

| Método | Retorno | Regra | Assert usado |
|---|---|---|---|
| `GerarTagUsuario` | string | Concatena nickname e código com `#` | `Assert.Equal` |
| `CalcularXPTotal` | int | Soma XP de duas fases + bônus de 100 | `Assert.Equal` |
| `EEligivelParaRanked` | bool | `true` se nível ≥ 15 | `Assert.True` / `Assert.False` |

O teste de elegibilidade cobre o valor de fronteira (15 elegível, 14 não elegível).

## Como executar

Pré-requisito: [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/dmannadias-gif/gamer-profile-xunit.git
cd gamer-profile-xunit
dotnet test
```

## Licença
MIT
