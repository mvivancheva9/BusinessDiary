using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDiary.Models
{
    public class RevenuesPerProduct
    {
        public int Id { get; set; }

        public int RevenuesPerDayId { get; set; }

        [ForeignKey("RevenuesPerDayId")]
        public RevenuesPerDay RevenuesPerDay { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
