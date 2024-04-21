using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLM.DataAccess.EntityModel
{
    [Table("TAUTHOR")]
    public class AuthorEntity
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int AuthorContact { get; set; }
        public string AuthorEmail { get; set; }
    }
}
