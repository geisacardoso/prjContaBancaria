using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjContaBancaria
{
    public class ContaCorrente:Conta
    {
        public double Limite { get; set; }
        public ContaCorrente(int Numero, string Nome, double Saldo,
            double Limite)
            : base(Numero, Nome, Saldo)
        {
            this.Limite = Limite;
        }
        public override string debitar(double valor)
        {
            if (valor > (Saldo + Limite))
            {
                return String.Format("INS:{0,10:C2}\tSALDO:{1,10:C2}\n", 
                    valor, Saldo);
            }
            else
            {
                this.Saldo -= valor;
                return String.Format("DEB:{0,10:C2}\tSALDO:{1,10:C2}\n",
                    valor, Saldo);
            }
        }
    }
}
