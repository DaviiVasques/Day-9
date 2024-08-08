using System.Globalization;

namespace ContaBanco;

    public class ContaBanco
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; set; }
        public ContaBanco(int NumeroConta, double Saldo)
        {
            this.NumeroConta = NumeroConta;
            this.Saldo = Saldo;
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
            
        }

        public virtual bool Sacar(double valor)
        {
            if(valor > 0 || Saldo <= valor )
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

    public override string ToString()
    {
        return $"Seu numero da conta: {NumeroConta}, Seu saldo: {Saldo}";
    }
}
