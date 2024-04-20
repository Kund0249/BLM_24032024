using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.Model
{
   public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int NoPages { get; set; }
        public int Price { get; set; }
        public string CoverImagePath { get; set; }
    }
}
