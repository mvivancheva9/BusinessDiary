namespace BusinessDiary.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Import
    {
        private ICollection<Product> products;

        public Import()
        {
            this.products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
