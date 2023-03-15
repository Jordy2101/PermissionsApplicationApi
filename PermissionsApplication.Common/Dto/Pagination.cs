using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Common.Dto
{
    public class Pagination<T>
    {
        public int? TotalCount { get; set; }
        public int? PageSize { get; set; }
        public int? CurrentPage { get; set; }
        public int? TotalPages { get; set; }
        public int? HasNext { get; set; }
        public int? HasPrevious { get; set; }
        public List<T> Data { get; set; }
    }
}
