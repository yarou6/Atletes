using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Atletes.Model;

public partial class _1135AlexandroDobruchoContext : DbContext
{
    public _1135AlexandroDobruchoContext()
    {
    }

    public _1135AlexandroDobruchoContext(DbContextOptions<_1135AlexandroDobruchoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Athlete> Athletes { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<LevelsOfTraining> LevelsOfTrainings { get; set; }

    public virtual DbSet<Participation> Participations { get; set; }

    public virtual DbSet<Progress> Progresses { get; set; }

    public virtual DbSet<Training> Trainings { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("userid=student;password=student;database=1135_Alexandro_Dobrucho;server=192.168.200.13", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.39-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Athlete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdCategory, "FK_Athletes_id_category");

            entity.HasIndex(e => e.IdLevelOfTraining, "FK_Athletes_id_level_of_training");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.IdCategory)
                .HasColumnType("int(11)")
                .HasColumnName("id_category");
            entity.Property(e => e.IdLevelOfTraining)
                .HasColumnType("int(11)")
                .HasColumnName("id_level_of_training");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Athletes_id_category");

            entity.HasOne(d => d.IdLevelOfTrainingNavigation).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.IdLevelOfTraining)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Athletes_id_level_of_training");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<LevelsOfTraining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Levels_Of_Trainings");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Participation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Participation");

            entity.HasIndex(e => e.IdAthlet, "FK_Participation_id_athlet");

            entity.HasIndex(e => e.IdTraining, "FK_Participation_id_training2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdAthlet)
                .HasColumnType("int(11)")
                .HasColumnName("id_athlet");
            entity.Property(e => e.IdTraining)
                .HasColumnType("int(11)")
                .HasColumnName("id_training");

            entity.HasOne(d => d.IdAthletNavigation).WithMany(p => p.Participations)
                .HasForeignKey(d => d.IdAthlet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Participation_id_athlet");

            entity.HasOne(d => d.IdTrainingNavigation).WithMany(p => p.Participations)
                .HasForeignKey(d => d.IdTraining)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Participation_id_training2");
        });

        modelBuilder.Entity<Progress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Progress");

            entity.HasIndex(e => e.IdParticipation, "FK_Progress_id_participation");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Комментарий не указан'")
                .HasColumnName("comment");
            entity.Property(e => e.Grade)
                .HasColumnType("smallint(6)")
                .HasColumnName("grade");
            entity.Property(e => e.IdParticipation)
                .HasColumnType("int(11)")
                .HasColumnName("id_participation");

            entity.HasOne(d => d.IdParticipationNavigation).WithMany(p => p.Progresses)
                .HasForeignKey(d => d.IdParticipation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Progress_id_participation");
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdType, "FK_Trainings_id_type");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdType)
                .HasColumnType("int(11)")
                .HasColumnName("id_type");
            entity.Property(e => e.Time)
                .HasColumnType("smallint(6)")
                .HasColumnName("time");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Training)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trainings_id_type");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
