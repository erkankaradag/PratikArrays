# Dizi Elemanları İşlemleri (C# Programı)

Bu C# programı, kullanıcıdan bir dizi oluşturmak ve diziye yeni elemanlar eklemek, ardından diziyi sıralamak için kullanılabilir. Program şu işlemleri gerçekleştirir:

1. Kullanıcıdan 10 adet tamsayı alır.
2. Diziyi ekrana yazdırır.
3. Diziye yeni bir eleman ekler.
4. Diziyi küçükten büyüğe sıralar ve sıralı diziyi ekrana yazdırır.

## Özellikler

- Kullanıcıdan dizinin elemanlarını almak.
- Dizinin elemanlarını ekrana yazdırmak.
- Diziyi yeniden boyutlandırmak ve yeni bir eleman eklemek.
- Diziyi sıralamak ve sıralı elemanları ekrana yazdırmak.

## Kullanım

### 1. Başlangıç

Programı çalıştırdığınızda kullanıcıdan dizinin ilk 10 elemanını girmesi istenecektir. Bu elemanlar bir `int[]` dizisine eklenir.

### 2. Diziyi Yeniden Boyutlandırma

Kullanıcıdan yeni bir eleman girilmesi istenir. Bu eleman dizinin sonuna eklenir.

### 3. Diziyi Sıralama

Program, diziyi küçükten büyüğe sıralar ve sıralanmış diziyi ekrana yazdırır.

## Çalıştırma

1. Bu projeyi bilgisayarınıza indirin.
2. Visual Studio veya herhangi bir C# uyumlu IDE ile açın.
3. Programı çalıştırın.
4. Kullanıcıdan dizinin elemanlarını girmesi istenecektir.

## Kod

```csharp
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
