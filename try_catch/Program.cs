using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kare = sayi * sayi;
            Console.WriteLine("Girilen sayının karesi: " + kare);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş yaptınız! ;Bir sayı giriniz.");
        }
    }
}