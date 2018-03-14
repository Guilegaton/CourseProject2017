namespace CourseProject2017.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Orders
    {
        public int Id { get; set; }

        [Column("DishID")]
        public int DishID { get; set; }

        public int ChefId { get; set; }

        public DateTime? Time { get; set; }

        public bool State { get; set; }
    }
}
