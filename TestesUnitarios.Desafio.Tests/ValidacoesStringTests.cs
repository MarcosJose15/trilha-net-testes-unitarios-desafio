using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // OK!: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // OK!: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // OK!: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // OK!: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    // OK!: Corrigir a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // OK!: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
