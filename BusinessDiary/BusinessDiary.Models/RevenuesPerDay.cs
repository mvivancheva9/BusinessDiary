using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessDiary.Models
{
    public class RevenuesPerDay
    {
        private ICollection<RevenuesPerProduct> revenuesPerProduct;

        public RevenuesPerDay()
        {
            this.revenuesPerProduct = new HashSet<RevenuesPerProduct>();
        }

        public int Id { get; set; }

        public DateTime Day { get; set; }

        public int CenterId { get; set; }

        [ForeignKey("CenterId")]
        public Center Center { get; set; }

        public virtual ICollection<RevenuesPerProduct> RevenuesPerProduct { get; set; }
    }
}