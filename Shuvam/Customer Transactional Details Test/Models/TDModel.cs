using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer_Transactional_Details_Test.Models
{

        public class TDModel
        {
            public int Id { get; private set; }
            [Required]
            public int TNo { get; set; }
            [Required]
            public string Transactional_Details { get; set; }
            [Required]
            public float Credit { get; set; }
            [Required]
            public float Debit { get; set; }
            [Required]
            public DateTime Date { get; set; }

        }
}
