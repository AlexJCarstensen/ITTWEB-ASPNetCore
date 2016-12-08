using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ITTWEB_ASPNetCore.Persistence;
using ITTWEB_ASPNetCore.Core.Domain;

namespace ITTWEBASPNetCore.Migrations
{
    [DbContext(typeof(EmbeddedStockContext))]
    [Migration("20161205204703_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.CategoryComponentType", b =>
                {
                    b.Property<int>("CategoryComponentTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("ComponentTypeId");

                    b.HasKey("CategoryComponentTypeId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ComponentTypeId");

                    b.ToTable("CategoryComponentTypes");
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.Component", b =>
                {
                    b.Property<int>("ComponentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminComment");

                    b.Property<int>("ComponentNumber");

                    b.Property<int>("ComponentTypeId");

                    b.Property<int?>("CurrentLoanInformationId");

                    b.Property<string>("SerialNo");

                    b.Property<int>("Status");

                    b.Property<string>("UserComment");

                    b.HasKey("ComponentId");

                    b.HasIndex("ComponentTypeId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.ComponentType", b =>
                {
                    b.Property<int>("ComponentTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminComment");

                    b.Property<string>("ComponentInfo");

                    b.Property<string>("ComponentName");

                    b.Property<string>("Datasheet");

                    b.Property<int?>("ImageESImageId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Location");

                    b.Property<string>("Manufacturer");

                    b.Property<int>("Status");

                    b.Property<string>("WikiLink");

                    b.HasKey("ComponentTypeId");

                    b.HasIndex("ImageESImageId");

                    b.ToTable("ComponentTypes");
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.ESImage", b =>
                {
                    b.Property<int>("ESImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("ImageMimeType")
                        .HasMaxLength(128);

                    b.Property<byte[]>("Thumbnail");

                    b.HasKey("ESImageId");

                    b.ToTable("EsImages");
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.CategoryComponentType", b =>
                {
                    b.HasOne("ITTWEB_ASPNetCore.Core.Domain.Category", "Category")
                        .WithMany("CategoryComponentTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITTWEB_ASPNetCore.Core.Domain.ComponentType", "ComponentType")
                        .WithMany("CategoryComponentTypes")
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.Component", b =>
                {
                    b.HasOne("ITTWEB_ASPNetCore.Core.Domain.ComponentType")
                        .WithMany("Components")
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITTWEB_ASPNetCore.Core.Domain.ComponentType", b =>
                {
                    b.HasOne("ITTWEB_ASPNetCore.Core.Domain.ESImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageESImageId");
                });
        }
    }
}
