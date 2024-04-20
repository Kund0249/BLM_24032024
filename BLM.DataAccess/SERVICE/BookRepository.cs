using BLM.DataAccess.EntityModel;
using BLM.DataAccess.ISERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.DataAccess.SERVICE
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext context;
        public BookRepository()
        {
            context = new DataContext();
        }
        public List<BookEntity> GetBooks()
        {
            return context.Books.ToList();
        }
        public bool AddBook(BookEntity entity)
        {
            try
            {
                context.Books.Add(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}
