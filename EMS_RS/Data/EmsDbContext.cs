using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMS_RS.Data;

public partial class EmsDbContext : DbContext
{
    public EmsDbContext()
    {
    }

    public EmsDbContext(DbContextOptions<EmsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Respond> Responds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=emsDb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.ToTable("Car");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Plate)
                .HasMaxLength(10)
                .HasColumnName("plate");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.ToTable("Doctor");

            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Rank)
                .HasMaxLength(50)
                .HasColumnName("rank");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");

            entity.HasOne(d => d.Hospital).WithMany(p => p.Doctors)
                .HasForeignKey(d => d.HospitalId)
                .HasConstraintName("FK_Doctor_Hospital");
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.ToTable("Hospital");

            entity.Property(e => e.HospitalId).HasColumnName("hospital_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.ToTable("Patient");

            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("birthday");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sex");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Respond>(entity =>
        {
            entity.ToTable("Respond");

            entity.Property(e => e.RespondId).HasColumnName("respond_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Car).WithMany(p => p.Responds)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK_Respond_Car");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Responds)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK_Respond_Doctor");

            entity.HasOne(d => d.Patient).WithMany(p => p.Responds)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK_Respond_Patient");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
