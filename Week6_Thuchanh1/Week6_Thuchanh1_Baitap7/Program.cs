float Input(string variableName)
{
    float num;
    while (true)
    {
        Console.Write($"{variableName} = ");
        if (float.TryParse(Console.ReadLine(), out num) && num >= 0)
        {
            break;
        }
        Console.WriteLine("Gia tri nhap vao khong hop le, vui long nhap lai.");
    }
    return num;
}

float a = Input("a");
float b = Input("b");

Console.Write("Toan tu (+, -, *, /): ");
char toantu = char.Parse(Console.ReadLine());
switch (toantu)
{
    case '+':
        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a+b);
        break;
    case '-':
        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a - b);
        break;
    case '*':
        Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a * b);
        break;
    case '/':
        if (b != 0)
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, toantu, b, a / b);
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0.");
        }
        break;
    default:
        Console.WriteLine("Toan tu khong hop le.");
        break;
}

