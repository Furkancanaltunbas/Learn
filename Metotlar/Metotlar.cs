// C# METOTLAR

int[] sayilar = { 3, 5, 9, 4, 7 };

Console.WriteLine("Eleman sayisi: " + sayilar.Length); // Dizinin uzunluğunu verir

Console.WriteLine("Boyutu: " + sayilar.Rank); // Dizinin boyutunu verir

Console.WriteLine("Ortalama: " + sayilar.Average()); // Dizi ortalamasını verir

Console.WriteLine("En büyük eleman: " + sayilar.Max()); // Dizinin en büyük değerini verir

Console.WriteLine("En küçük eleman: " + sayilar.Min()); // Dizinin en küçük elemanını verir

Console.WriteLine("Elemanların Toplamı: " + sayilar.Sum()); // Dizinin toplamını verir

Array.Sort(sayilar); // Diziyi küçükten büyüğe sıralar

Array.Reverse(sayilar); // Diziyi Ters çevirir

Array.Clear(sayilar, 2, 3); // Dizide belirtilen aralıktaki sayıları siler

Array.IndexOf(sayilar,3); // Dizideki belirtiğimiz elamanın index numarasını verir







