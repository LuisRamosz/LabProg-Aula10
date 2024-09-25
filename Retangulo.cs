public class Retangulo
{
    double largura;
    double altura;

    public Retangulo()
    {
        largura = 0;
        altura = 0;
    }

    public Retangulo(double valor)
    {
        largura = valor;
        altura = valor;
    }

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return (largura + altura) * 2;
    }

    public void Redimensionar()
    {

    }

    public void Redimensionar(double fator)
    {
        largura *= fator;
        altura *= fator;
    }

    public void Redimensionar(double altura, double largura)
    {
        this. largura = largura;
        this.altura = altura;
    }
}
