using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // OK!: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    // OK!: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // OK!: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // OK!: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        // OK!: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(resultado, 9);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // OK!: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        // OK!: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(resultado, -8);
    }
}
