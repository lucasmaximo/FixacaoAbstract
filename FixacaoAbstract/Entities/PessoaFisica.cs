using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoAbstract.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoPago()
        {
            if(RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastosSaude * 0.5);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastosSaude * 0.5);
            }
        }
    }
}
