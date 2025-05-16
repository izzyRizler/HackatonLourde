using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatonLourd.Models;

[Table("EVENTATELIER")]
[Index("Idhack", Name = "FK_EVENT_HACKATON_2")]
public partial class Eventatelier
{
    [Key]
    [Column("IDEVENT", TypeName = "int(2)")]
    public int Idevent { get; set; }

    [Column("IDHACK", TypeName = "int(2)")]
    public int Idhack { get; set; }

    [Column("NBPARTICIPANTS", TypeName = "int(3)")]
    public int? Nbparticipants { get; set; }

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
    [InverseProperty("Eventateliers")]
    public virtual Hackaton IdhackNavigation { get; set; } = null!;

    [ForeignKey("Idevent")]
    [InverseProperty("Idevents")]
    public virtual ICollection<Utilisateur> Idutils { get; set; } = new List<Utilisateur>();
}
