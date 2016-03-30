using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDiary.Models
{
    public class Color
    {
        private ICollection<Product> products;

        public Color()
        {
            this.products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
