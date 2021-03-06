﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PushnotificationsDemo.Models;

namespace PushnotificationsDemo.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    partial class DemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PushnotificationsDemo.Models.PushSubscription", b =>
                {
                    b.Property<string>("P256Dh")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Auth")
                        .IsRequired();

                    b.Property<string>("Endpoint")
                        .IsRequired();

                    b.Property<double?>("ExpirationTime");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("P256Dh");

                    b.ToTable("PushSubscription");
                });
#pragma warning restore 612, 618
        }
    }
}
