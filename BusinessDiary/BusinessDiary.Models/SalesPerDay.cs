namespace BusinessDiary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SalesPerDay
    {
        private ICollection<SalesPerProduct> salesPerProduct;

        public SalesPerDay()
        {
            this.salesPerProduct = new HashSet<SalesPerProduct>();
        }

        public int Id { get; set; }

        public DateTime Day { get; set; }

        public int CenterId { get; set; }

        [ForeignKey("CenterId")]
        public Center Center { get; set; }

        public virtual ICollection<SalesPerProduct> SalesPerProducts { get; set; }
    }
}
