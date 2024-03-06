// See https://aka.ms/new-console-template for more information

using FixacaoAbstract.Entities;
using System.Globalization;

List<Contribuinte> contribuintes = new List<Contribuinte>();

Console.Write("Entre o número de contribuintes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados do contribuinte #{i}: ");

    Console.Write("Pessoa física ou pessoa jurídica (pf/pj)? ");
    string p = Console.ReadLine();
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Renda anual: ");
    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(p == "pf")
    {
        Console.Write("Gastos com saúde: ");
        double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        contribuintes.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
    }
    else
    {
        Console.Write("Número de funcionários: ");
        int numFuncionarios = int.Parse(Console.ReadLine());
        contribuintes.Add(new PessoaJuridica(nome, rendaAnual, numFuncionarios));
    }
}

double impostosTotais = 0.0;

Console.WriteLine();
Console.WriteLine("IMPOSTOS PAGOS:");

foreach (Contribuinte contribuinte in contribuintes)
{
    double imposto = contribuinte.ImpostoPago();
    impostosTotais += imposto;
    Console.WriteLine(contribuinte.Nome + ": $ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}

Console.WriteLine();
Console.WriteLine("IMPOSTOS TOTAIS: $ " + impostosTotais.ToString("F2", CultureInfo.InvariantCulture));



