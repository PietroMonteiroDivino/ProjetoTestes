namespace CalculadoraTestes;
using Calculadora.services;

public class CalculadoraTests
{

    private CalculadoraImp _Calc;
    private object num;

    public CalculadoraTests()
    {
        _Calc = new CalculadoraImp();
    }
    [Fact]
    public void SomaDe5com10Retornando15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;
        //act
        int resultado = _Calc.Somar(num1, num2);
        //asserte
        Assert.Equal(15, resultado);


    }

    [Fact]
    public void SomaDe10com10Retornando20()
    {
        //arrange
        int num1 = 10;
        int num2 = 10;
        //act
        int resultado = _Calc.Somar(num1, num2);
        //asserte
        Assert.Equal(20, resultado);


    }
    
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //arrange
       int numero = 4;
         //act
       bool resultado = _Calc.EhPar(numero);
        //Assert
        Assert.True(resultado);

    }

     [Theory]
     [InlineData(new int[] { 2, 4})]
     [InlineData(new int[] { 6, 8, 10})]
     public void DeveVerificarSeOsnumerosSãoParesERetornarVerdadeiro(int[] numeros)
    {
       
        // Act  // Assert
        Assert.All(numeros, num => Assert.True(_Calc.EhPar(num)));
        
    }

}