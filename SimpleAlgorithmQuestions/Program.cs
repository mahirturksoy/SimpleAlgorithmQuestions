using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithmQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            sorular soru = new sorular();

            soru.ciftYazdir();
            soru.tamBolen();
            soru.kelimeYaz();
            soru.kelimeSay();
            
        }
    }

    class sorular
    {
        public void ciftYazdir()
        {
            Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("Negatif Bir Sayı Girdiniz!");
            else
            { 
            Console.WriteLine(n + " " + "Adet Pozitif Sayı Giriniz.");
            int[] dizi = new int[n];
            for(int i = 0; i < dizi.Length; i++)
                dizi[i] = int.Parse(Console.ReadLine());

            for(int j = 0; j < dizi.Length; j++)
            {
                if (dizi[j] % 2 == 0)
                    Console.WriteLine(dizi[j]);
            }
            }
        }
        
        public void tamBolen()
        {
            Console.WriteLine("Pozitif İki Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(n + " " + "Adet Pozitif Tam Sayı Giriniz: ");
            int[] dizi2 = new int[n];

            for(int i = 0; i < n; i++)
                dizi2[i] = int.Parse(Console.ReadLine());

            foreach(var item in dizi2)
            {
                if (item == m || item % m == 0)
                    Console.WriteLine(item);
            }
        } 

        public void kelimeYaz()
        {
            Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " " + "Adet Kelime Giriniz: ");
            string[] dizi = new string[n];
            
            for(int i = 0; i < dizi.Length; i++)
                dizi[i] = Console.ReadLine();

            Array.Reverse(dizi); // Reverse tersten yazdırır.
            foreach(var item2 in dizi)
                Console.WriteLine(item2);
        } 

        public void kelimeSay()
        {
            Console.WriteLine("Lütfen Bir Cümle Yazın: ");
            string  harf = Console.ReadLine();
            string[] kelimeler = harf.Split(' ');
            Console.WriteLine("Kelime Sayısı: {0}", kelimeler.Count());
            Console.WriteLine("Harf Sayısı: {0}", harf.Count());
        }
    }
}
