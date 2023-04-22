for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (i==0 || i==2 || j==0 || j==6)
        {
            Console.Write(" * ");
        } else
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 7; i >= 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("$");
    }
    Console.WriteLine();
}
Console.WriteLine();


int docao = 6;
for(int hang=1; hang<=docao; hang++)
{
    for(int khoangtrang = docao-hang; khoangtrang>=1; khoangtrang--)
    {
        Console.Write(" ");
    }
    for(int star=1; star <= 2*hang-1; star++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
