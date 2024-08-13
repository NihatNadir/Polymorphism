# Polymorphism TR || ENG

## Bu uygulamada Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak alan hesaplaması uygulaması yapıyoruz.
- Kare , Dikdörtgen ve Diküçgenin ayrı ayrı tanımlandığı classlar oluşturdum.
- Bu classlar ortak bir çatı altında BaseGeometrikSekil classından ürettim.
- While ile uygulama başa dönüyor.
- İf-else ile seçilen durumlara göre uygulamanın kullandığı metotlar değişiyor.
- Hatalı girişlerde goto ile duruma göre başa dönülüyor.
- BaseGeometrikŞekil ile türü Kare Dikdörtgen ve Diküçgen ile nesne oluşturması yapılıyor.
  BaseGeometricShape geometricShape;
  geometricShape = new Rectangle();
  geometricShape = new Triangle();
  geometricShape = new Square();
  
---

## In this application, we are calculating the area of shapes composed of Square, Rectangle, and Triangle.
- I created separate classes for Square, Rectangle, and Right Triangle.
- These classes are derived from a common base class called BaseGeometricShape.
- The application returns to the beginning using a while loop.
- The methods used by the application change based on the selected conditions with if-else statements.
- In case of incorrect inputs, the application uses goto to return to the beginning as needed.
- An object is created with the type BaseGeometricShape for Square, Rectangle, and Right Triangle:
  BaseGeometricShape geometricShape;
  geometricShape = new Rectangle();
  geometricShape = new Triangle();
  geometricShape = new Square();
