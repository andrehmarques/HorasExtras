double salarioHora, horaExtra, horasTrabalhadas;

Console.WriteLine("Bem vindo(a) a calculadora de hora extra!");

Console.Write("Digite o valor do salário/hora: ");
while (!double.TryParse(Console.ReadLine()!, out salarioHora) || salarioHora <= 0) {
    Console.WriteLine("Valor inválido, digite seu salário em R$: ");
}

Console.Write("Digite a quantiade de horas trabalhadas: ");
while (!double.TryParse(Console.ReadLine()!, out horasTrabalhadas) || horasTrabalhadas <= 0) {
    Console.WriteLine("Número inválido, digite um valor maior que 0: ");
}


Console.Write("Digite a quantiade de horas extras trabalhadas: ");
while (!double.TryParse(Console.ReadLine()!, out horaExtra) || horaExtra <= 0) {
    Console.WriteLine("Número inválido, digite um valor maior que 0: ");
}


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
