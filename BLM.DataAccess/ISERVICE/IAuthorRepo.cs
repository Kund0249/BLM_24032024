using BLM.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.DataAccess.ISERVICE
{
    public interface IAuthorRepo
    {
        public List<AuthorEntity> GetAuthor();
        public bool AddAuthor(AuthorEntity entity);
    }
}
