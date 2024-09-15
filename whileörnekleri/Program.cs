using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // 1. Alıştırma: Konsol ekranına 10 kere aynı mesajı yazdırma
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            counter++;
        }

        Console.WriteLine("\n---\n");

        // 2. Alıştırma: 1 ile 20 arasındaki sayıları yazdırma
        int number = 1;
        while (number <= 20)
        {
            Console.WriteLine(number);
            number++;
        }

        Console.WriteLine("\n---\n");

        // 3. Alıştırma: 1 ile 20 arasındaki çift sayıları yazdırma
        int evenNumber = 2;
        while (evenNumber <= 20)
        {
            Console.WriteLine(evenNumber);
            evenNumber += 2;
        }

        Console.WriteLine("\n---\n");

        // 4. Alıştırma: 50 ile 150 arasındaki sayıların toplamı
        int sum = 0;
        int num = 50;
        while (num <= 150)
        {
            sum += num;
            num++;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sum);

        Console.WriteLine("\n---\n");

        // 5. Alıştırma: 1 ile 120 arasındaki tek ve çift sayıların toplamı
        int oddSum = 0;
        int evenSum = 0;
        int currentNumber = 1;
        while (currentNumber <= 120)
        {
            if (currentNumber % 2 == 0)
            {
                evenSum += currentNumber;
            }
            else
            {
                oddSum += currentNumber;
            }
            currentNumber++;
        }
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenSum);
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + oddSum);
    }
}