using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

  namespace EFCORECLI.MODEL.Schema
{
 [Table("HocPhan")]
    public class HocPhan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}