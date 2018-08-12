using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLA_Project.Utils
{
    public class PageDetails
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string SortByField { get; set; }
        public bool IsAscOrder { get; set; }


    }
}
