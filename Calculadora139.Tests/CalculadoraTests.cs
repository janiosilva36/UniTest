
using NUnit.Framework;
using Calc; // namespace da Calculadora no Desenvolvimento

// Namespace
namespace Calculadora139.Tests;


// 3 - Classe
[TestFixture] // Marcação de que a classe trabalha com testes parametrizados
public class Tests
{


    [Test]
    public void TestarAreaPositivaCubo()
    {


        double lado = 10;
        double resultadoEsperado = 600;

        
        double resultadoAtual = Calculadora.CalcularAreaCubo(lado);

        // Assert
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void TestarAreaNegativaCubo()
    {
        // Valor do lado do cubo
        double lado = 10;

        // Valor esperado diferente do resultado real
        double resultadoEsperado = 700;

        // Ação
        double resultadoAtual = Calculadora.CalcularAreaCubo(lado);

        // Assert
        Assert.That(resultadoEsperado, Is.Not.EqualTo(resultadoAtual));
    }

    [Test]
    public void TestarAreaParalelogramoPositivo()
    {
        
        double ladoA = 10;
        double ladoB = 5;
        double resultadoEsperado = 50;

        // Ação
        double resultadoAtual = Calculadora.CalcularAreaParalelogramo(ladoA, ladoB);

        // Assert
        Assert.That(resultadoEsperado, Is.EqualTo(resultadoAtual));
    }

    [Test]
    public void TestarAreaParalelogramoNegativo()
    {
        
        double ladoA = -10;
        double ladoB = 5;
        double resultadoEsperado = double.NaN;

        // Ação
        double resultadoAtual = Calculadora.CalcularAreaParalelogramo(ladoA, ladoB);

        // Assert
        Assert.That(resultadoEsperado, Is.Not.EqualTo(resultadoAtual));
    }



    [TestCase(10.0, 5.0, 50.0)]
    [TestCase(20.0, 10.0, 200.0)]
    [TestCase(30.0, 15.0, 450.0)]
    public void CalcularAreaParalelogramoTestPositivo(double lado, double altura, double areaEsperada)
    {
        double area = Calculadora.CalcularAreaParalelogramo(lado, altura);
        Assert.AreEqual(areaEsperada, area);
    }

    [TestCase(-10.0, 5.0, 100)]
    [TestCase(-20.0, 10.0, 400.0)]
    [TestCase(-30.0, 15.0, 900.0)]
    public void CalcularAreaParalelogramoTestNegativo(double lado, double altura, double areaEsperada)
    {
        double area = Calculadora.CalcularAreaParalelogramo(lado, altura);
        Assert.AreNotEqual(areaEsperada, area);
    }


    [TestCase(0.0, 0.0, 0.0)]
    [TestCase(-20.0, 0.0, 5)]
    [TestCase(6, 0.0, 55)]
    public void CalcularAreaParalelogramoTestNegativo2(double lado, double altura, double areaEsperada)
    {
        try
        {
            Calculadora.CalcularAreaParalelogramo(lado, altura);
        }
        catch (Exception ex)
        {
            Assert.AreEqual(ex.Message, "Valores inválidos para o lado e a altura");
        }

    }


    
}
