using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Entity_Framework.Entities;

namespace ConsoleApp1.Migrations
{
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp1.Entities.Course", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("DurationHours")
                    .HasColumnType("int");

                b.Property<decimal>("Price")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.ToTable("Review", (string)null);

                b.ToTable("Instructors", (string)null);
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Review", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("CourseID")
                    .HasColumnType("int");

                b.Property<string>("StudentID")
                    .HasColumnType("int");

                

                b.HasKey("Id");

                b.HasIndex("CourseID");

                b.HasIndex("StudentID");

                b.ToTable("Course", (string)null);

                 b.ToTable("Student", (string)null);
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Instructor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Patronymic")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CourseID")
                    .IsRequired()
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("CourseID");

                b.ToTable("Course", (string)null);
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Student", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Patronymic")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("EnrollmentDate")
                    .IsRequired()
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Review", (string)null);
            });

            

            modelBuilder.Entity("ConsoleApp1.Entities.Course", b =>
            {
                b.HasOne("ConsoleApp1.Entities.Course", "Course")
                    .WithMany("Students")
                    .HasForeignKey("Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Review");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Review", b =>
            {
                b.HasOne("ConsoleApp1.Entities.Student", "Student")
                    .WithMany("Review")
                    .HasForeignKey("StudentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("ConsoleApp1.Entities.Course", "Course")
                    .WithMany("Review")
                    .HasForeignKey("CourseId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Student");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Student", b =>
            {
                b.HasOne("ConsoleApp1.Entities.Student", "Student")
                    .WithMany("Course")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Course");
                b.Navigation("Review");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Instructor", b =>
            {
                b.HasOne("ConsoleApp1.Entities.Instructor", "Instructor")
                    .WithOne("Course")
                    .HasForeignKey("CourseId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Course");

            });

            modelBuilder.Entity("ConsoleApp1.Entities.Course", b =>
            {
                b.Navigation("Student");
                b.Navigation("Instructor");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Review", b =>
            {
                b.Navigation("Course");
                b.Navigation("Student");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Student", b =>
            {
                b.Navigation("Review");
            });

            modelBuilder.Entity("ConsoleApp1.Entities.Instructor", b =>
            {
                b.Navigation("Course");
            });

        }
    }
}
