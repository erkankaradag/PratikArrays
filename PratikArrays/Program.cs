using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[10];

        // Diziyi elemanlarını gir
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine($"Dizinin {i + 1}. elemanını girin!");
            dizi[i] = int.Parse(Console.ReadLine());
        }

        // Dizinin elemanlarını ekrana yazdır
        Console.WriteLine("Dizinin elemanları: ");
        foreach (int eleman in dizi)
        {
            Console.WriteLine($"Dizinin elemanı: {eleman}");
        }

        // Diziyi yeniden boyutlandır
        Array.Resize(ref dizi, dizi.Length + 1);

        // Kullanıcıdan yeni bir eleman al
        Console.WriteLine("Diziye eklemek istediğiniz sayıyı girin: ");
        dizi[dizi.Length - 1] = int.Parse(Console.ReadLine());

        // Diziyi sıralama ve ekrana yazdırma
        Console.WriteLine("Dizinin elemanları (sıralı): ");
        Array.Sort(dizi); // Küçükten büyüğe sıralar
        foreach (int eleman in dizi)
        {
            Console.WriteLine(eleman);
           
        }
        
    }
}
