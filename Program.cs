using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gorevler = new List<string>();
            bool calisiyor = true;

            Console.WriteLine("Yapılacaklar Listesi Uygulamasına Hoş Geldiniz!");

            while (calisiyor)
            {
                Console.WriteLine("\n--- MENÜ ---");
                Console.WriteLine("1. Görev Ekle");
                Console.WriteLine("2. Görevleri Listele");
                Console.WriteLine("3. Görev Sil");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminiz: ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Eklenecek görev: ");
                        string yeniGorev = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(yeniGorev))
                        {
                            gorevler.Add(yeniGorev);
                            Console.WriteLine("Görev başarıyla eklendi!");
                        }
                        else
                        {
                            Console.WriteLine("Görev boş olamaz!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- GÖREVLERİNİZ ---");
                        if (gorevler.Count == 0)
                        {
                            Console.WriteLine("Listeniz şu an boş.");
                        }
                        else
                        {
                            for (int i = 0; i < gorevler.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {gorevler[i]}");
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Silmek istediğiniz görevin numarasını girin: ");
                        if (int.TryParse(Console.ReadLine(), out int silinecekNo) && silinecekNo > 0 && silinecekNo <= gorevler.Count)
                        {
                            string silinen = gorevler[silinecekNo - 1];
                            gorevler.RemoveAt(silinecekNo - 1);
                            Console.WriteLine($"'{silinen}' silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz numara girdiniz.");
                        }
                        break;

                    case "4":
                        calisiyor = false;
                        Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim! Lütfen 1-4 arası bir rakam girin.");
                        break;
                }
            }
        }
    }
}