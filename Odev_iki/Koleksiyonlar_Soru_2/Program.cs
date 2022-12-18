using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
         //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        static  void Main(string[] args)
        {
            int[] sayilar= new int[20];
            int[] enkucuksayi=new int[3];
            int[] enbuyuksayi=new int[3];

            int enkucuklerortalama,enkucuklertoplam=0;
            int enbuyuklerortalama,enbuyuklertoplam=0;

            for (int i = 0; i < 20; i++)
            {
                 Console.WriteLine("{0}. Pozitif Sayı Giriniz: ",i+1);
                 int n=int.Parse(Console.ReadLine());
                 sayilar[i]=n;
            }
            
            Array.Sort(sayilar);

            for (int j = 0; j < 3; j++)
            {
                enkucuksayi[j]=sayilar[j];
                enkucuklertoplam=enkucuklertoplam+enkucuksayi[j];
            }

            Console.WriteLine("***En kucuk Sayılar***");
            foreach (var item in enkucuksayi)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(sayilar);

            for (int k = 0; k < 3; k++)
            {
                enbuyuksayi[k]=sayilar[k];
                enbuyuklertoplam=enbuyuklertoplam+enbuyuksayi[k];
            }

            Console.WriteLine("***En ;Büyük Sayılar");

            foreach (var item in enbuyuksayi)
            {
                Console.WriteLine(item);
            }
            
            enkucuklerortalama=enkucuklertoplam/3;
            Console.WriteLine("En küçük üç sayının Ortalaması: {0}",enkucuklertoplam/3);

            enbuyuklerortalama=enbuyuklertoplam/3;
            Console.WriteLine("En büyük üç sayının Ortalaması: {0}",enbuyuklertoplam/3);

            

            Console.WriteLine("Ortalama toplamları: {0}",enbuyuklerortalama+enkucuklerortalama);
            
        
        }
    }
}
