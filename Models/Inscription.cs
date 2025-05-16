using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatonLourd.Models;

[Table("INSCRIPTION")]
[Index("Idhack", Name = "FK_INSCRIPTION_HACKATON")]
[Index("Idutil", Name = "FK_INSCRIPTION_UTILISATEUR")]
public partial class Inscription
{
    [Key]
    [Column("IDINSCRIPTION", TypeName = "int(2)")]
    public int Idinscription { get; set; }

    [Column("IDHACK", TypeName = "int(2)")]
    public int Idhack { get; set; }

    [Column("IDUTIL", TypeName = "int(100)")]
    public int Idutil { get; set; }

    [Column("DATEINSCRIPTION")]
    public DateOnly? Dateinscription { get; set; }

    [Column("MONTANT", TypeName = "int(11)")]
    public int Montant { get; set; }

    [ForeignKey("Idhack")]
    [InverseProperty("Inscriptions")]
    public virtual Hackaton IdhackNavigation { get; set; } = null!;

    [ForeignKey("Idutil")]
    [InverseProperty("Inscriptions")]
    public virtual Utilisateur IdutilNavigation { get; set; } = null!;
}
