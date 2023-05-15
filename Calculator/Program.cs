using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("Hesap Makinesi");
                Console.WriteLine("--------------");

                Console.Write("ilk rakamı giriniz: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("ikinci rakamı giriniz: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Yapmak istediğiniz işlemi seçin");
                Console.WriteLine("+ = Toplama işareti");
                Console.WriteLine("- = çıkarma işlemi");
                Console.WriteLine("/ = bölme işareti");
                Console.WriteLine("* = çarpma işlemi");
                Console.Write("işleminiz : ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Sonuç : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Sonuç : {num1} - {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Sonuç : {num1} / {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Sonuç : {num1} * {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Lütfen doğru bir değer girin");
                        break;

                }
                Console.WriteLine("İşleme devam etmek istiyor musunuz? (Evet = E ): ");
            } while (Console.ReadLine().ToUpper() == "E");

            
            Console.ReadKey();
        }
    }
}