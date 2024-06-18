﻿// <auto-generated />
using System;
using LayerDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LayerDataAccess.Migrations
{
    [DbContext(typeof(DbConnect))]
    [Migration("20240610175548_Blog1")]
    partial class Blog1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LayerEntity.Entities.Hakkinda", b =>
                {
                    b.Property<int>("HakkindaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HakkindaID"));

                    b.Property<string>("HakkindaDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HakkindaDurum")
                        .HasColumnType("bit");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkindaID");

                    b.ToTable("Hakkinda");
                });

            modelBuilder.Entity("LayerEntity.Entities.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("KategoriAciklamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KategoriDurum")
                        .HasColumnType("bit");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("LayerEntity.Entities.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MesajID"));

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajDurumu")
                        .HasColumnType("bit");

                    b.Property<string>("MesajIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajKullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajKullaniciEposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MesajTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesaj");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"));

                    b.Property<string>("YazarAciklamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YazarDurumu")
                        .HasColumnType("bit");

                    b.Property<string>("YazarEposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarResmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yazi", b =>
                {
                    b.Property<int>("YaziID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YaziID"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyukResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("KucukResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.Property<bool>("YaziDurumu")
                        .HasColumnType("bit");

                    b.HasKey("YaziID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("YazarID");

                    b.ToTable("Yazi");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"));

                    b.Property<int>("YaziID")
                        .HasColumnType("int");

                    b.Property<string>("YorumBasligi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YorumDurumu")
                        .HasColumnType("bit");

                    b.Property<string>("YorumIcerigi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumKullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("YaziID");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yazi", b =>
                {
                    b.HasOne("LayerEntity.Entities.Kategori", "Kategori")
                        .WithMany("Yazilar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LayerEntity.Entities.Yazar", "Yazar")
                        .WithMany("Yazilar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yorum", b =>
                {
                    b.HasOne("LayerEntity.Entities.Yazi", "Yazi")
                        .WithMany("Yorumlar")
                        .HasForeignKey("YaziID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazi");
                });

            modelBuilder.Entity("LayerEntity.Entities.Kategori", b =>
                {
                    b.Navigation("Yazilar");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yazar", b =>
                {
                    b.Navigation("Yazilar");
                });

            modelBuilder.Entity("LayerEntity.Entities.Yazi", b =>
                {
                    b.Navigation("Yorumlar");
                });
#pragma warning restore 612, 618
        }
    }
}