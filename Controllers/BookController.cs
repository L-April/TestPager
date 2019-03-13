using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPager.Models;

namespace TestPager.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index(int pageIndex = 1, int pageSize = 2)
        {
            //获取当前book集合
            List<BookModel> list = new List<BookModel>() { new BookModel() { Name = "C#" }, new BookModel() { Name = "Java" }, new BookModel() { Name = "Go" }, new BookModel() { Name = "PHP" }, new BookModel() { Name = "C" }, new BookModel() { Name = "C++" }, new BookModel() { Name = "VB" }, new BookModel() { Name = "MySQL" }, new BookModel() { Name = "MsSQL" }, new BookModel() { Name = "Oracle" }, new BookModel() { Name = "MongoDB" }, new BookModel() { Name = "Redis" }, new BookModel() { Name = "Memcached" }, new BookModel() { Name = "R" }, new BookModel() { Name = "Cobol" }, new BookModel() { Name = "Python" }, new BookModel() { Name = "JavaScript" }, new BookModel() { Name = "Html5" }, new BookModel() { Name = "CSS3" }, new BookModel() { Name = "JQuery" }, new BookModel() { Name = "Vue.js" }, new BookModel() { Name = "TypeScript" }, new BookModel() { Name = "VB.NET" } };
            var books = list.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            return View(new BookViewModel
            {
                books = books,
                pageModel = new PageModel
                {
                    pageIndex = pageIndex,
                    pageSize = pageSize,
                    dataTotal=list.Count
                }
            });
        }
    }
}