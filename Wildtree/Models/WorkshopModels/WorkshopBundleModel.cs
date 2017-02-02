using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildtree.Models
{
    public class WorkshopBundle
    {
        [Key]
        public int WorkshopBundleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [Required]
        public int WorkshopId { get; set; }
        public Workshop Workshop { get; set; }

        [Required]
        public int BundleId { get; set; }
        public Bundle Bundle { get; set; }
    }

}