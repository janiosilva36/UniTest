// 1 - Namespace = Conjunto de Classe
namespace Calc;

public class Calculadora
{
    public static double CalcularAreaCubo(double lado)
    {
        return lado * lado * 6;
    }

    public static double CalcularAreaParalelogramo(double lado, double altura)
    {
        return lado * altura;
    }

   



    public static double CalcularAreaPiramide(double Base, double altura)
{
    // Calcula a área do triângulo da base
    double areaTri = (Math.Sqrt(3) / 4) * Base * Base;

    // Calcula a área da pirâmide
    double areaPiramide = areaTri * altura;

    return areaPiramide;
}


    public static void Main()
    {
        
    }
}
