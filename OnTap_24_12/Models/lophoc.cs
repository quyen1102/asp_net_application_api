namespace OnTap_24_12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lophoc")]
    public partial class lophoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lophoc()
        {
            sinhviens = new HashSet<sinhvien>();
        }

        [Key]
        public int malop { get; set; }

        [StringLength(30)]
        public string tenlop { get; set; }

        [StringLength(20)]
        public string giangvien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhvien> sinhviens { get; set; }
    }
}
