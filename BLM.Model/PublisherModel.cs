using BLM.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLM.Model
{
   public class PublisherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string TAN { get; set; }

        public static PublisherEntity Convert(PublisherModel model)
        {
            return new PublisherEntity()
            {
                 Id = model.Id,
                 Name = model.Name,
                 RegNo = model.RegNo,
                 TAN = model.TAN
            };
        }
    }
}
