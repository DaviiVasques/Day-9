
namespace ContaBanco;

public class ContaPoupanca : ContaBanco
{
    public double TaxaRendimento { get; set; }

    public ContaPoupanca(int NumeroConta, double SaldoInicial, double TaxaRendimento)
        : base(NumeroConta, SaldoInicial)
    {
        this.TaxaRendimento = TaxaRendimento;
    }

    public override bool Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        return false;
    }

    public void AplicarRendimento()
    {
        if (Saldo > 0)
        {
            Saldo = Saldo + (Saldo * TaxaRendimento);
        }
    }


}
