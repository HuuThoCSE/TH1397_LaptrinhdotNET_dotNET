Double a, b, x;
Console.Write("Nhap a= ");
a = Double.Parse(Console.ReadLine());
Console.Write("Nhap b= ");
b = Double.Parse(Console.ReadLine());

if (a == 0)
{
    if(b == 0)
    {
        Console.WriteLine("Phuong trinh vo so nguyen.");
    }
    else
    {
        Console.WriteLine("Phuong trinh vo nguyem.");
    }
} else
{
    x = -b / a;
    Console.WriteLine("Nghiem cua phuong trinh la: {0}", x);
}