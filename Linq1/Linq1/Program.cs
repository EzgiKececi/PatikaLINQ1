using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Random randomNumber = new Random(); // Random sınıfından rastgele sayı üretmek için nesne oluşturma
        List<int> numberList = new List<int>();  // Oluşturulacak sayılar için liste oluşturma


        for (int i = 0; i < 10; i++)  // 10 adet rastgele sayı üretmek için döngü oluşturma
        {
            int newNumber = randomNumber.Next(-50, 50);
            numberList.Add(newNumber); // Oluşan her sayıyı listeye ekleme
            Console.WriteLine(newNumber);
        }


        Console.WriteLine("---------------------");

        // Listedeki çift sayıları ekrana yazdırma
        var evenNumbers = numberList.Where(num => num % 2 == 0); 
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("---------------------");

        // Listedeki tek sayıları ekrana yazdırma
        var oddNumbers = numberList.Where(num => num % 2 != 0);
        foreach (int num in oddNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("---------------------");

        // Listedeki pozitif sayıları ekrana yazdırma
        var positiveNumbers = numberList.Where(num => num > 0);
        foreach (int num in positiveNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("---------------------");

        // Listedeki negatif sayıları ekrana yazdırma
        var negativeNumbers = numberList.Where(num => num < 0);
        foreach (int num in negativeNumbers)
        {
            Console.WriteLine(num);
        }


        Console.WriteLine("---------------------");

        // Listedeki 15-22 arasındaki sayıları ekrana yazdırma
        var filteredNumbers = numberList.Where(num => num > 15 && num < 22);
        foreach (int num in filteredNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("---------------------");

        // Listedeki sayıların karesini alabilmek için Select kullanımı ve listeye çevirip ekrana yazdırma
        var squaredNumbers = numberList.Select(num => num * num).ToList();
        foreach (int num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
  
    
