
Bu uygulama, kare, dikdörtgen ve dik üçgen gibi temel geometrik şekillerin alanını hesaplamak için tasarlanmıştır. Uygulama, Polymorphism (Çok Biçimlilik) prensibini kullanarak farklı geometrik şekillerin alan hesaplamalarını tek bir temel sınıf üzerinden yapmaktadır.

Sınıf Yapısı
1. BaseGeometrikSekil

	Property'ler:
Genişlik: Şeklin genişliğini temsil eder.
Yükseklik: Şeklin yüksekliğini temsil eder.
	Metotlar:
AlanHesapla(): Tüm geometrik şekillerde alan hesaplaması yapılacak metodun temelini oluşturur. Bu metod, türetilen sınıflarda ezilerek (override) kullanılır.
2. Kare

Türetildiği Sınıf: BaseGeometrikSekil
Alan Hesaplama: Genişlik x Yükseklik formülü ile hesaplanır. (Karede genişlik ve yükseklik aynı olduğundan bu formül kullanılabilir.)
3. Dikdortgen

Türetildiği Sınıf: BaseGeometrikSekil
Alan Hesaplama: Genişlik x Yükseklik formülü ile hesaplanır.
4. DikUcgen

Türetildiği Sınıf: BaseGeometrikSekil
Alan Hesaplama: (Genişlik x Yükseklik) / 2 formülü ile hesaplanır.

Kullanım
1. Proje Başlatma:

Uygulama, ilgili class'ların oluşturulması ve her bir şekil için alan hesaplamalarının yapılmasını içerir.
2. Kullanılacak Metotlar ve Nesneler:

Kare, Dikdortgen, DikUcgen sınıflarından nesneler oluşturularak, AlanHesapla() metodu ile alan hesaplaması yapılır.
Her şekil için örnek nesne oluşturun ve AlanHesapla() metodunu çağırarak hesaplanan alanları konsola yazdırın.
