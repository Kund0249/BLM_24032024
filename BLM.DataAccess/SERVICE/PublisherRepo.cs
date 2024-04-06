using BLM.DataAccess.EntityModel;
using BLM.DataAccess.ISERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.DataAccess.SERVICE
{
  public  class PublisherRepo : IPublisherRepo
    {
        private readonly DataContext context;
        public PublisherRepo()
        {
            context = new DataContext();
        }
        public PublisherEntity GetPublisher
        {
            get
            {
                return null;
            }
        }

        public bool Add(PublisherEntity entity)
        {
            try
            {
                context.Publishers.Add(entity);
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
