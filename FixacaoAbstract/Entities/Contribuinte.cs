using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoAbstract.Entities
{
    internal abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public static List<Contribuinte> contribuintes { get; set; } = new List<Contribuinte>();

        public Contribuinte() { }
        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostoPago();

    }
}
