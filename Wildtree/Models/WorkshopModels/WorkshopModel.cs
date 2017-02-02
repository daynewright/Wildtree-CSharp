using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildtree.Models
{
    public class Workshop
    {
        [Key]
        public int WorkshopId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public bool isApproved { get; set; }

        [Required]
        public bool isSubmitted { get; set; }

        public DateTime WorkshopDate { get; set; }
    }
}