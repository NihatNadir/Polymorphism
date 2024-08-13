using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometricShape
    {
        

        private int width; // width field
        private int height; // height field
        public int Width // Width property
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height // Height property
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        
        public virtual void AlanHesapla() // BaseGeometricShape metodu virtual ile diğer metotlardan override yapabiliyoruz.
        {
            Console.WriteLine($"{width * height}");
        }
        

    }

    public class Square : BaseGeometricShape // Square sınıfı BaseGeometricShape sınıfından inheritance özelliği alıp özelliklerini taşıyor.
    {
        public override void AlanHesapla() // Square classından AlanHesapla override yapıyoruz.
        {
            Console.WriteLine($"Karenin alanı : {Width * Height}"); // Property için bu değişkenlere değerler atanır.
        }
    }

    public class Rectangle : BaseGeometricShape // Rectangle sınıfı BaseGeometricShape sınıfından inheritance özelliği alıp özelliklerini taşıyor.
    {
        public override void AlanHesapla() // Rectangle classından AlanHesapla override yapıyoruz.
        {
            Console.WriteLine($"Dikdörtgenin alanı : {Width * Height}"); // Property için bu değişkenlere değerler atanır.        
        }
    }

    public class Triangle : BaseGeometricShape // Triangle sınıfı BaseGeometricShape sınıfından inheritance özelliği alıp özelliklerini taşıyor.
    {
        public override void AlanHesapla()  // Triangle classından AlanHesapla override yapıyoruz.
        {
            double result = Width * Height; // Property için bu değişkenlere değerler atanır.
            Console.WriteLine($"Diküçgenin alanı : {result/2}");
        }
        
    }

}

