using System.Data;
using System.Runtime.CompilerServices;

namespace Otomat_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adminUsername = "ab18";
            string adminPassword = "1234";

            int sayac = 3;
         
            int yenibakiye;

            int fiyat1 = 10;
            int fiyat2 = 30;
            int fiyat3 = 12;
            int fiyat4 = 12;
            int fiyat5 = 10;


            Console.WriteLine("Admin girişi için - 6,Normal Giriş İçin - 7");
            int giris = Convert.ToInt32(Console.ReadLine());

            if (giris == 6)
            {
            tekrardeneme:
                Console.WriteLine("Admin Kullanıcı Adı");
                string username = Console.ReadLine();
                Console.WriteLine("Admin Şifre");
                string password = Console.ReadLine();
                if (username == adminUsername && password == adminPassword)
                {
                    Console.WriteLine("Giriş Başarılı");
                    Thread.Sleep(1500);
                    Console.Clear();

                }
                else if (username != adminUsername || password == adminPassword )
                {
                    Console.WriteLine("Hatalı Giriş");
                    Console.Clear();
                    sayac--;
                    if (sayac == 0)
                    {
                        Console.WriteLine("Hatalı giriş sınırını doldurdunuz");
                        Console.WriteLine("Program 5 saniye kilitlenicek");
                        Thread.Sleep(5000);
                        Console.Clear();
                        goto tekrardeneme;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuş Basımı");
                        goto tekrardeneme;
                    }
                    
                }                       
            }
            else if (giris == 7)
            {
                Console.WriteLine("Normal Giriş Yaptınız");
                Thread.Sleep(1500);
                Console.Clear();
            }


        geri:
            while (true)
            {
              
                



                Console.WriteLine("Çikolata-1: " + "10TL");
                Console.WriteLine("Cips-2: " + "30TL");
                Console.WriteLine("Soda-3: " + "12TL");
                Console.WriteLine("Gazoz-4: " + "12TL");


                Console.WriteLine("Bir Ürün Seçiniz");
                int secenek = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Lütfen Bakiyenizi Giriniz");
                int bakiye = Convert.ToInt32(Console.ReadLine());



            tekrarode:

                if (secenek == 1 && bakiye >= 10)
                {
                    yenibakiye = bakiye;
                    Console.WriteLine("Çikolatayı Seçtiniz");
                    bakiye -= fiyat1;
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    Console.WriteLine("Yeni Bir Ürün Almak İstermisiniz?");
                    Console.WriteLine("Evet ise - 0 " + "Hayır ise - 9");
                    secenek = Convert.ToInt32(Console.ReadLine());

                    if (secenek == 0)
                    {
                        Console.WriteLine("Seçim Menüsüne Gidiliyor!!");
                        Thread.Sleep(3000);
                        goto geri;
                    }
                    else if (secenek == 9)
                    {
                        Console.WriteLine("Teşekkürler Yine Bekleriz!!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    }
                    else if (secenek != 10)
                    {
                        Console.WriteLine("Yetersiz bakiye, para eklemek için  8'e basınız. ");
                        int eklenenpara = Convert.ToInt32(Console.ReadLine());

                        yenibakiye = eklenenpara += bakiye;
                        Console.Clear();
                        goto tekrarode;


                    }
                }
                else if (secenek == 2 && bakiye >= 30)
                {
                    yenibakiye = bakiye;
                    Console.WriteLine("Cipsi Seçtiniz");
                    bakiye -= fiyat1;
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    Console.WriteLine("Yeni Bir Ürün Almak İstermisiniz?");
                    Console.WriteLine("Evet ise - 0 " + "Hayır ise - 9");
                    secenek = Convert.ToInt32(Console.ReadLine());

                    if (secenek == 0)
                    {
                        Console.WriteLine("Seçim Menüsüne Gidiliyor!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto geri;
                    }
                    else if (secenek == 9)
                    {
                        Console.WriteLine("Teşekkürler Yine Bekleriz!!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    }
                    else if (secenek != 30)
                    {
                        Console.WriteLine("Yetersiz bakiye, para eklemek için 8'e basınız. ");
                        int eklenenpara = Convert.ToInt32(Console.ReadLine());

                        yenibakiye = eklenenpara += bakiye;
                        Console.Clear();
                        goto tekrarode;


                    }
                }
                else if (secenek == 3 && bakiye >= 12)
                {
                    yenibakiye = bakiye;
                    Console.WriteLine("Sodayı Seçtiniz");
                    bakiye -= fiyat1;
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    Console.WriteLine("Yeni Bir Ürün Almak İstermisiniz?");
                    Console.WriteLine("Evet ise - 0 " + "Hayır ise - 9");
                    secenek = Convert.ToInt32(Console.ReadLine());

                    if (secenek == 0)
                    {
                        Console.WriteLine("Seçim Menüsüne Gidiliyor!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto geri;
                    }
                    else if (secenek == 9)
                    {
                        Console.WriteLine("Teşekkürler Yine Bekleriz!!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    }
                    else if (secenek != 12)
                    {
                        Console.WriteLine("Yetersiz bakiye, para eklemek için 8'e basınız. ");
                        int eklenenpara = Convert.ToInt32(Console.ReadLine());

                        yenibakiye = eklenenpara += bakiye;
                        Console.Clear();
                        goto tekrarode;


                    }
                }
                else if (secenek == 4 && bakiye >= 12)
                {
                    Console.WriteLine("Gazoz kalmamıştır");
                    Console.WriteLine("Yeni Bir Ürün Almak İstermisiniz?");
                    Console.WriteLine("Evet ise - 0 " + "Hayır ise - 9");
                    secenek = Convert.ToInt32(Console.ReadLine());

                    if (secenek == 0)
                    {
                        Console.WriteLine("Seçim Menüsüne Gidiliyor!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto geri;
                    }
                    else if (secenek == 9)
                    {
                        Console.WriteLine("Teşekkürler Yine Bekleriz!!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}

                   


                    

            
        
    




                  


                       
                    
                

            
        
    


