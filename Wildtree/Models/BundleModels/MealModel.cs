using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildtree.Models
{
    public class Meal
    {
        [Key]
        public int MealId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Meat { get; set; }
        public int index { get; set; }

        [Required]
        public int BundleId { get; set; }
        public Bundle Bundle { get; set; }
    }
}