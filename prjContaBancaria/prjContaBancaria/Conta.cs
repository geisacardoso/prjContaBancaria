using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjContaBancaria
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public Conta(int Numero, string Nome, double Saldo)
        {
            this.Numero = Numero;
            this.Nome = Nome;
            this.Saldo = Saldo;
        }
        public Conta() : this(0, "", 0f) { }
        public string creditar(double valor)
        {
            this.Saldo += valor;
            return String.Format("CRE:{0,10:C2}\tSALDO:{1,10:C2}\n",
                valor, Saldo);
        }
        public abstract string debitar(double valor);
    }
}