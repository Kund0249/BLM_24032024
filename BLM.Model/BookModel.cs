using BLM.DataAccess.EntityModel;
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

        public static BookEntity Convert(BookModel model)
        {
            return new BookEntity()
            {
                BookId = model.BookId,
                BookName = model.BookName,
                CoverImagePath = model.CoverImagePath,
                NoPages = model.NoPages,
                Price = model.Price
            };
        }

        public static BookModel Convert(BookEntity entity)
        {
            return new BookModel()
            {
                BookId = entity.BookId,
                BookName = entity.BookName,
                CoverImagePath = entity.CoverImagePath,
                NoPages = entity.NoPages,
                Price = entity.Price
            };
        }
    }
}
