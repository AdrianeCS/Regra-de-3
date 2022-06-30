double n1, n2, n3;

Console.WriteLine("---Regra de tres---");
Console.WriteLine("A     B");
Console.WriteLine("-  X  -");
Console.WriteLine("C     X");

Console.Write("Digite o valor de A...:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de B...:");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de C...:");
n3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O resultado é: " +  n3 * n2 / n1 );