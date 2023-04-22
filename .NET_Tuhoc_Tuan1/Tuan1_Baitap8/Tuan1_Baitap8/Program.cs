/* Hinh 1
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(" * ");
    }
    Console.WriteLine("\n");
} */

/* Hinh 2
for (int i = 0; i<3; i++)
{
    for(int j = 0; j < 7; j++)
    {
        if (i==0 || j==0 || i==2 || j==6)
        {
            Console.Write(" * ");
        } else {
            Console.Write("   ");
        }
    }
    Console.WriteLine("\n");
}
*/
/* Hinh 3
for (int i = 1; i<7; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/

/* Hinh 4
for (int i = 6; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("$");
    }
    Console.WriteLine();
}
*/

/* Hinh 5


*/
using System; 

int docao = 6;

for(int hang = 1; hang<=docao; hang++)
{
    for (int khoangtrang = docao-hang; khoangtrang >= 1; khoangtrang--)
    {
            Console.Write(" ");
    }
    for(int star = 1; star <= 2 * hang-1; star++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
