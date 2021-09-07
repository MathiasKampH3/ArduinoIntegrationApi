﻿// <auto-generated />
using System;
using ArduinoIntegrationApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArduinoIntegrationApi.Migrations
{
    [DbContext(typeof(ArduinoApiContext))]
    [Migration("20210907131720_addedAnnotation")]
    partial class addedAnnotation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.LightSensor", b =>
                {
                    b.Property<int>("L_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentType")
                        .HasColumnType("int");

                    b.Property<DateTime>("L_Cts")
                        .HasColumnType("datetime2");

                    b.Property<bool>("L_Value")
                        .HasColumnType("bit");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("L_Id");

                    b.HasIndex("RoomName");

                    b.ToTable("LightSensors");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.Room", b =>
                {
                    b.Property<string>("RoomName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoomName");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.TemperatureSensor", b =>
                {
                    b.Property<int>("T_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentType")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("T_Cts")
                        .HasColumnType("datetime2");

                    b.Property<float>("T_Value")
                        .HasColumnType("real");

                    b.HasKey("T_Id");

                    b.HasIndex("RoomName");

                    b.ToTable("TemperatureSensors");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.WindowLock", b =>
                {
                    b.Property<int>("W_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentType")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("W_Cts")
                        .HasColumnType("datetime2");

                    b.Property<bool>("W_Value")
                        .HasColumnType("bit");

                    b.HasKey("W_Id");

                    b.HasIndex("RoomName");

                    b.ToTable("WindowLocks");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.LightSensor", b =>
                {
                    b.HasOne("ArduinoIntegrationApi.DataModels.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomName");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.TemperatureSensor", b =>
                {
                    b.HasOne("ArduinoIntegrationApi.DataModels.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomName");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ArduinoIntegrationApi.DataModels.WindowLock", b =>
                {
                    b.HasOne("ArduinoIntegrationApi.DataModels.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomName");

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
