using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan adını al
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        // Kullanıcının adını ekrana yazdır
        Console.WriteLine("Merhaba, " + ad + "!");
    }
}
