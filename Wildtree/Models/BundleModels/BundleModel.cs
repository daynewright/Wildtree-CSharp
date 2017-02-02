using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wildtree.Models
{
    public class Bundle
    {
        [Key]
        public int BundleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Price { get; set; }
    }
}