using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLM.DataAccess.EntityModel
{
    [Table("TPUBLISHER")]
   public class PublisherEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("Registration Number")]
        public string RegNo { get; set; }

        public string TAN { get; set; }
    }
}
