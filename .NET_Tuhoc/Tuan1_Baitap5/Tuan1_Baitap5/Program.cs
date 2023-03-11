using System.ComponentModel.Design;

int a, b, c;
Console.WriteLine("Nhap vao ba so (a, b, c): ");
do
{
    Console.Write("a= ");
    a = Convert.ToInt32(Console.ReadLine());
} while (a <= 0);

do
{
    Console.Write("b= ");
    b = Convert.ToInt32(Console.ReadLine());
} while (b <= 0);

do
{
    Console.Write("c= ");
    c = Convert.ToInt32(Console.ReadLine());
} while (c <= 0);

if ((a + b > c) && (a + c > b) && (b + c > a)){
    Console.WriteLine("Ba canh a, b, c la do dai cua mot tam giac");
} else
{
    Console.WriteLine("Ba canh a, b, c khong la ba canh cua mot tam giac.");
}
