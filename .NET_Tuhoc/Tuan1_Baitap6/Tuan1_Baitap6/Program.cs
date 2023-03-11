float dcb, dnc, dtb;

Console.WriteLine("Nhap Diem co ban: ");
dcb = float.Parse(Console.ReadLine());

Console.WriteLine("Nhap Diem nang cao: ");
dnc = float.Parse(Console.ReadLine());

dtb = (dcb + dnc) / 2;
Console.WriteLine("Diem trung binh la {0}", dtb);

if((dtb < 7) && (dcb >= 3) && (dnc >= 3))
{
    Console.WriteLine("Khong dat.");
} else if ((dtb < 8) && (dcb >= 6) && (dnc >= 6))
{
    Console.WriteLine("Trung binh.");
}
else if ((dtb < 9) && (dcb >= 7) && (dnc >= 7))
{
    Console.WriteLine("Kha.");
}
else if ((dtb < 9) && (dcb >= 8) && (dnc >= 8))
{
    Console.WriteLine("Xuat sac/.");
}