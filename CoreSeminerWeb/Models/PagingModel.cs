using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSeminerWeb.Models
{
    public class PagingModel
    {
        public List<ProductModel> prodList { get; set; } = new List<ProductModel>();
        public int PageCount { get; set; }

    }
}
