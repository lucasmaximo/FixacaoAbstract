using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoAbstract.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numFuncionarios) : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double ImpostoPago()
        {
            if (NumFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
