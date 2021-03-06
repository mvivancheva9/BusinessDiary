﻿namespace BusinessDiary.Models
{
    using System.Collections.Generic;

    public class Company
    {
        private ICollection<Import> imports;
        private ICollection<Product> products;

        public Company()
        {
            this.imports = new HashSet<Import>();
            this.products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Import> Imports { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
