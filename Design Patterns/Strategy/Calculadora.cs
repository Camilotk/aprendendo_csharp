namespace strategyImposto
{
    public class Calculadora
    {
        public double CalculaImposto(Orcamento orcamento, Imposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            return resultado;
        }
    }
}