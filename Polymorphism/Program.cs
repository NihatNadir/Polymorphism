using System;
namespace Polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            BaseGeometricShape geometricShape; // BaseGeometricShape türünden geometricShape tanımlıyoruz nesne değerini daha sonra vermeyi düşündüm.

            while (true)
            {
                Console.WriteLine("Alan hesaplama uygulamasına hoşgeldiniz...");
            app:
                Console.WriteLine("Karenin alanını hesaplamak için '1' basın \nDikdörtgenin alanını hesaplamak için '2' basın\nDiküçgenin alanını hesaplamak için '3' basın ");
                string character = Console.ReadLine() ?? "";
                if (character == "1")
                {
                square:
                    Console.WriteLine("Karenin bir kenar uzunluğunu giriniz...");
                    int edge;
                    bool result = int.TryParse(Console.ReadLine(), out edge); // Kullanıcı klavyeden istenilen değeri girmesi için TryParse Metodu kullandım.
                    if (result)
                    {
                        geometricShape = new Square(); // Önceden tanımlanan geometricShape için burada Square sınıfı için nesne oluşturması yaptım. 
                        geometricShape.Width = edge; // Nesnedeki değişkenlerin değerleri verilir.
                        geometricShape.Height = edge; // Nesnedeki değişkenlerin değerleri verilir.
                        geometricShape.AlanHesapla(); // Nesnenin bulunduğu classtan metot çağırılır.
                    }
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz lütfen bir sayı giriniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                        goto square;
                    }

                }
                else if (character == "2")

                {

                rectangle:

                    Console.WriteLine("Dikdörtgenin uzun kenarını giriniz...");
                    int edge1;
                    int edge2;
                    bool result1 = int.TryParse(Console.ReadLine(), out edge1); // Kullanıcı klavyeden istenilen değeri girmesi için TryParse Metodu kullandım.
                    if (result1)
                    {
                    second:
                        Console.WriteLine("Dikdörtgenin kısa kenarını giriniz...");
                        bool result2 = int.TryParse(Console.ReadLine(), out edge2); // Kullanıcı klavyeden istenilen değeri girmesi için TryParse Metodu kullandım.
                        if (result2)
                        {
                            geometricShape = new Rectangle(); // Önceden tanımlanan geometricShape için burada Rectangle sınıfı için nesne oluşturması yaptım. 
                            geometricShape.Width = edge1; // Nesnedeki değişkenlerin değerleri verilir.
                            geometricShape.Height = edge2; // Nesnedeki değişkenlerin değerleri verilir.
                            geometricShape.AlanHesapla(); // Nesnenin bulunduğu classtan metot çağırılır.
                        }
                        else
                        {
                            Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                            goto second;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                        goto rectangle;
                    }
                }

                else if (character == "3")
                {

                triangle:
                    Console.WriteLine("Diküçgenin yüksekliğini giriniz...");
                    int height;
                    bool result = int.TryParse(Console.ReadLine(), out height); // Kullanıcı klavyeden istenilen değeri girmesi için TryParse Metodu kullandım.
                    if (result)
                    {
                    first:
                        Console.WriteLine("Diküçgenin tabanını giriniz...");
                        int b;
                        bool result1 = int.TryParse(Console.ReadLine(), out b); // Kullanıcı klavyeden istenilen değeri girmesi için TryParse Metodu kullandım.
                        if (result1)
                        {
                            geometricShape = new Triangle(); // Önceden tanımlanan geometricShape için burada Rectangle sınıfı için nesne oluşturması yaptım. 
                            geometricShape.Width = b;
                            geometricShape.Height = height;
                            geometricShape.AlanHesapla();
                        }
                        else
                        {
                            Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                            goto first;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                        goto triangle;
                    }

                }
                else
                {
                    Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                    goto app;
                }
                exit:
                Console.WriteLine("Uygulamayı tekrar başlatmak istiyorsanız 'y' programdan çıkmak istiyorsanız 'n' basınız...");
                string app = Console.ReadLine() ?? "";
                if (app == "y")
                {

                }
                else if (app == "n") // Kullanıcı programdan çıkış yapar.
                    break;
                else
                {
                    Console.WriteLine("Yanlış değer girdiniz..."); // Kullanıcı yanlış değer girerse goto ile geri döner.
                    goto exit;
                }
            }
        }
    }
}