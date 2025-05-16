using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatonLourd.Models;

[Table("EVENTCONFERENCE")]
[Index("Idhack", Name = "FK_EVENT_HACKATON_3")]
public partial class Eventconference
{
    [Key]
    [Column("IDEVENT", TypeName = "int(2)")]
    public int Idevent { get; set; }

    [Column("IDHACK", TypeName = "int(2)")]
    public int Idhack { get; set; }

    [Column("THEME")]
    [StringLength(255)]
    public string? Theme { get; set; }

    [Column("INTERVENANT")]
    [StringLength(255)]
    public string? Intervenant { get; set; }

    [Column("MAILINTERVENANT")]
    [StringLength(255)]
    public string Mailintervenant { get; set; } = null!;

    [Column("DATEEVENT", TypeName = "datetime")]
    public DateTime? Dateevent { get; set; }

    [Column("HEUREEVENT")]
    [StringLength(6)]
    public string? Heureevent { get; set; }

    [Column("DUREEEVENT", TypeName = "int(100)")]
    public int? Dureeevent { get; set; }

    [Column("NOMSALLE")]
    [StringLength(255)]
    public string? Nomsalle { get; set; }

    [ForeignKey("Idhack")]
    [InverseProperty("Eventconferences")]
    public virtual Hackaton IdhackNavigation { get; set; } = null!;
}
