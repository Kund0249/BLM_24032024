using BLM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLM_24032024.Models
{
    public class BookListWrapper
    {
        public List<BookModel> Books { get; set; }
        public Pager PageInfo { get; set; }
    }
}
