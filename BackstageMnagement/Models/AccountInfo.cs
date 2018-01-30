namespace BackstageMnagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountInfo")]
    public partial class AccountInfo
    {
        [Key]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(10)]
        public string Permissions { get; set; }

        [Required]
        [StringLength(40)]
        public string College { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDay { get; set; }

        [StringLength(60)]
        public string Question { get; set; }

        public int? TelPhone { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string QAnswer { get; set; }
    }
}
