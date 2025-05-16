using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatonLourd.Models;

[Table("HACKATON")]
public partial class Hackaton
{
    [Key]
    [Column("IDHACK", TypeName = "int(2)")]
    public int Idhack { get; set; }

    [Column("NBPLACESHACK", TypeName = "int(3)")]
    public int? Nbplaceshack { get; set; }

    [Column("DATELIMITEHACK", TypeName = "datetime")]
    public DateTime? Datelimitehack { get; set; }

    [Column("THEMEHACK")]
    [StringLength(255)]
    public string? Themehack { get; set; }

    [Column("DATEDEBUTHACK", TypeName = "datetime")]
    public DateTime? Datedebuthack { get; set; }

    [Column("DATEFINHACK", TypeName = "datetime")]
    public DateTime? Datefinhack { get; set; }

    [Column("HEUREDEBUTHACK")]
    [StringLength(6)]
    public string? Heuredebuthack { get; set; }

    [Column("HEUREFINHACK")]
    [StringLength(6)]
    public string? Heurefinhack { get; set; }

    [Column("VILLEHACK")]
    [StringLength(50)]
    public string? Villehack { get; set; }

    [Column("CPHACK")]
    [StringLength(255)]
    public string? Cphack { get; set; }

    [Column("RUEHACK")]
    [StringLength(128)]
    public string? Ruehack { get; set; }

    [InverseProperty("IdhackNavigation")]
    public virtual ICollection<Eventatelier> Eventateliers { get; set; } = new List<Eventatelier>();

    [InverseProperty("IdhackNavigation")]
    public virtual ICollection<Eventconference> Eventconferences { get; set; } = new List<Eventconference>();

    [InverseProperty("IdhackNavigation")]
    public virtual ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
}
