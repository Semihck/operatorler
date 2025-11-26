
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Atama ve İşlemli Atama *****");
        int y = 2;
        int x = 1;

        y = y + 2;

        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y -= 1;
        Console.WriteLine(y);
        y *= 2;
        Console.WriteLine(y);
        y /= 2;
        Console.WriteLine(y);

        Console.WriteLine("\n***** Mantıksal Operatörler *****");
            // !, &&, ||
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            Console.WriteLine("\n***** İlişkisel Operatörler *****");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);   // true

            sonuc = a > b;
            Console.WriteLine(sonuc);   // false
                        Console.WriteLine("\n***** İlişkisel Operatörler *****");
           sonuc = a >= b;
            Console.WriteLine(sonuc);   // false

            sonuc = a <= b;
            Console.WriteLine(sonuc);   // true

            sonuc = a == b;
            Console.WriteLine(sonuc);   // false

            sonuc = a != b;
            Console.WriteLine(sonuc);   // true

            Console.WriteLine("\n***** Aritmetik Operatörler *****");
            // +, -, *, /, %
            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);  // 2

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);  // 50

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);  // 15

            sayi1 += 1;
            Console.WriteLine(sayi1);   // 11

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);  // 2


                
    }
}