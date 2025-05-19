double salarioHora, horaExtra, horasTrabalhadas;

Console.WriteLine("Bem vindo(a) a calculadora de hora extra!");

Console.Write("Digite o valor do salário/hora: ");
salarioHora = double.Parse(Console.ReadLine()!);

Console.Write("Digite a quantiade de horas trabalhadas: ");
horasTrabalhadas = double.Parse(Console.ReadLine()!);


Console.Write("Digite a quantiade de horas extras trabalhadas: ");
horaExtra = double.Parse(Console.ReadLine()!);

double salarioInicial = salarioHora * horasTrabalhadas;

double salarioFinal = CalcularSalario(salarioHora, horasTrabalhadas, horaExtra);

Console.WriteLine($"Seu salário base é {salarioInicial:C2}");
Console.WriteLine($"Seu salário com as horas extras é {salarioFinal:C2}");


double CalcularSalario(double salarioHora, double horaExtra, double horasTrabalhadas)
{
    double salarioBase = salarioHora * horasTrabalhadas;
    double salarioExtra = horaExtra * (salarioHora * 1.4);

    double salarioTotal = salarioBase + salarioExtra;

    return salarioTotal;
}
