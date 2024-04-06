using BLM.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.DataAccess.ISERVICE
{
   public interface IPublisherRepo
    {
        public PublisherEntity GetPublisher { get;}
        public bool Add(PublisherEntity entity);
    }
}
