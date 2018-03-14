namespace CourseProject2017.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Chef
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public int? Salary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [Column("Pozition_name")]
        [StringLength(50)]
        public string Pozition_name { get; set; }
    }
}
