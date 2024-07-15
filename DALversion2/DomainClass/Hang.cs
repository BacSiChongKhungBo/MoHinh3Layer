using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALversion2.DomainClass;

[Table("hang")]
public partial class Hang
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("tenHang")]
    [StringLength(50)]
    public string? TenHang { get; set; }

    [InverseProperty("IdHangNavigation")]
    public virtual ICollection<Nuocngot> Nuocngots { get; set; } = new List<Nuocngot>();
}
