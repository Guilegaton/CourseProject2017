namespace CourseProject2017.Classes
{
    using System.ComponentModel.DataAnnotations;

    public partial class Products
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public decimal? Count { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
