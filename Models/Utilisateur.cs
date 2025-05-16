using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatonLourd.Models;

[Table("UTILISATEUR")]
public partial class Utilisateur
{
    [Key]
    [Column("IDUTIL", TypeName = "int(100)")]
    public int Idutil { get; set; }

    [Column("NOMUTIL")]
    [StringLength(255)]
    public string? Nomutil { get; set; }

    [Column("PRENOMUTIL")]
    [StringLength(255)]
    public string? Prenomutil { get; set; }

    [Column("MAILUTIL")]
    [StringLength(255)]
    public string? Mailutil { get; set; }

    [Column("TELUTIL")]
    [StringLength(255)]
    public string? Telutil { get; set; }

    [Column("DATENAISSUTIL")]
    public DateOnly? Datenaissutil { get; set; }

    [Column("LIENPORTFOLIOUTIL")]
    [StringLength(1000)]
    public string? Lienportfolioutil { get; set; }

    [Column("IDENTIFIANTUTIL")]
    [StringLength(255)]
    public string? Identifiantutil { get; set; }

    [Column("MDPUTIL")]
    [StringLength(255)]
    public string? Mdputil { get; set; }

    [InverseProperty("IdutilNavigation")]
    public virtual ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();

    [ForeignKey("Idutil")]
    [InverseProperty("Idutils")]
    public virtual ICollection<Eventatelier> Idevents { get; set; } = new List<Eventatelier>();
}
