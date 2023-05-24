﻿// <auto-generated />
using System;
using F1WebGame.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F1WebGame.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoursePilote", b =>
                {
                    b.Property<int>("CoursesidCourse")
                        .HasColumnType("int");

                    b.Property<int>("pilotesidPilote")
                        .HasColumnType("int");

                    b.HasKey("CoursesidCourse", "pilotesidPilote");

                    b.HasIndex("pilotesidPilote");

                    b.ToTable("CoursePilote");
                });

            modelBuilder.Entity("F1WebGame.Class.Circuit", b =>
                {
                    b.Property<int>("idCircuit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCircuit"));

                    b.Property<int>("PaysidPays")
                        .HasColumnType("int");

                    b.Property<float>("distanceTour")
                        .HasColumnType("real");

                    b.Property<int>("ligneDroite")
                        .HasColumnType("int");

                    b.Property<int>("nbTours")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ordre")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("premierGP")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("recordTour")
                        .HasColumnType("time");

                    b.Property<int>("saisonidSaison")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("tempsMoyen")
                        .HasColumnType("time");

                    b.Property<int>("usureEssence")
                        .HasColumnType("int");

                    b.Property<int>("usurePneus")
                        .HasColumnType("int");

                    b.Property<int>("virages")
                        .HasColumnType("int");

                    b.HasKey("idCircuit");

                    b.HasIndex("PaysidPays");

                    b.HasIndex("saisonidSaison");

                    b.ToTable("Circuit");
                });

            modelBuilder.Entity("F1WebGame.Class.Classements", b =>
                {
                    b.Property<int>("ClassementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassementId"));

                    b.Property<int>("CircuitidCircuit")
                        .HasColumnType("int");

                    b.Property<int>("ecurieidEcurie")
                        .HasColumnType("int");

                    b.Property<int>("piloteidPilote")
                        .HasColumnType("int");

                    b.Property<int>("pointsConstructeur")
                        .HasColumnType("int");

                    b.Property<int>("pointsPilotes")
                        .HasColumnType("int");

                    b.HasKey("ClassementId");

                    b.HasIndex("CircuitidCircuit");

                    b.HasIndex("ecurieidEcurie");

                    b.HasIndex("piloteidPilote");

                    b.ToTable("Classement");
                });

            modelBuilder.Entity("F1WebGame.Class.Ecurie", b =>
                {
                    b.Property<int>("idEcurie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEcurie"));

                    b.Property<int>("PaysidPays")
                        .HasColumnType("int");

                    b.Property<string>("colorEcriture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colorSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomEcurie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ordre")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEcurie");

                    b.HasIndex("PaysidPays");

                    b.ToTable("Ecuries");
                });

            modelBuilder.Entity("F1WebGame.Class.Pays", b =>
                {
                    b.Property<int>("idPays")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPays"));

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoDrapeau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPays");

                    b.ToTable("Pays");
                });

            modelBuilder.Entity("F1WebGame.Class.Pilote", b =>
                {
                    b.Property<int>("idPilote")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPilote"));

                    b.Property<int>("PaysidPays")
                        .HasColumnType("int");

                    b.Property<int>("VoitureidVoiture")
                        .HasColumnType("int");

                    b.Property<int>("economieEssence")
                        .HasColumnType("int");

                    b.Property<int>("economiePneus")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ordre")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vitessePointe")
                        .HasColumnType("int");

                    b.Property<int>("vitesseVirage")
                        .HasColumnType("int");

                    b.HasKey("idPilote");

                    b.HasIndex("PaysidPays");

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

            modelBuilder.Entity("F1WebGameMVC.Models.Course", b =>
                {
                    b.Property<int>("idCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCourse"));

                    b.Property<int>("CircuitidCircuit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("saisonidSaison")
                        .HasColumnType("int");

                    b.Property<bool>("terminee")
                        .HasColumnType("bit");

                    b.HasKey("idCourse");

                    b.HasIndex("CircuitidCircuit");

                    b.HasIndex("saisonidSaison");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("F1WebGameMVC.Models.Pneus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SaisonidSaison")
                        .HasColumnType("int");

                    b.Property<int>("distanceMax")
                        .HasColumnType("int");

                    b.Property<int>("distanceMin")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("pourcentageFiable")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("SaisonidSaison");

                    b.ToTable("Pneus");
                });

            modelBuilder.Entity("F1WebGameMVC.Models.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseidCourse")
                        .HasColumnType("int");

                    b.Property<int>("PiloteidPilote")
                        .HasColumnType("int");

                    b.Property<bool>("abandon")
                        .HasColumnType("bit");

                    b.Property<bool>("erreurMajeure")
                        .HasColumnType("bit");

                    b.Property<int>("nb")
                        .HasColumnType("int");

                    b.Property<int>("pneusId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("tempsTour")
                        .HasColumnType("time");

                    b.Property<float>("usurePneus")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CourseidCourse");

                    b.HasIndex("PiloteidPilote");

                    b.HasIndex("pneusId");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("CoursePilote", b =>
                {
                    b.HasOne("F1WebGameMVC.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesidCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Pilote", null)
                        .WithMany()
                        .HasForeignKey("pilotesidPilote")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("F1WebGame.Class.Circuit", b =>
                {
                    b.HasOne("F1WebGame.Class.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("PaysidPays")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Saison", "saison")
                        .WithMany()
                        .HasForeignKey("saisonidSaison")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pays");

                    b.Navigation("saison");
                });

            modelBuilder.Entity("F1WebGame.Class.Classements", b =>
                {
                    b.HasOne("F1WebGame.Class.Circuit", "Circuit")
                        .WithMany()
                        .HasForeignKey("CircuitidCircuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Ecurie", "ecurie")
                        .WithMany()
                        .HasForeignKey("ecurieidEcurie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Pilote", "pilote")
                        .WithMany()
                        .HasForeignKey("piloteidPilote")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Circuit");

                    b.Navigation("ecurie");

                    b.Navigation("pilote");
                });

            modelBuilder.Entity("F1WebGame.Class.Ecurie", b =>
                {
                    b.HasOne("F1WebGame.Class.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("PaysidPays")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pays");
                });

            modelBuilder.Entity("F1WebGame.Class.Pilote", b =>
                {
                    b.HasOne("F1WebGame.Class.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("PaysidPays")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Voiture", "Voiture")
                        .WithMany()
                        .HasForeignKey("VoitureidVoiture")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pays");

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

            modelBuilder.Entity("F1WebGameMVC.Models.Course", b =>
                {
                    b.HasOne("F1WebGame.Class.Circuit", "Circuit")
                        .WithMany()
                        .HasForeignKey("CircuitidCircuit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Saison", "saison")
                        .WithMany()
                        .HasForeignKey("saisonidSaison")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Circuit");

                    b.Navigation("saison");
                });

            modelBuilder.Entity("F1WebGameMVC.Models.Pneus", b =>
                {
                    b.HasOne("F1WebGame.Class.Saison", "Saison")
                        .WithMany()
                        .HasForeignKey("SaisonidSaison")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saison");
                });

            modelBuilder.Entity("F1WebGameMVC.Models.Tour", b =>
                {
                    b.HasOne("F1WebGameMVC.Models.Course", "Course")
                        .WithMany("tours")
                        .HasForeignKey("CourseidCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGame.Class.Pilote", "Pilote")
                        .WithMany()
                        .HasForeignKey("PiloteidPilote")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1WebGameMVC.Models.Pneus", "pneus")
                        .WithMany()
                        .HasForeignKey("pneusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Pilote");

                    b.Navigation("pneus");
                });

            modelBuilder.Entity("F1WebGameMVC.Models.Course", b =>
                {
                    b.Navigation("tours");
                });
#pragma warning restore 612, 618
        }
    }
}
