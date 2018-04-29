using System.Threading;

namespace Oefening17_7
{
    public class Bankrekening
    {
        private double Saldo { get; set; }
        private string RekeningNummer { get; set; }
        private string NaamEigenaar { get; set; }

        public Bankrekening(string rekeningNummer)
        {
            RekeningNummer = rekeningNummer;
            CheckSaldo();
        }

        public void StortGeld(double amount)
        {
            Saldo += amount;
            CheckSaldo();
        }

        public double NeemGeldOp(double amount)
        {
            Saldo -= amount;
            CheckSaldo();

            return amount;
        }

        public void CheckSaldo()
        {
            if (Saldo < 0)
            {
                throw new WrongSaldoException("Saldo mag niet onder 0 euro gaan");
            }else if (Saldo > 2500)
            {
                throw new WrongSaldoException("Saldo mag niet boven 2500 euro gaan");
            }
        }

    }
}