namespace BackstageMnagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Draft")]
    public partial class Draft
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [Required]
        [StringLength(20)]
        public string SchoolYear { get; set; }

        [Required]
        [StringLength(40)]
        public string College { get; set; }

        [Required]
        [StringLength(30)]
        public string Category { get; set; }
    }
}
