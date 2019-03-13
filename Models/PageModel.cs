using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPager.Models
{
    public class PageModel
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public long dataTotal { get; set; }
        public long pageTotal { get { return dataTotal % pageSize == 0 ? dataTotal / pageSize : dataTotal / pageSize + 1; } }
    }
}