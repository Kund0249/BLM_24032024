﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLM.DataAccess.EntityModel
{

    [Table("TBOOK")]
   public class BookEntity
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int NoPages { get; set; }
        public int Price { get; set; }
        public string CoverImagePath { get; set; }
    }
}
