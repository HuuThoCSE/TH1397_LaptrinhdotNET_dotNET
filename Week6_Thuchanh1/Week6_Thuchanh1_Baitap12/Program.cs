Console.Write("Nhap N=");
int n = int.Parse(Console.ReadLine());
double S = 0;
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        S += i;
    } else { 
        S -= i; 
    }
}
Console.WriteLine("Tong S = {0}", S);
