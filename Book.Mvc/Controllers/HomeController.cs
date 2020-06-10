using Book.Mvc.Entity;
using Book.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book.Mvc.Controllers
{
    public class HomeController : Controller
    {

        DataContext _db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var books = _db.Kitaplar
                .Where(i => i.Home == true)
                .Select(i => new BookListModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + ".." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + ".." : i.Description,
                    Puan=i.Puan,
                    Yazar = i.Yazar.Length > 16 ? i.Yazar.Substring(0, 13) + ".." : i.Yazar,
                    Image=i.Image,
                    CategoryId=i.CategoryId
                    
                }).ToList();


            return View(books);
        }

        public ActionResult Details(int id)
        {
            return View(_db.Kitaplar.Where(i=>i.Id==id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var books = _db.Kitaplar
                .Select(i => new BookListModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + ".." : i.Description,
                    Puan = i.Puan,
                    Yazar = i.Yazar,
                    Image = i.Image,
                    CategoryId = i.CategoryId

                }).AsQueryable();
            if (id!= null)
            {
                books = books.Where(i => i.CategoryId == id);
            }

            return View(books.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_db.Categories.ToList());
        }

    }
}