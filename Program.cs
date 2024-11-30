using System;

namespace Operatorler;
class Program
{
    static void Main(string[] args)
    {
        // Atama ve işlemli atama
        System.Console.WriteLine("***************Atama ve işlemli atama***************");
        int x = 4;
        int y = 6;
        x += 4;
        y -= 3;
        Console.WriteLine($"X ekleme işlemi: {x},Y çıkartma işlemi: {y}");
        x *= 5;
        y /= 3;
        Console.WriteLine($"X çarpma işlemi: {x},Y bölme işlemi: {y}");
        //Mantıksal Operatörler - || , &&, !
        System.Console.WriteLine("***************Mantıksal Operatörler***************");
        bool isSucces = true;
        bool isCompleted = false;
        if(isSucces || isCompleted)
            Console.WriteLine("Perfect!");
        if(isSucces && isCompleted)
            Console.WriteLine("Great!");
        if(isSucces && !isCompleted)
            Console.WriteLine("Fine!");
        //İlişkisel Operatörler - <,>,<=,>=,==,!=
        System.Console.WriteLine("***************İlişkisel Operatörler***************");
        int a = 10;
        int b = 7;
        bool sonuc = a > b;
        System.Console.WriteLine(sonuc);
        sonuc = a < b;
        System.Console.WriteLine(sonuc);
        sonuc = a <= b;
        System.Console.WriteLine(sonuc);
        sonuc = a >= b;
        System.Console.WriteLine(sonuc);
        sonuc = a == b;
        System.Console.WriteLine(sonuc);
        sonuc = a != b;
        System.Console.WriteLine(sonuc);
        //Aritmetik Operatörler - +,-,*,/
        System.Console.WriteLine("***************Aritmetik Operatörler***************");
        int sayi1 = 15;
        int sayi2 = 5;
        int sonuc2;
        System.Console.WriteLine($"Çıkartma işlemi: {sonuc2=sayi1-sayi2}");
        System.Console.WriteLine($"Ekleme işlemi: {sonuc2=sayi1+sayi2}");
        System.Console.WriteLine($"Bölme işlemi: {sonuc2=sayi1/sayi2}");
        System.Console.WriteLine($"Çarpma işlemi: {sonuc2=sayi1*sayi2}");
        // % mod alma (kalan)
        int sonuc3=20 % 3;
        System.Console.WriteLine($"Mod alma: {sonuc3}");
        sonuc2++;
        System.Console.WriteLine(sonuc2);
    }
}
