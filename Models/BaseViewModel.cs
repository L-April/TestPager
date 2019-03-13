using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPager.Models
{
    public class BaseViewModel
    {
        public IEnumerable<BookModel> books { get; set; }
        public PageModel pageModel { get; set; }
    }
}