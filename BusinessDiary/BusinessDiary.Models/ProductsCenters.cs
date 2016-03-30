namespace BusinessDiary.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductsCenters
    {
        public int Id { get; set; }

        public int CenterId { get; set; }

        [ForeignKey("CenterId")]
        public Center Center { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int ProductCenterQuantity { get; set; }
    }
}
