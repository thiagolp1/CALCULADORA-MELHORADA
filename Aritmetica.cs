public class Aritmetica
{
    public static double soma (double parcela1, double parcela2)
    {
     double  total = parcela1 + parcela2;
     return  total;  
    }
    public static double subtracao (double minuendo, double subtraendo)
    {
     double  diferenca = minuendo - subtraendo;
     return  diferenca;  
    }
    public static double multiplicacao (double fator1, double fator2)
    {
     double  produto = fator1 * fator2;
     return  produto;  
    }
    public static double divisao (double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new Exception("Não é possível dividir por zero.");
        }
     double  quoeciente = dividendo / divisor;
     return  quoeciente;  
    }
  
}