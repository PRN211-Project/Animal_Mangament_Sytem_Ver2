using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Animal_Management_SystemContext : DbContext
    {
        public Animal_Management_SystemContext()
        {
        }

        public Animal_Management_SystemContext(DbContextOptions<Animal_Management_SystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodAnimal> FoodAnimals { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Animal_Management_System;Trusted_Connection=False;User ID=sa;Password=Admin123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.ImportedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("imported_DateTime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__Animal__area_id__2D27B809");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Animal__type_id__2C3393D0");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Square).HasColumnName("square");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Username, "UQ__Employee__F3DBC5728FF101B0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("username");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__Employee__area_i__29572725");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FoodAnimal>(entity =>
            {
                entity.ToTable("food_animal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnimalId).HasColumnName("animal_id");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.FoodAnimals)
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("FK__food_anim__anima__32E0915F");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.FoodAnimals)
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("FK__food_anim__food___31EC6D26");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
