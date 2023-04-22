double a, b, c, delta, x1, x2;
Console.Write("Nhap a= ");
a = Double.Parse(Console.ReadLine());
Console.Write("Nhap b= ");
b = Double.Parse(Console.ReadLine());
Console.Write("Nhap c= ");
c = Double.Parse(Console.ReadLine());

delta = b * b - 4 * a * c;

if (delta < 0)
{
    Console.WriteLine("Phuong trinh vo nghiem.");
} else if (delta == 0){
    x1 = x2 = -b / (2 * a);
    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", x1);
}
else
{
    x1 = (-b + Math.Sqrt(delta))/ (2 * a);
    x2 = (-b - Math.Sqrt(delta))/ (2 * a);
    Console.WriteLine("Phuong trinh co hai nghiem phan biet la: x1 = {0}, x2 = {1}", x1, x2);
}