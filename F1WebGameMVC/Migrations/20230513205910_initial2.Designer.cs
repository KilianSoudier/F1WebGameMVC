﻿// <auto-generated />
using F1WebGame.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F1WebGame.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230513205910_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("F1WebGame.Class.Cicruit", b =>
                {
                    b.Property<int>("idCircuit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCircuit"));

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("saisonidSaison")
                        .HasColumnType("int");

                    b.Property<int>("usureEssence")
                        .HasColumnType("int");

                    b.Property<int>("usurePneus")
                        .HasColumnType("int");

                    b.HasKey("idCircuit");

                    b.HasIndex("saisonidSaison");

                    b.ToTable("Circuit");
                });

            modelBuilder.Entity("F1WebGame.Class.Ecurie", b =>
                {
                    b.Property<int>("idEcurie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEcurie"));

                    b.Property<string>("nomEcurie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEcurie");

                    b.ToTable("Ecuries");
                });

            modelBuilder.Entity("F1WebGame.Class.Pilote", b =>
                {
                    b.Property<int>("idPilote")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPilote"));

                    b.Property<int>("VoitureidVoiture")
                        .HasColumnType("int");

                    b.Property<int>("economieEssence")
                        .HasColumnType("int");

                    b.Property<int>("economiePneus")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vitessePointe")
                        .HasColumnType("int");

                    b.Property<int>("vitesseVirage")
                        .HasColumnType("int");

                    b.HasKey("idPilote");

                    b.HasIndex("VoitureidVoiture");

                    b.ToTable("Pilote");
                });

            modelBuilder.Entity("F1WebGame.Class.Saison", b =>
                {
                    b.Property<int>("idSaison")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSaison"));

                    b.Property<string>("libelleSaison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSaison");

                    b.ToTable("Saison");
                });

            modelBuilder.Entity("F1WebGame.Class.Voiture", b =>
                {
                    b.Property<int>("idVoiture")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVoiture"));

                    b.Property<int>("economieEssence")
                        .HasColumnType("int");

                    b.Property<int>("economiePneus")
                        .HasColumnType("int");

                    b.Property<int>("ecurieidEcurie")
                        .HasColumnType("int");

                    b.Property<int>("maniabilite")
                        .HasColumnType("int");

                    b.Property<string>("nomVoiture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("saisonidSaison")
                        .HasColumnType("int");

                    b.Property<int>("vitessePointe")
                        .HasColumnType("int");

                    b.HasKey("idVoiture");

                    b.HasIndex("ecurieidEcurie");

                    b.HasIndex("saisonidSaison");

                    b.ToTable("Voiture");
                });

            modelBuilder.Entity("F1WebGame.Class.Cicruit", b =>
                {
                    b.HasOne("F1WebGame.Class.Saison", "saison")
                        .WithMany()
                        .HasForeignKey("saisonidSaison")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("saison");
                });

            modelBuilder.Entity("F1WebGame.Class.Pilote", b =>
                {
                    b.HasOne("F1WebGame.Class.Voiture", "Voiture")
                        .WithMany()
                        .HasForeignKey("VoitureidVoiture")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voiture");
                });

            modelBuilder.Entity("F1WebGame.Class.Voiture", b =>
                {
                    b.HasOne("F1WebGame.Class.Ecurie", "ecurie")
                        .WithMany()
                        .HasForeignKey("ecurieidEcurie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Saison", "saison")
                        .WithMany()
                        .HasForeignKey("saisonidSaison")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ecurie");

                    b.Navigation("saison");
                });
#pragma warning restore 612, 618
        }
    }
}
