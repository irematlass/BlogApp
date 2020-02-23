using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Asp.net MVC"},
                new Category(){KategoriAdi="Asp.net WebForm"},
                new Category(){KategoriAdi="Windows Form"},
            };
            foreach (var item in categories)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
               new Blog(){ Baslik="C# delegates hakkında",Aciklama="C# delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Resim="1.jpg", Icerik="C# delegates hakkında C# delegates hakkında",CategoryId=1},
               new Blog(){ Baslik="mvc delegates hakkında",Aciklama="C# delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Resim="2.jpg", Icerik="C# delegates hakkında C# delegates hakkında",CategoryId=2},
               new Blog(){ Baslik="asp.net webform delegates hakkında",Aciklama="C# delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=false,Onay=true,Resim="3.jpg", Icerik="C# delegates hakkında C# delegates hakkında",CategoryId=3},
               new Blog(){ Baslik="windows form delegates hakkında",Aciklama="C# delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=true,Onay=false,Resim="4.jpg", Icerik="C# delegates hakkında C# delegates hakkında",CategoryId=4},
            };
            foreach (var item in blogs)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}