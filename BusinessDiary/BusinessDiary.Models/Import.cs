namespace BusinessDiary.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Import
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
