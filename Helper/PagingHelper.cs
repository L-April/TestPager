using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPager.Models;

namespace TestPager.Helper
{
    public static class PagingHelper
    {
        public static MvcHtmlString Pagination(this HtmlHelper html,PageModel pageModel,Func<PageModel,string> pageLinks)
        {
            var htmlString = pageLinks(pageModel);
            return MvcHtmlString.Create(htmlString);
        }
    }
}