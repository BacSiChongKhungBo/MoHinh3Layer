using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALversion2.DomainClass;

[Table("NUOCNGOT")]
public partial class Nuocngot
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string? Ten { get; set; }

    [Column("idHang")]
    public int? IdHang { get; set; }

    [Column("gia")]
    public double? Gia { get; set; }

    [ForeignKey("IdHang")]
    [InverseProperty("Nuocngots")]
    public virtual Hang? IdHangNavigation { get; set; }
}
