Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite o valor da compra: ");
double valorCompra = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Digite o valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Yellow;
double troco = valorPago - valorCompra;

Console.WriteLine($"O troco é: {troco:F2}");
Console.ResetColor();