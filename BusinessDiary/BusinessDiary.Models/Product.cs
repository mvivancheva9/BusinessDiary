using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDiary.Models
{
    public class Product
    {
        private ICollection<SalesPerProduct> salesPerProduct;
        private ICollection<RevenuesPerProduct> revenuesPerProduct;
        private ICollection<ProductsCenters> productsCenters;

        public Product()
        {
            this.salesPerProduct = new HashSet<SalesPerProduct>();
            this.productsCenters = new HashSet<ProductsCenters>();
            this.revenuesPerProduct = new HashSet<RevenuesPerProduct>();
        }

        public int Id { get; set; }

        public string SKU { get; set; }

        public int QuantityOrdered { get; set; }

        public double OrderPrice { get; set; }

        public double SellPrice { get; set; }

        public int ImportId { get; set; }

        [ForeignKey("ImportId")]
        public Import Import { get; set; }

        public int ColorId { get; set; }

        [ForeignKey("ColorId")]
        public Color Color { get; set;}

        public virtual ICollection<SalesPerProduct> SalesPerProduct { get; set; }

        public virtual ICollection<ProductsCenters> ProductsCenters { get; set; }

        public virtual ICollection<RevenuesPerProduct> RevenuesPerProduct { get; set; }
    }
}
