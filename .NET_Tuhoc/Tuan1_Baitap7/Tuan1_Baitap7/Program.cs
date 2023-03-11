float a, b;
char toantu;

Console.Write("Nhap so a= ");
a = float.Parse(Console.ReadLine());
Console.Write("Nhap so b= ");
b = float.Parse(Console.ReadLine());

Console.Write("Nhap toan tu (+, -, *, /): ");
toantu = char.Parse(Console.ReadLine());

switch (toantu)
{
    case '+':
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        break;
    case '-':
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        break;
    case '*':
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        break;
    case '/':
        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        break;
}