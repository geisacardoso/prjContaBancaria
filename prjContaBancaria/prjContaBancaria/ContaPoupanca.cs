using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjContaBancaria
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int Numero, string Nome, double Saldo)
            : base(Numero, Nome, Saldo)
        {
        }
        public ContaPoupanca()
            : this(0, "", 0f)
        {
        }
        public override string debitar(double valor)
        {
            if (Saldo - valor < 0)
            {
                return String.Format("INS:{0,10:C2}\tSALDO:{1,10:C2}\n", valor, Saldo);
            }
            else
            {
                this.Saldo -= valor;
                return String.Format("DEB:{0,10:C2}\tSALDO:{1,10:C2}\n", valor, Saldo);
            }
        }
    }
}