namespace CourseProject2017.Classes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Menu")]
    public partial class Menu
    {
        public int Id { get; set; }

        [Column("DishName")]
        [Required]
        [StringLength(50)]
        public string DishName { get; set; }

        [Column("ReceptionID")]
        public int ReceptionID { get; set; }

        public int? Cost { get; set; }

        [Column("WaitingTime_Min")]
        public int? WaitingTime_Min { get; set; }
    }
}
