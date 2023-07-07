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

float dcb = Input("dcb");
float dnc = Input("dnc");

float dtb = (dcb + dnc) / 2;

System.Console.Write("Xep loai: ");
if (dtb >= 9 & dcb >= 8 & dnc >= 8)
{
    System.Console.WriteLine("Xuat sac.");
}
else if (dtb >= 8 & dcb >= 7 & dnc >= 7)
{
    System.Console.WriteLine("Gioi.");
}
else if(dtb >= 7 & dcb >= 6 & dnc >= 6)
{
    System.Console.WriteLine("Kha.");
} else if(dtb >= 5 & dcb >= 3 & dnc >= 3)
{
    System.Console.WriteLine("Trung binh.");
}
else
{
    System.Console.WriteLine("Khong dat.");
}