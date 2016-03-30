namespace BusinessDiary.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class SalesPerProduct
    {
        public int Id { get; set; }

        public int SalesPerDayId { get; set; }

        [ForeignKey("SalesPerDayId")]
        public SalesPerDay SalesPerDay { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
