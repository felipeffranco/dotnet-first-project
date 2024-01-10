using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }
}