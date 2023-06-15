using System.Runtime.Serialization;

public class Produto
{
    public double valor;
    public int pis;
    public int icms;
    public int confins;
    public int lucro;
    double calc = 0;
    double soma = 0;

    public Produto(double valor, int pis, int icms, int confins, int lucro)
    {
        this.valor = valor;
        this.pis = pis;
        this.icms = icms;
        this.confins = confins;
        this.lucro = lucro;
    }

    public double Calculo(string unidade)
    {
        calc = (valor * (pis / 100)) + valor;
        soma += calc;
        calc = valor * (icms / 100);
        soma += calc;
        calc = valor * (confins / 100);
        soma += calc;
        calc = soma * (lucro / 100);
        soma += calc;
        if (unidade == "LT" || unidade == "KG")
        {
            calc = soma * 0.05;
            soma += calc;
            return calc;
        }
        else
        {
            return calc;
        }
    }
}