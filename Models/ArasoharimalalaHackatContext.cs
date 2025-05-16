using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace HackatonLourd.Models;

public partial class ArasoharimalalaHackatContext : DbContext
{
    public ArasoharimalalaHackatContext()
    {
    }

    public ArasoharimalalaHackatContext(DbContextOptions<ArasoharimalalaHackatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Eventatelier> Eventateliers { get; set; }

    public virtual DbSet<Eventconference> Eventconferences { get; set; }

    public virtual DbSet<Hackaton> Hackatons { get; set; }

    public virtual DbSet<Inscription> Inscriptions { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.4.1;port=3306;user=sqlarasoaharimalala;password=savary;database=arasoharimalala_hackat;sslmode=required", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.11-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Eventatelier>(entity =>
        {
            entity.HasKey(e => e.Idevent).HasName("PRIMARY");

            entity.HasOne(d => d.IdhackNavigation).WithMany(p => p.Eventateliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENT_HACKATON_2");
        });

        modelBuilder.Entity<Eventconference>(entity =>
        {
            entity.HasKey(e => e.Idevent).HasName("PRIMARY");

            entity.HasOne(d => d.IdhackNavigation).WithMany(p => p.Eventconferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EVENT_HACKATON_3");
        });

        modelBuilder.Entity<Hackaton>(entity =>
        {
            entity.HasKey(e => e.Idhack).HasName("PRIMARY");
        });

        modelBuilder.Entity<Inscription>(entity =>
        {
            entity.HasKey(e => e.Idinscription).HasName("PRIMARY");

            entity.HasOne(d => d.IdhackNavigation).WithMany(p => p.Inscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INSCRIPTION_HACKATON");

            entity.HasOne(d => d.IdutilNavigation).WithMany(p => p.Inscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INSCRIPTION_UTILISATEUR");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Idutil).HasName("PRIMARY");

            entity.HasMany(d => d.Idevents).WithMany(p => p.Idutils)
                .UsingEntity<Dictionary<string, object>>(
                    "Participer",
                    r => r.HasOne<Eventatelier>().WithMany()
                        .HasForeignKey("Idevent")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PARTICIPER_EVENTATELIER"),
                    l => l.HasOne<Utilisateur>().WithMany()
                        .HasForeignKey("Idutil")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PARTICIPER_UTILISATEUR"),
                    j =>
                    {
                        j.HasKey("Idutil", "Idevent")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("PARTICIPER");
                        j.HasIndex(new[] { "Idevent" }, "FK_PARTICIPER_EVENTATELIER");
                        j.IndexerProperty<int>("Idutil")
                            .HasColumnType("int(100)")
                            .HasColumnName("IDUTIL");
                        j.IndexerProperty<int>("Idevent")
                            .HasColumnType("int(2)")
                            .HasColumnName("IDEVENT");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
