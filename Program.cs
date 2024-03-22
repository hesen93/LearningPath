using System;
using System.Dynamic;
using System.Threading.Channels;

namespace  @if
{
    internal class Program
{
        static void Main(string[] args)
       {
            #region If-le bagli example-lar
            #region example 1
            //bool aileVeziyyeti = true;
            //if(aileVeziyyeti)
            //{
            //    Console.WriteLine("Allah xosbext elesin");
            //}
            #endregion
            #region if- else
            //int a = 10;
            //if (a==10)
            //{
            //    Console.WriteLine("a=10");
            //}
            //else
            //{
            //    Console.WriteLine("a!=10");
            //}




            #endregion
            #region if-else if
            //int a = 10;
            //if (a<5)
            //{
            //    Console.WriteLine("a-5den kicikdir");
            //}
            //else if  (a>5)
            //{
            //    Console.WriteLine("a-5den boyukdur");
            //}





            #endregion
            #region if-else if-....-else
            //int i = 100;
            //if (i<100)
            //{
            //    Console.WriteLine("100den kicik");
            //}
            //else if (i>100)
            //{
            //    Console.WriteLine("100 den boyuk");
            //}
            //else
            //{ 
            //    Console.WriteLine("100e beraberdir"); 
            //}

            #endregion
            #region task 1
            //decimal mehsul1 = decimal.Parse(Console.ReadLine());
            //decimal mehsul2 = decimal.Parse(Console.ReadLine());
            //decimal umumiOdenish = mehsul1 + mehsul2;

            //if (umumiOdenish>200)
            //{
            //    mehsul2 = mehsul2 / 4 * 3;
            //}
            //Console.WriteLine(mehsul1+mehsul2);

            #endregion
            #region task 2
            #region if mexanizmasi ile helli
            //Console.WriteLine("Istifadeci adini girin");
            //string istidafeciAdi = Console.ReadLine();
            //Console.WriteLine("Sifrenizi girin");
            //string sifre = Console.ReadLine();
            //if(istidafeciAdi =="Hesen" && sifre=="12345")
            //{
            //    Console.WriteLine("Giris ugurludur");
            //}
            //else
            //{
            //    Console.WriteLine("Giris ugursuzdur");
            //}
            #endregion
            #region Turnery operatoru ile helli
            //Console.WriteLine("Istifadeci adini girin");
            //string istidafeciAdi = Console.ReadLine();
            //Console.WriteLine("Sifrenizi girin");
            //string sifre = Console.ReadLine();
            //string giris = istidafeciAdi == "Hesen" && sifre == "12345" ? "Giris ugurludur" : "Giris ugursuzdur";
            //Console.WriteLine(giris);
            #endregion
            #region Switch mexanizmi ile helli
            //Console.WriteLine("Istifadeci adini girin");
            //string istidafeciAdi = Console.ReadLine();
            //Console.WriteLine("Sifrenizi girin");
            //string sifre = Console.ReadLine();
            //switch (istidafeciAdi,sifre)
            //{
            //    case ("Hesen", "12345"):
            //        Console.WriteLine("Giris ugurludur");
            //        break;
            //    default:
            //        Console.WriteLine("Giris ugursuzdur");
            //        break;
            //}










            #endregion

            #endregion
            #region task3 Kalkulyator
            #region if mexanizmi ile helli
            //Console.WriteLine("Hesablama edeceyiniz 1-ci ededi daxil edin");
            //int eded1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hesablama edeceyiniz 2-ci ededi daxil edin");
            //int eded2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Edeceyini hesablama novunu(+;-;*;/)sechin");
            //char riyaziEmeliyyat = char.Parse(Console.ReadLine());
            //if (riyaziEmeliyyat == '+')
            //{
            //    Console.WriteLine(eded1 + eded2);
            //}
            //else if (riyaziEmeliyyat == '-')
            //{
            //    Console.WriteLine(eded1 - eded2);
            //}
            //else if (riyaziEmeliyyat == '/')
            //{
            //    Console.WriteLine(eded1 / eded2);
            //}
            //else if (riyaziEmeliyyat == '*')
            //{
            //    Console.WriteLine(eded1 * eded2);
            //}
            #endregion
            #region Switch ile helli
            //Console.WriteLine("Hesablama edeceyiniz 1-ci ededi daxil edin");
            //int eded1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hesablama edeceyiniz 2-ci ededi daxil edin");
            //int eded2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Edeceyini hesablama novunu(+;-;*;/)sechin");
            //char riyaziEmeliyyat = char.Parse(Console.ReadLine());
            //int netice = riyaziEmeliyyat switch
            //{
            //    '+' => eded1 + eded2,
            //    '-' => eded1 - eded2,
            //    '*' => eded1 * eded2,
            //    '/' => eded1 / eded2
            //};
            //Console.WriteLine(netice);







            #endregion
            #region Turnery operatoru ile helli
            //Console.WriteLine("Hesablama edeceyiniz 1-ci ededi daxil edin");
            //int eded1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hesablama edeceyiniz 2-ci ededi daxil edin");
            //int eded2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Edeceyini hesablama novunu(+;-;*;/)sechin");
            //char riyaziEmeliyyat = char.Parse(Console.ReadLine());
            //int netice = riyaziEmeliyyat == '+' ? eded1 + eded2 : (riyaziEmeliyyat == '-' ? eded1 - eded2 : (riyaziEmeliyyat == '*' ? eded1 * eded2 : eded1 / eded2));
            //Console.WriteLine(netice);
            #endregion
            #endregion
            #region task4
            //Console.WriteLine("Bir eded daxil edin");
            //int a = int.Parse(Console.ReadLine());
            //if (a!=10)
            //    { 
            //    Console.WriteLine("Eded yanlisdir"); 
            //    }
            #endregion
            #region task5 Daxil edilen deyer 51-60 arasindadirsa ....
            Console.Write("Imtahan balini daxil edin:");
            decimal bal = 0;
            try
            {
                 bal = decimal.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Daxil etdiyiniz melumat emala uygun deyil");
            }
           
            
            if (bal >= 51 && bal <= 60)
                Console.WriteLine("E");
            else if (bal >= 61 && bal <= 70)
                Console.WriteLine("D");
            else if (bal >= 71 && bal <= 80)
                Console.WriteLine("C");
            else if (bal >= 81 && bal <= 90)
                Console.WriteLine("B");
            else if (bal >= 91 && bal <= 100)
                Console.WriteLine("A");
            else if (bal <= 50 && bal > 0)
                Console.WriteLine("Imtahandan kesildiniz");
            else Console.WriteLine("Bali duzgun daxil edin!");



            #region Turnery ile helli
            //string imtahanNeticesi = bal >= 51 && bal <= 60 ? "E" : (bal >= 61 && bal <= 70 ? "D" : (bal >= 71 && bal <= 80 ? "C" : (bal >= 81 && bal <= 90 ? "B" : (bal >= 91 && bal <= 100 ? "A" : (bal <= 50 && bal > 0 ? "Imtahandan kesildiniz" : "Bali duzgun daxil edin")))));
            //Console.WriteLine(imtahanNeticesi);
            #endregion







            #endregion
            #region task 6 Cevre,duzbucaqli,kvadratin sahesini hesablayan kod

            //Console.WriteLine("Sahesini hesablamaq istediyiniz fiqurun adini daxil edin(Cevre,Duzbucaqli,Kvadrat)");
            //string fiqur = Console.ReadLine();
            //if (fiqur == "Cevre")
            //{
            //    Console.WriteLine("Radiusun uzunlugunu daxil edin");
            //    double radiusunUzunlugu = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"Hesablanmis uzunluq: {3.14 * (radiusunUzunlugu * radiusunUzunlugu)}"); // string interpolation
            //}
            //else if (fiqur == "Duzbucaqli")
            //{
            //    Console.WriteLine("Birinci terefin uzunlugunu daxil edin");
            //    double birinciTeref = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Ikinci terefin uzunlugunu daxil edin");
            //    double ikinciTeref = double.Parse(Console.ReadLine());
            //    Console.WriteLine(birinciTeref * ikinciTeref);
            //}
            //else if (fiqur == "Kvadrat")
            //{
            //    Console.WriteLine("Kvadratin terefinin uzunlugunu daxil edin");
            //    double kvadratinTerefi = double.Parse(Console.ReadLine());
            //    Console.WriteLine(kvadratinTerefi * kvadratinTerefi);
            //}
            //else
            //    Console.WriteLine("Fiqurun adini duzgun daxil edin");
            #endregion






            #endregion
            #region Type pattern
            //object x = "Hesen";
            //if(x is string _x)
            //{
            //    Console.WriteLine(_x);
            //    //string _x = (string)x;
            //}

            #endregion
            #region Var pattern
            //object x = "wdrdewr";
            //if(x is var a )
            //    Console.WriteLine(a);
            #endregion
            #region Recursive pattern




            #endregion

        }







    }
}
