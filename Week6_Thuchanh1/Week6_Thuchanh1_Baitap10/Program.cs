double a, b, x;

Console.Write("Nhap a=");
a = float.Parse(Console.ReadLine());
Console.Write("Nhap b=");
b = float.Parse(Console.ReadLine());

if (a == 0)
{
    if (b == 0)
    {
        Console.WriteLine("Phuong trinh vo so nghiem");
    }
    else
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }
} else
{
    x = -b / a;
    Console.WriteLine("Nghiem cua phuong trinh la: {0}", x);
}