using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {

        //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

        static void Main(string[] args)
        {
            Console.WriteLine("Bir Cümle Giriniz: ");
            string cumle=Console.ReadLine();

            ArrayList sesli=new ArrayList();

            string sesliHarfler = "aeıioöuü";

          if(!string.IsNullOrEmpty(cumle))
          {
            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesliHarfler.Contains(cumle[i]))
                {
                    sesli.Add(cumle[i]);
                }

            }
          }
          
            sesli.Sort();
            
            foreach (var item in sesli)
            {
                Console.WriteLine(item);
            }
        }
    }
}
