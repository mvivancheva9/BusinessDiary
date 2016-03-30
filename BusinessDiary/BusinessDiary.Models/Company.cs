namespace BusinessDiary.Models
{
    using System.Collections.Generic;

    public class Company
    {
        private ICollection<Import> imports;

        public Company()
        {
            this.imports = new HashSet<Import>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Import> Imports { get; set; }
    }
}
