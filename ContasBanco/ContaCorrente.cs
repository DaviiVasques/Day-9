namespace ContaBanco;

public class ContaCorrente : ContaBanco
{
    public double LimiteChequeEspecial { get; set; }

    public ContaCorrente(int NumeroConta, double SaldoInicial, double LimiteChequeEspecial)
    : base(NumeroConta, SaldoInicial)
    {
        this.LimiteChequeEspecial = LimiteChequeEspecial;
    }

    public override bool Sacar(double valor)
    {
        if (valor > 0 || valor <= Saldo + LimiteChequeEspecial)
        {
            Saldo -= valor;
            return true;
        }
        Console.WriteLine("Não foi possivel sacar seu dinheiro.");
        return false;
    }

    

}
