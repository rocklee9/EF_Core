
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

  namespace EFCORECLI.MODEL.Schema
{
 [Table("LopHocPhan")]
    public class LopHocPhan
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("HocPhan")]
        public int IdHocPhan { get; set; }

        [ForeignKey("SinhVien")]
        public string MSSV { get; set; }

        public virtual SinhVien SinhVien { get; set; }
        public virtual HocPhan HocPhan { get; set; }

    }
}