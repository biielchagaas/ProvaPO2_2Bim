using System.Runtime.Serialization;

public class Produto
{
    public double valor;
    public double pis;
    public double icms;
    public double confins;
    public double lucro;
    double[] calc = new double[5];
    double soma = 0;

    public Produto(double valor, double pis, double icms, double confins, double lucro)
    {
        this.valor = valor;
        this.pis = pis;
        this.icms = icms;
        this.confins = confins;
        this.lucro = lucro;
    }

    public double Calculo(string unidade)
    {
        calc[0] = valor * (pis / 100);
        calc[1] = valor * (icms / 100);
        calc[2] = valor * (confins / 100);
        soma = valor + calc[0] + calc[1] + calc[2];
        calc[3] = soma * (lucro / 100);
        soma = soma + calc[3];
        if (unidade == "LT" || unidade == "KG")
        {
            calc[4] = soma * 0.05;
            soma = soma + calc[4];
            return soma;
        }
        else
        {
            return soma;
        }
    }
}