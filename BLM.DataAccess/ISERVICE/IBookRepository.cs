using BLM.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLM.DataAccess.ISERVICE
{
   public interface IBookRepository
    {
        public List<BookEntity> GetBooks();
        public bool AddBook(BookEntity entity);
    }
}
