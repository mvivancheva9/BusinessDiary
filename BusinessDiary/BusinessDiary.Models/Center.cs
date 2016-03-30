using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDiary.Models
{
    public class Center
    {
        private ICollection<ProductsCenters> productsCenters;

        public Center()
        {
            this.productsCenters = new HashSet<ProductsCenters>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ProductsCenters> ProductsCenters { get; set; }
    }
}
