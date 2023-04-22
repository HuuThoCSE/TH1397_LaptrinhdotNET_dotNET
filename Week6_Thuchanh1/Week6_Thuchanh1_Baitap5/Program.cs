Console.WriteLine("Nhap vao 3 so a, b, c:");

float a = Input("a");
float b = Input("b");
float c = Input("c");

if ((a + b) > c && (a + c) > b && (b + c) > a)
{
    Console.WriteLine("Day la 3 canh cua mot tam giac");
}
else
{
    Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");
}

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
