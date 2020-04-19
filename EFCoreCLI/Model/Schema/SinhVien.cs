using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 namespace EFCORECLI.MODEL.Schema
{
 [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public string MSSV { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public DateTime? Birthday {get;set;}
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}