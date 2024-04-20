using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLM_24032024.Models
{
    public class BookCreateModel
    {
        
        public int BookId { get; set; }
        public List<SelectListItem> PublisherList { get; set; }
        public int PublisherId { get; set; }
        public int NoPage { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public IFormFile CoverImage { get; set; }
    }
}
