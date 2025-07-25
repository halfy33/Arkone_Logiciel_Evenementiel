using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class ArkoneEnzoYanisContext : DbContext
{
    public ArkoneEnzoYanisContext()
    {
    }

    public ArkoneEnzoYanisContext(DbContextOptions<ArkoneEnzoYanisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evenement> Evenements { get; set; }

    public virtual DbSet<Invitation> Invitations { get; set; }

    public virtual DbSet<Invite> Invites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=2a03:5840:111:1024:143:e6a5:7dbe:31b3;Database=Arkone_Enzo_Yanis;User ID=sa;Password=erty64%;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evenement>(entity =>
        {
            entity.HasKey(e => e.IdEvenement).HasName("PK__Evenemen__AB2A1D5935133FD8");

            entity.ToTable("Evenement");

            entity.Property(e => e.IdEvenement).HasColumnName("idEvenement");
            entity.Property(e => e.DateEvenement)
                .HasColumnType("datetime")
                .HasColumnName("dateEvenement");
            entity.Property(e => e.Latitude)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("latitude");
            entity.Property(e => e.Lieu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lieu");
            entity.Property(e => e.Longitude)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("longitude");
            entity.Property(e => e.NomEvenement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nomEvenement");
        });

        modelBuilder.Entity<Invitation>(entity =>
        {
            entity.HasKey(e => e.IdInvitation).HasName("PK__Invitati__CE65ED713866DB34");

            entity.ToTable("Invitation");

            entity.Property(e => e.IdInvitation).HasColumnName("idInvitation");
            entity.Property(e => e.Code)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.EstPresent).HasColumnName("estPresent");
            entity.Property(e => e.IdEvenement).HasColumnName("idEvenement");
            entity.Property(e => e.IdInvite).HasColumnName("idInvite");

            entity.HasOne(d => d.IdEvenementNavigation).WithMany(p => p.Invitations)
                .HasForeignKey(d => d.IdEvenement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Invitatio__idEve__3A81B327");

            entity.HasOne(d => d.IdInviteNavigation).WithMany(p => p.Invitations)
                .HasForeignKey(d => d.IdInvite)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Invitatio__idInv__3B75D760");
        });

        modelBuilder.Entity<Invite>(entity =>
        {
            entity.HasKey(e => e.IdInvite).HasName("PK__Invite__2991481F2BC844A3");

            entity.ToTable("Invite");

            entity.Property(e => e.IdInvite).HasColumnName("idInvite");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telephone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
