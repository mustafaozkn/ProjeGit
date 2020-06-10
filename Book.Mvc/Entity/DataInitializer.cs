﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Book.Mvc.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){Name="Fantastik" },
                new Category(){Name="Çocuk" },
                new Category(){Name="Programlama" },
                new Category(){Name="Edebiyat" },
                new Category(){Name="Tarih" }

            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Kitap> books = new List<Kitap>()
            {
                new Kitap(){Name="Sissoylu - Son İmparatorluk",Description="Sissoylu - Son İmparatorluk Kitabı açıklaması buradadır.",
                    Yazar ="Branden Sanderson",Puan=10,Tavsiye=true,CategoryId=1,Home=true,Image="sissoylu1.jpg"},
                new Kitap(){Name="Sissoylu - Kuşatma",Description="Sissoylu - Son Kuşatma açıklaması buradadır.",
                    Yazar ="Branden Sanderson",Puan=9.5,Tavsiye=true,CategoryId=1,Image="sissoylu2.jpg"},
                new Kitap(){Name="Sissoylu - Çağların Kahramanı",Description="Sissoylu - Çağların Kahramanı Kitabı açıklaması buradadır.",
                    Yazar ="Branden Sanderson",Puan=9.9,Tavsiye=true,CategoryId=1,Home=true,Image="sissoylu3.jpg"},
                new Kitap(){Name="Elantris",Description="Elantris Kitabı açıklaması buradadır.",
                    Yazar ="Branden Sanderson",Puan=8,Tavsiye=true,CategoryId=1,Image="elantris.jpg"},
                new Kitap(){Name="Başlangıç",Description="Başlangıç Kitabı açıklaması buradadır.",
                    Yazar ="Dan Brown",Puan=9.9,Tavsiye=true,CategoryId=1,Home=true,Image="baslangic.jpg"},

                new Kitap(){Name="1001 Mini Hayvan Bulun",Description="1001 Mini hayvan Bulun açıklaması buradadır.",
                    Yazar ="Emma Helrough",Puan=7,Tavsiye=true,CategoryId=2,Home=true,Image="1001minihayvanbulun.jpg"},
                new Kitap(){Name="Annemin Çantası",Description="Annemin Çantası Kitabı açıklaması burada",
                    Yazar ="Sara Şahinkanat",Puan=7.3,Tavsiye=true,CategoryId=2,Image="annemincantasi.jpg"},
                new Kitap(){Name="Gulliver'in Gezileri",Description="Gulliver'in Gezileri Kitabı Açıklaması Buradadır.",
                    Yazar ="Jonathan Swift",Puan=6.3,Tavsiye=true,CategoryId=2,Home=true,Image="gulliveringezileri.jpg"},
                new Kitap(){Name="İki Yıl Okul Tatili",Description="İki Yıl Okul Tatili açıklaması buradadır.",
                    Yazar ="Jules Verne",Puan=7.9,Tavsiye=true,CategoryId=2,Image="ikiyilokultatili.jpg"},
                new Kitap(){Name="Mini Ayı Denize Gidiyor",Description="Mini Ayı Denize Gidiyor Açıklaması buradadır.",
                    Yazar ="xxxx uuuuuussss",Puan=4.6,Tavsiye=true,CategoryId=2,Home=true,Image="miniayidenizegidiyor.jpg"},


                new Kitap(){Name="Android Oyun Programlama",Description="Android Oyun Programlama Kitabı açıklaması buradadır.",
                    Yazar ="Murat Dikici",Puan=3.2,Tavsiye=true,CategoryId=3,Home=true,Image="androidoyunprogramlama.jpg"},
                new Kitap(){Name="Derin Öğrenme",Description="Derin Öğrenme Kitabı Açıklaması Buradadır.",
                    Yazar ="Atınç Yılmaz-Umut Kaya",Puan=7.7,Tavsiye=true,CategoryId=3,Image="derinogrenme.jpg"},
                new Kitap(){Name="Matlab",Description="Matlab kitap açıklaması burada",
                    Yazar ="Gökhün Yayla",Puan=8.8,Tavsiye=true,CategoryId=3,Home=true,Image="matlab.jpg"},
                new Kitap(){Name="Python3",Description="Python3 Kitap açıklaması Buradadır.",
                    Yazar ="Onur Selvi",Puan=8.8,Tavsiye=true,CategoryId=3,Image="python3.jpg"},
                new Kitap(){Name="Unity3D",Description="Unity3D kitap açıklaması",
                    Yazar ="Timuçin Hatipoğlu",Puan=10,Tavsiye=true,CategoryId=3,Home=true,Image="unity3d.jpg"},


                new Kitap(){Name="Hayvan Çiftliği",Description="Hayvan Çiftliği kitabı içeriği buradadır",
                    Yazar ="George Orwell",Puan=10,Tavsiye=true,CategoryId=4,Home=true,Image="hayvanciftligi.jpg"},
                new Kitap(){Name="İçimizdeki Şeytan",Description="İçimizdeki Şeytan Kitabı Açıklaması Buradadır.",
                    Yazar ="Sabahattin Ali",Puan=6.3,Tavsiye=true,CategoryId=4,Image="icimizdekiseytan.jpg"},
                new Kitap(){Name="Kürk Mantolu Madonna",Description="Kürk Mantolu Madonna Kitabı Açıklaması Buradadır.",
                    Yazar ="Sabahattin Ali",Puan=8.2,Tavsiye=true,CategoryId=4,Home=true,Image="kurkmantolumadonna.jpg"},
                new Kitap(){Name="Pia Meter",Description="Pia Meter Kitabı Açıklaması Buradadır.",
                    Yazar ="Sercan Karaismailoğlu",Puan=2.2,Tavsiye=true,CategoryId=4,Image="piameter.jpg"},
                new Kitap(){Name="Simyacı",Description="Simyacı Kitabı Açıklaması Buradadır.",
                    Yazar ="Paulo Coelho",Puan=10,Tavsiye=true,CategoryId=4,Home=true,Image="simyaci.jpg"},

            };

            foreach (var kitap in books)
            {
                context.Kitaplar.Add(kitap);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}