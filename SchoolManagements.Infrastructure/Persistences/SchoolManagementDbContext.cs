using Microsoft.EntityFrameworkCore;
using SchoolManagements.Domain.Common;
using SchoolManagements.Domain.Common.Interfaces;
using SchoolManagements.Domain.Entities;


namespace SchoolManagements.Infrastructure.Persistences
{
    
    public class SchoolManagementDbContext : DbContext
    {
        #region Attributs
        
        private readonly IDomainEventDispatcher _dispatcher;
        #endregion

        #region Constructors
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options,
          IDomainEventDispatcher dispatcher)
            : base(options)
        {
            _dispatcher = dispatcher;
        }
        #endregion

        #region Propriétes Navigation
        //public DbSet<Attendance> dbsAttendance => Set<Attendance>();
        //public DbSet<Standard> dbsStandard => Set<Standard>();
        //public DbSet<Department> dbsDepartment => Set<Department>();
        //public DbSet<ExamSchedule> dbsExamSchedule => Set<ExamSchedule>();
        //public DbSet<ExamSubject> dbsExamSubject => Set<ExamSubject>();
        //public DbSet<ExamType> dbsExamType => Set<ExamType>();
        //public DbSet<Mark> dbsMark => Set<Mark>();
        //public DbSet<Staff> dbsStaff => Set<Staff>();
        //public DbSet<StaffExperience> dbsStaffExperience => Set<StaffExperience>();
        //public DbSet<StaffSalary> dbsStaffSalary => Set<StaffSalary>();
        //public DbSet<Student> dbsStudent => Set<Student>();
        //public DbSet<Subject> dbsSubject => Set<Subject>();
        //public DbSet<FeeType> dbsFeeType => Set<FeeType>();
        //public DbSet<DueBalance> dbsDueBalance => Set<DueBalance>();
        //public DbSet<AcademicMonth> dbsAcademicMonths => Set<AcademicMonth>();
        //public DbSet<AcademicYear> dbsAcademicYears => Set<AcademicYear>();
        //public DbSet<Fee> fees => Set<Fee>();
        //public DbSet<MonthlyPayment> monthlyPayments => Set<MonthlyPayment>();
        //public DbSet<OthersPayment> othersPayments => Set<OthersPayment>();
        //public DbSet<PaymentDetail> PaymentDetails => Set<PaymentDetail>();
        //public DbSet<OtherPaymentDetail> otherPaymentDetails => Set<OtherPaymentDetail>();
        //public DbSet<PaymentMonth> paymentMonths => Set<PaymentMonth>();
        //public DbSet<ExamScheduleStandard> dbsExamScheduleStandard => Set<ExamScheduleStandard>();
        //public DbSet<StudentMarksDetails> dbsStudentMarksDetails => Set<StudentMarksDetails>();
        #endregion

        #region Navigations

        public DbSet<Standard> dbsStandard => Set<Standard>();
        public DbSet<Department> dbsDepartment => Set<Department>();
        public DbSet<ExamType> dbsExamType => Set<ExamType>();
        public DbSet<Staff> dbsStaff => Set<Staff>();
        public DbSet<Student> dbsStudent => Set<Student>();
        public DbSet<Subject> dbsSubject => Set<Subject>();
        public DbSet<FeeType> dbsFeeType => Set<FeeType>();
        public DbSet<Fee> fees => Set<Fee>();
        public DbSet<StudentMarksDetails> dbsStudentMarksDetails => Set<StudentMarksDetails>();
        #endregion


        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("sm");

            #region Configure FK

            //#region Configure Mark

            //modelBuilder.Entity<Mark>()
            //   .HasOne(m => m.Subject)
            //   .WithMany()
            //   .HasForeignKey(m => m.SubjectId)
            //   .OnDelete(DeleteBehavior.NoAction);

            //#region  Configure Student
            //modelBuilder.Entity<Student>()
            //   .HasOne(s => s.Standard)
            //   .WithMany()
            //   .HasForeignKey(m => m.StandardId);
            //#endregion

            //modelBuilder.Entity<Mark>()
            //   .HasOne(m => m.Student)
            //   .WithMany()
            //   .HasForeignKey(m => m.StudentId)
            //   .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region Configure Standard

            modelBuilder.Entity<Standard>()
               .HasMany(s => s.Subjects)
               .WithOne()
               .HasForeignKey(s => s.StandardId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Standard>()
               .HasMany(s => s.ExamScheduleStandards)
               .WithOne()
               .HasForeignKey(s => s.StandardId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Standard>()
              .HasMany(s => s.Students)
              .WithOne()
              .HasForeignKey(s => s.StandardId)
              .OnDelete(DeleteBehavior.Cascade);
            #endregion

            modelBuilder.Entity<StudentMarksDetails>()
           .HasKey(c => new { c.StudentId, c.MarkEntryId });

            #endregion

            #region Index

            modelBuilder.Entity<Subject>()
            .HasIndex(s => s.SubjectCode)
            .IsUnique();

            modelBuilder.Entity<Student>()
                .HasIndex(s=>s.UniqueStudentAttendanceNumber)
                .IsUnique();

            modelBuilder.Entity<Staff>()
                .HasIndex(s=>s.UniqueStaffAttendanceNumber)
                .IsUnique();



            #endregion

            #region Seeder Data

            #region Department
            // Seed Department data
             modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Teacher" },
                new Department { Id = 2, DepartmentName = "Account" },
                new Department { Id = 3, DepartmentName = "Administration" },
                new Department { Id = 4, DepartmentName = "Student Affairs" },
                new Department { Id = 5, DepartmentName = "Counseling" },
                new Department { Id = 6, DepartmentName = "Sports" },
                new Department { Id = 7, DepartmentName = "Library" },
                new Department { Id = 8, DepartmentName = "Maintenance" }
            );
            #endregion

            #region ExamType
            // Seed ExamType data
            modelBuilder.Entity<ExamType>().HasData(
                new ExamType { Id = 1, ExamTypeName = "Midterm" },
                new ExamType { Id = 2, ExamTypeName = "Final" },
                new ExamType { Id = 3, ExamTypeName = "Practical" },
                new ExamType { Id = 4, ExamTypeName = "Monthly Exam" },
                new ExamType { Id = 5, ExamTypeName = "Lab Exam" }
            );
            #endregion


            #region FeeType
            // Seed FeeType data
            modelBuilder.Entity<FeeType>().HasData(
                new FeeType { Id = 1, TypeName = "Registration Fee" },
                new FeeType { Id = 2, TypeName = "Tuition Fee" },
                new FeeType { Id = 3, TypeName = "Library Fee" },
                new FeeType { Id = 4, TypeName = "Examination Fee" },
                new FeeType { Id = 5, TypeName = "Sports Fee" },
                new FeeType { Id = 6, TypeName = "Transportation Fee" }
            );
            #endregion

            //#region Mark
            //// Seed Mark data
            //modelBuilder.Entity<Mark>().HasData(
            //    new Mark
            //    {
            //        Id = 1,
            //        MarkId = 1,
            //        TotalMarks = 80,
            //        PassMarks = 40,
            //        ObtainedScore = 65,
            //        Grade = Grade.B,
            //        PassStatus = Pass.Passed,
            //        MarkEntryDate = DateTime.Now,
            //        Feedback = "Good job!",
            //        StaffId = 1,
            //        StudentId = 1,
            //        SubjectId = 1
            //    },
            //    new Mark
            //    {
            //        Id = 2,
            //        MarkId = 2,
            //        TotalMarks = 90,
            //        PassMarks = 40,
            //        ObtainedScore = 75,
            //        Grade = Grade.A,
            //        PassStatus = Pass.Passed,
            //        MarkEntryDate = DateTime.Now,
            //        Feedback = "Excellent work!",
            //        StaffId = 2,
            //        StudentId = 2,
            //        SubjectId = 2
            //    },
            //    new Mark
            //    {
            //        Id = 3,
            //        MarkId = 3,
            //        TotalMarks = 90,
            //        PassMarks = 40,
            //        ObtainedScore = 75,
            //        Grade = Grade.A,
            //        PassStatus = Pass.Passed,
            //        MarkEntryDate = DateTime.Now,
            //        Feedback = "Excellent work!",
            //        StaffId = 3,
            //        StudentId = 3,
            //        SubjectId = 3
            //    }
            //    // Add more seed data as needed
            //);
            //#endregion


            #region StaffSalary
            // Seed StaffSalary data if required
            modelBuilder.Entity<StaffSalary>().HasData(
                new StaffSalary
                {
                    Id = 1,
                    //StaffSalaryId = 1,
                    StaffName = "Jamir King",
                    BasicSalary = 5000,
                    FestivalBonus = 1000,
                    Allowance = 500,
                    MedicalAllowance = 300,
                    HousingAllowance = 800,
                    TransportationAllowance = 200,
                    SavingFund = 200,
                    Taxes = 500,
                },
               new StaffSalary
               {
                   Id = 2,
                   //StaffSalaryId = 2,
                   StaffName = "Jamir Jamidar",
                   BasicSalary = 5000,
                   FestivalBonus = 1000,
                   Allowance = 500,
                   MedicalAllowance = 300,
                   HousingAllowance = 800,
                   TransportationAllowance = 200,
                   SavingFund = 200,
                   Taxes = 500,
               },
               new StaffSalary
               {
                   Id = 3,
                   //StaffSalaryId = 3,
                   StaffName = "Jamir Amir",
                   BasicSalary = 5000,
                   FestivalBonus = 1000,
                   Allowance = 500,
                   MedicalAllowance = 300,
                   HousingAllowance = 800,
                   TransportationAllowance = 200,
                   SavingFund = 200,
                   Taxes = 500,
               }
            );
            #endregion

            #region Standard
            // Seed Standard data if required
            modelBuilder.Entity<Standard>().HasData(
                        new Standard { Id =1,/* StandardId = 1,*/ StandardName = "Class One", StandardCapacity = "30" },
                        new Standard { Id = 2,/* StandardId = 2,*/ StandardName = "Class Two", StandardCapacity = "35" },
                        new Standard { Id = 3, /*StandardId = 3,*/ StandardName = "Class Three", StandardCapacity = "32" },
                        new Standard { Id = 4, /*StandardId = 4,*/ StandardName = "Class Four", StandardCapacity = "28" },
                        new Standard { Id = 5, /*StandardId = 5,*/ StandardName = "Class Five", StandardCapacity = "30" },
                        new Standard { Id = 6, /*StandardId = 6, */StandardName = "Class Six", StandardCapacity = "30" },
                        new Standard { Id = 7, /*StandardId = 7,*/ StandardName = "Class Seven", StandardCapacity = "30" },
                        new Standard { Id = 8, /*StandardId = 8,*/ StandardName = "Class Eight", StandardCapacity = "30" },
                        new Standard { Id = 9, /*StandardId = 9,*/ StandardName = "Class Nine", StandardCapacity = "30" },
                        new Standard { Id = 10, /*StandardId = 10,*/ StandardName = "Class Ten", StandardCapacity = "30" }
                       );

            #endregion
            #region Student
            // Seed Student data if required
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    //StudentId = 1,
                    AdmissionNo = 1000,
                    EnrollmentNo = 2000,
                    UniqueStudentAttendanceNumber = 1000,
                    StudentName = "John Doe",
                    StudentGender = GenderList.Male,
                    StudentBloodGroup = "A+",
                    StudentNationality = "Bangladeshi",
                    StudentNIDNumber = "12345678901234567",
                    StudentContactNumber1 = "1234567890",
                    StudentEmail = "john.doe@example.com",
                    PermanentAddress = "123 Main Street, City, Country",
                    TemporaryAddress = "456 Elm Street, City, Country",
                    FatherName = "Michael Doe",
                    FatherNID = "17948678987624322",
                    FatherContactNumber = "9876543210",
                    MotherName = "Alice Doe",
                    MotherNID = "17948678987754322",
                    MotherContactNumber = "9876543220",
                    LocalGuardianName = "Jane Smith",
                    LocalGuardianContactNumber = "9876543230",
                    StandardId = 1,
                },
                new Student
                {
                    Id = 2,
                    //StudentId = 2,
                    AdmissionNo = 1001,
                    EnrollmentNo = 2001,
                    UniqueStudentAttendanceNumber = 1001,
                    StudentName = "Fatima Rahman",
                    StudentGender = GenderList.Female,
                    StudentBloodGroup = "B+",
                    StudentNationality = "Bangladeshi",
                    StudentNIDNumber = "12345678901234567",
                    StudentContactNumber1 = "9876543210",
                    StudentEmail = "fatima.rahman@example.com",
                    PermanentAddress = "Dhaka, Bangladesh",
                    TemporaryAddress = "Dhaka, Bangladesh",
                    FatherName = "Abdul Rahman",
                    FatherNID = "12345678901234567",
                    FatherContactNumber = "9876543220",
                    MotherName = "Ayesha Rahman",
                    MotherNID = "12345678901234568",
                    MotherContactNumber = "9876543230",
                    LocalGuardianName = "Kamal Ahmed",
                    LocalGuardianContactNumber = "9876543240",
                    StandardId = 1,
                },
                    new Student
                    {
                        Id = 3,
                        //StudentId = 3,
                        AdmissionNo = 1002,
                        EnrollmentNo = 2002,
                        UniqueStudentAttendanceNumber = 1002,
                        StudentName = "Aryan Khan",
                        StudentGender = GenderList.Male,
                        StudentBloodGroup = "O+",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "98765432109876543",
                        StudentContactNumber1 = "9876543211",
                        StudentEmail = "aryan.khan@example.com",
                        PermanentAddress = "Chittagong, Bangladesh",
                        TemporaryAddress = "Chittagong, Bangladesh",
                        FatherName = "Rahim Khan",
                        FatherNID = "98765432109876544",
                        FatherContactNumber = "9876543221",
                        MotherName = "Fatima Khan",
                        MotherNID = "98765432109876545",
                        MotherContactNumber = "9876543231",
                        LocalGuardianName = "Kamal Ahmed",
                        LocalGuardianContactNumber = "9876543241",
                        StandardId = 1,
                    },
                new Student
                {
                    Id = 4,
                    //StudentId = 4,
                    AdmissionNo = 1003,
                    EnrollmentNo = 2003,
                    UniqueStudentAttendanceNumber = 1003,
                    StudentName = "Tasnim Ahmed",
                    StudentGender = GenderList.Female,
                    StudentBloodGroup = "AB+",
                    StudentNationality = "Bangladeshi",
                    StudentNIDNumber = "76543210987654321",
                    StudentContactNumber1 = "9876543212",
                    StudentEmail = "tasnim.ahmed@example.com",
                    PermanentAddress = "Sylhet, Bangladesh",
                    TemporaryAddress = "Sylhet, Bangladesh",
                    FatherName = "Mahmud Ahmed",
                    FatherNID = "76543210987654322",
                    FatherContactNumber = "9876543222",
                    MotherName = "Farida Ahmed",
                    MotherNID = "76543210987654323",
                    MotherContactNumber = "9876543232",
                    LocalGuardianName = "Nadia Rahman",
                    LocalGuardianContactNumber = "9876543242",
                    StandardId = 2,
                },
                new Student
                {
                    Id = 5,
                    //StudentId = 5,
                    AdmissionNo = 1004,
                    EnrollmentNo = 2004,
                    UniqueStudentAttendanceNumber = 1004,
                    StudentName = "Imran Khan",
                    StudentGender = GenderList.Male,
                    StudentBloodGroup = "A-",
                    StudentNationality = "Bangladeshi",
                    StudentNIDNumber = "87654321098765432",
                    StudentContactNumber1 = "9876543213",
                    StudentEmail = "imran.khan@example.com",
                    PermanentAddress = "Rajshahi, Bangladesh",
                    TemporaryAddress = "Rajshahi, Bangladesh",
                    FatherName = "Nasir Khan",
                    FatherNID = "87654321098765433",
                    FatherContactNumber = "9876543223",
                    MotherName = "Sadia Khan",
                    MotherNID = "87654321098765434",
                    MotherContactNumber = "9876543233",
                    LocalGuardianName = "Abdul Ali",
                    LocalGuardianContactNumber = "9876543243",
                    StandardId = 2,
                },
                  new Student
                  {
                      Id = 6,
                      //StudentId = 6,
                      AdmissionNo = 1005,
                      EnrollmentNo = 2005,
                      UniqueStudentAttendanceNumber = 1005,
                      StudentName = "Anika Rahman",
                      StudentGender = GenderList.Female,
                      StudentBloodGroup = "B-",
                      StudentNationality = "Bangladeshi",
                      StudentNIDNumber = "65432109876543210",
                      StudentContactNumber1 = "9876543214",
                      StudentEmail = "anika.rahman@example.com",
                      PermanentAddress = "Dhaka, Bangladesh",
                      TemporaryAddress = "Dhaka, Bangladesh",
                      FatherName = "Hasan Rahman",
                      FatherNID = "65432109876543211",
                      FatherContactNumber = "9876543224",
                      MotherName = "Sabina Rahman",
                      MotherNID = "65432109876543212",
                      MotherContactNumber = "9876543234",
                      LocalGuardianName = "Khaled Islam",
                      LocalGuardianContactNumber = "9876543244",
                      StandardId = 2,
                  },
                    new Student
                    {
                        Id = 7,
                        //StudentId = 7,
                        AdmissionNo = 1006,
                        EnrollmentNo = 2006,
                        UniqueStudentAttendanceNumber = 1006,
                        StudentName = "Rafiul Islam",
                        StudentGender = GenderList.Male,
                        StudentBloodGroup = "O-",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "54321098765432109",
                        StudentContactNumber1 = "9876543215",
                        StudentEmail = "rafiul.islam@example.com",
                        PermanentAddress = "Chittagong, Bangladesh",
                        TemporaryAddress = "Chittagong, Bangladesh",
                        FatherName = "Rahman Islam",
                        FatherNID = "54321098765432110",
                        FatherContactNumber = "9876543225",
                        MotherName = "Amina Islam",
                        MotherNID = "54321098765432111",
                        MotherContactNumber = "9876543235",
                        LocalGuardianName = "Farid Ahmed",
                        LocalGuardianContactNumber = "9876543245",
                        StandardId = 3,
                    },
                    new Student
                    {
                        Id = 8,
                        //StudentId = 8,
                        AdmissionNo = 1007,
                        EnrollmentNo = 2007,
                        UniqueStudentAttendanceNumber = 1007,
                        StudentName = "Zara Khan",
                        StudentGender = GenderList.Female,
                        StudentBloodGroup = "AB-",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "43210987654321098",
                        StudentContactNumber1 = "9876543216",
                        StudentEmail = "zara.khan@example.com",
                        PermanentAddress = "Rajshahi, Bangladesh",
                        TemporaryAddress = "Rajshahi, Bangladesh",
                        FatherName = "Akram Khan",
                        FatherNID = "43210987654321099",
                        FatherContactNumber = "9876543226",
                        MotherName = "Taslima Khan",
                        MotherNID = "43210987654321100",
                        MotherContactNumber = "9876543236",
                        LocalGuardianName = "Ayesha Begum",
                        LocalGuardianContactNumber = "9876543246",
                        StandardId = 3,
                    },
                    new Student
                    {
                        Id = 9,
                        //StudentId = 9,
                        AdmissionNo = 1008,
                        EnrollmentNo = 2008,
                        UniqueStudentAttendanceNumber = 1008,
                        StudentName = "Arif Hossain",
                        StudentGender = GenderList.Male,
                        StudentBloodGroup = "A+",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "32109876543210987",
                        StudentContactNumber1 = "9876543217",
                        StudentEmail = "arif.hossain@example.com",
                        PermanentAddress = "Sylhet, Bangladesh",
                        TemporaryAddress = "Sylhet, Bangladesh",
                        FatherName = "Kamal Hossain",
                        FatherNID = "32109876543210988",
                        FatherContactNumber = "9876543227",
                        MotherName = "Nazma Hossain",
                        MotherNID = "32109876543210989",
                        MotherContactNumber = "9876543237",
                        LocalGuardianName = "Salam Ahmed",
                        LocalGuardianContactNumber = "9876543247",
                        StandardId = 3,
                    },
                    new Student
                    {
                        Id = 10,
                        //StudentId = 10,
                        AdmissionNo = 1009,
                        EnrollmentNo = 2009,
                        UniqueStudentAttendanceNumber = 1009,
                        StudentName = "Sabrina Akter",
                        StudentGender = GenderList.Female,
                        StudentBloodGroup = "A-",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "21098765432109876",
                        StudentContactNumber1 = "9876543218",
                        StudentEmail = "sabrina.akter@example.com",
                        PermanentAddress = "Dhaka, Bangladesh",
                        TemporaryAddress = "Dhaka, Bangladesh",
                        FatherName = "Jamil Akter",
                        FatherNID = "21098765432109877",
                        FatherContactNumber = "9876543228",
                        MotherName = "Rina Akter",
                        MotherNID = "21098765432109878",
                        MotherContactNumber = "9876543238",
                        LocalGuardianName = "Khaled Rahman",
                        LocalGuardianContactNumber = "9876543248",
                        StandardId = 4,
                    },
                    new Student
                    {
                        Id = 11,
                        //StudentId = 11,
                        AdmissionNo = 1010,
                        EnrollmentNo = 2010,
                        UniqueStudentAttendanceNumber = 1010,
                        StudentName = "Rahat Hasan",
                        StudentGender = GenderList.Male,
                        StudentBloodGroup = "O-",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "10987654321098765",
                        StudentContactNumber1 = "9876543219",
                        StudentEmail = "rahat.hasan@example.com",
                        PermanentAddress = "Chittagong, Bangladesh",
                        TemporaryAddress = "Chittagong, Bangladesh",
                        FatherName = "Hasan Mahmud",
                        FatherNID = "10987654321098766",
                        FatherContactNumber = "9876543229",
                        MotherName = "Nazma Hasan",
                        MotherNID = "10987654321098767",
                        MotherContactNumber = "9876543239",
                        LocalGuardianName = "Farhana Akter",
                        LocalGuardianContactNumber = "9876543249",
                        StandardId = 4,
                    },
                    new Student
                    {
                        Id = 12,
                        //StudentId = 12,
                        AdmissionNo = 1011,
                        EnrollmentNo = 2011,
                        UniqueStudentAttendanceNumber = 1011,
                        StudentName = "Asif Rahman",
                        StudentGender = GenderList.Male,
                        StudentBloodGroup = "AB-",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "09876543210987654",
                        StudentContactNumber1 = "9876543220",
                        StudentEmail = "asif.rahman@example.com",
                        PermanentAddress = "Rajshahi, Bangladesh",
                        TemporaryAddress = "Rajshahi, Bangladesh",
                        FatherName = "Rahim Rahman",
                        FatherNID = "09876543210987655",
                        FatherContactNumber = "9876543230",
                        MotherName = "Sara Rahman",
                        MotherNID = "09876543210987656",
                        MotherContactNumber = "9876543240",
                        LocalGuardianName = "Kamal Hossain",
                        LocalGuardianContactNumber = "9876543250",
                        StandardId = 4,
                    },
                    new Student
                    {
                        Id = 13,
                        //StudentId = 13,
                        AdmissionNo = 1012,
                        EnrollmentNo = 2012,
                        UniqueStudentAttendanceNumber = 1012,
                        StudentName = "Mehnaz Khan",
                        StudentGender = GenderList.Female,
                        StudentBloodGroup = "A+",
                        StudentNationality = "Bangladeshi",
                        StudentNIDNumber = "98765432109876543",
                        StudentContactNumber1 = "9876543221",
                        StudentEmail = "mehnaz.khan@example.com",
                        PermanentAddress = "Sylhet, Bangladesh",
                        TemporaryAddress = "Sylhet, Bangladesh",
                        FatherName = "Akram Khan",
                        FatherNID = "98765432109876544",
                        FatherContactNumber = "9876543231",
                        MotherName = "Taslima Khan",
                        MotherNID = "98765432109876545",
                        MotherContactNumber = "9876543241",
                        LocalGuardianName = "Ayesha Begum",
                        LocalGuardianContactNumber = "9876543251",
                        StandardId = 4,
                    }

                );
            #endregion

            #region Subject
            // Seed Subject data if required
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    //SubjectId = 1,
                    SubjectName = "Mathematics",
                    SubjectCode = 101,
                    StandardId = 1
                },
                new Subject
                {
                    Id = 2,
                    //SubjectId = 2,
                    SubjectName = "Bengali",
                    SubjectCode = 102,
                    StandardId = 1
                },
                new Subject
                {
                    Id = 3,
                    //SubjectId = 3,
                    SubjectName = "Physics",
                    SubjectCode = 103,
                    StandardId = 1
                },
                new Subject
                {
                    Id = 4,
                    //SubjectId = 4,
                    SubjectName = "Mathematics",
                    SubjectCode = 201,
                    StandardId = 2
                },
                new Subject
                {
                    Id = 5,
                    //SubjectId = 5,
                    SubjectName = "Bengali",
                    SubjectCode = 202,
                    StandardId = 2
                },
                new Subject
                {
                    Id = 6,
                    //SubjectId = 6,
                    SubjectName = "Physics",
                    SubjectCode = 203,
                    StandardId = 2
                },

                new Subject
                {
                    Id = 7,
                    //SubjectId = 7,
                    SubjectName = "Mathematics",
                    SubjectCode = 301,
                    StandardId = 3
                },
                new Subject
                {
                    Id = 8,
                    //SubjectId = 8,
                    SubjectName = "Bengali",
                    SubjectCode = 302,
                    StandardId = 3
                },
                new Subject
                {
                    Id = 9,
                    //SubjectId = 9,
                    SubjectName = "Physics",
                    SubjectCode = 303,
                    StandardId = 3
                },

                new Subject
                {
                    Id = 10,
                    //SubjectId = 10,
                    SubjectName = "Mathematics",
                    SubjectCode = 401,
                    StandardId = 4
                },
                new Subject
                {
                    Id = 11,
                    //SubjectId = 11,
                    SubjectName = "Bengali",
                    SubjectCode = 402,
                    StandardId = 4
                },
                new Subject
                {
                    Id = 12,
                    //SubjectId = 12,
                    SubjectName = "Physics",
                    SubjectCode = 403,
                    StandardId = 4
                }

            );
            #endregion

            #region StaffExperience_Excluded
            modelBuilder.Entity<StaffExperience>().HasData(
                new StaffExperience
                {
                    Id = 1,
                    //StaffExperienceId = 1,
                    CompanyName = "ABC Company",
                    Designation = "Software Engineer",
                    JoiningDate = new DateTime(2020, 5, 10),
                    LeavingDate = new DateTime(2022, 8, 15),
                    Responsibilities = "Developed web applications.",
                    Achievements = "Received Employee of the Month award."
                },
                new StaffExperience
                {
                    Id = 2,
                    //StaffExperienceId = 2,
                    CompanyName = "XYZ Corporation",
                    Designation = "Data Analyst",
                    JoiningDate = new DateTime(2018, 9, 20),
                    LeavingDate = new DateTime(2020, 4, 30),
                    Responsibilities = "Analyzed data to provide insights.",
                    Achievements = "Implemented a new data visualization system."
                },
                new StaffExperience
                {
                    Id = 3,
                    //StaffExperienceId = 3,
                    CompanyName = "EFG Ltd.",
                    Designation = "Project Manager",
                    JoiningDate = new DateTime(2016, 3, 5),
                    LeavingDate = new DateTime(2018, 7, 25),
                    Responsibilities = "Led a team of developers.",
                    Achievements = "Successfully delivered multiple projects on time."
                }
                // Add more seed data as needed
            );

            #endregion

            #region Staff
            modelBuilder.Entity<Staff>().HasData(
               new Staff
               {
                   Id = 1,
                   //StaffId = 1,
                   StaffName = "Jamir King",
                   UniqueStaffAttendanceNumber = 201,
                   Gender = Gender.Male,
                   DOB = new DateTime(1985, 5, 15),
                   FatherName = "Michael Doe",
                   MotherName = "Alice Doe",
                   TemporaryAddress = "Temporary Address",
                   PermanentAddress = "Permanent Address",
                   ContactNumber1 = "1234567890",
                   Email = "john.doe@example.com",
                   Qualifications = "Bachelor's in Computer Science",
                   JoiningDate = new DateTime(2010, 7, 1),
                   Designation = Designation.Counselor,
                   BankAccountName = "John Doe",
                   BankAccountNumber = 1234567890,
                   BankName = "ABC Bank",
                   BankBranch = "XYZ Branch",
                   Status = "Active",
                   DepartmentId = 1,
                   StaffSalaryId = 1
               },
               new Staff
               {
                   Id = 2,
                   //StaffId = 2,
                   StaffName = "Jamir Jamidar",
                   UniqueStaffAttendanceNumber = 202,
                   Gender = Gender.Female,
                   DOB = new DateTime(1990, 8, 20),
                   FatherName = "David Smith",
                   MotherName = "Emily Smith",
                   TemporaryAddress = "Temporary Address",
                   PermanentAddress = "Permanent Address",
                   ContactNumber1 = "9876543210",
                   Email = "alice.smith@example.com",
                   Qualifications = "Master's in Education",
                   JoiningDate = new DateTime(2015, 9, 15),
                   Designation = Designation.Headmistress,
                   BankAccountName = "Alice Smith",
                   BankAccountNumber = 9873210,
                   BankName = "DEF Bank",
                   BankBranch = "UVW Branch",
                   Status = "Active",
                   DepartmentId = 2,
                   StaffSalaryId = 2
               },
               new Staff
               {
                   Id = 3,
                   //StaffId = 3,
                   StaffName = "Jamir Amir",
                   UniqueStaffAttendanceNumber = 203,
                   Gender = Gender.Male,
                   DOB = new DateTime(1980, 01, 01),
                   FatherName = "Richard Doe",
                   MotherName = "Jane Doe",
                   TemporaryAddress = "123 Main Street, Anytown",
                   PermanentAddress = "456 Elm Street, Anytown",
                   ContactNumber1 = "555-123-4567",
                   Email = "john.doe@example.com",
                   Qualifications = "Bachelor of Science in Mathematics",
                   JoiningDate = new DateTime(2020, 08, 15),
                   Designation = Designation.Professor,
                   BankAccountName = "John Doe",
                   BankAccountNumber = 1234567890,
                   BankName = "Anytown Bank",
                   BankBranch = "Main Street",
                   Status = "Active",
                   DepartmentId = 3,
                   StaffSalaryId = 3
               }

           );
            #endregion

            #region Fee
            // Seed Fee data if required
            modelBuilder.Entity<Fee>().HasData(
                new Fee { Id = 1,/* FeeId = 1,*/ FeeTypeId = 1, StandardId = 1, PaymentFrequency = Frequency.Yearly, Amount = 1500, DueDate = new DateTime(2023, 5, 1) },
                new Fee { Id = 2,/* FeeId = 2,*/ FeeTypeId = 2, StandardId = 1, PaymentFrequency = Frequency.Monthly, Amount = 500, DueDate = new DateTime(2023, 5, 5) },
                new Fee { Id = 3, /*FeeId = 3,*/ FeeTypeId = 3, StandardId = 1, PaymentFrequency = Frequency.Monthly, Amount = 200, DueDate = new DateTime(2023, 5, 10) },
                new Fee { Id = 4, /*FeeId = 4,*/ FeeTypeId = 6, StandardId = 1, PaymentFrequency = Frequency.Monthly, Amount = 100, DueDate = new DateTime(2023, 5, 15) },
                new Fee { Id = 5, /*FeeId = 5,*/ FeeTypeId = 5, StandardId = 1, PaymentFrequency = Frequency.Custom, Amount = 250, DueDate = new DateTime(2023, 5, 20) },
                new Fee { Id = 6,/* FeeId = 6,*/ FeeTypeId = 4, StandardId = 1, PaymentFrequency = Frequency.Custom, Amount = 300, DueDate = new DateTime(2023, 5, 25) },
                new Fee { Id = 7, /*FeeId = 7, */FeeTypeId = 1, StandardId = 2, PaymentFrequency = Frequency.Yearly, Amount = 1500, DueDate = new DateTime(2023, 6, 1) },
                new Fee { Id = 8, /*FeeId = 8,*/ FeeTypeId = 2, StandardId = 2, PaymentFrequency = Frequency.Monthly, Amount = 500, DueDate = new DateTime(2023, 6, 5) },
                new Fee { Id = 9, /*FeeId = 9,*/ FeeTypeId = 3, StandardId = 2, PaymentFrequency = Frequency.Monthly, Amount = 200, DueDate = new DateTime(2023, 6, 10) },
                new Fee { Id = 10, /*FeeId = 10,*/ FeeTypeId = 6, StandardId = 2, PaymentFrequency = Frequency.Monthly, Amount = 100, DueDate = new DateTime(2023, 6, 15) },
                new Fee { Id = 11, /*FeeId = 11,*/ FeeTypeId = 5, StandardId = 2, PaymentFrequency = Frequency.Custom, Amount = 250, DueDate = new DateTime(2023, 6, 20) },
                new Fee { Id = 12, /*FeeId = 12,*/ FeeTypeId = 4, StandardId = 2, PaymentFrequency = Frequency.Custom, Amount = 300, DueDate = new DateTime(2023, 6, 25) },
                new Fee { Id = 13, /*FeeId = 13,*/ FeeTypeId = 1, StandardId = 3, PaymentFrequency = Frequency.Yearly, Amount = 1500, DueDate = new DateTime(2023, 7, 1) },
                new Fee { Id = 14, /*FeeId = 14,*/ FeeTypeId = 2, StandardId = 3, PaymentFrequency = Frequency.Monthly, Amount = 500, DueDate = new DateTime(2023, 7, 5) },
                new Fee { Id = 15, /*FeeId = 15,*/ FeeTypeId = 3, StandardId = 3, PaymentFrequency = Frequency.Monthly, Amount = 200, DueDate = new DateTime(2023, 7, 10) },
                new Fee { Id = 16, /*FeeId = 16,*/ FeeTypeId = 6, StandardId = 3, PaymentFrequency = Frequency.Monthly, Amount = 100, DueDate = new DateTime(2023, 7, 15) },
                new Fee { Id = 17, /*FeeId = 17,*/ FeeTypeId = 5, StandardId = 3, PaymentFrequency = Frequency.Custom, Amount = 250, DueDate = new DateTime(2023, 7, 20) },
                new Fee { Id = 18, /*FeeId = 18,*/ FeeTypeId = 4, StandardId = 3, PaymentFrequency = Frequency.Custom, Amount = 300, DueDate = new DateTime(2023, 7, 25) },
                new Fee { Id = 19, /*FeeId = 19,*/ FeeTypeId = 1, StandardId = 4, PaymentFrequency = Frequency.Yearly, Amount = 1500, DueDate = new DateTime(2023, 8, 1) },
                new Fee { Id = 20, /*FeeId = 20,*/ FeeTypeId = 2, StandardId = 4, PaymentFrequency = Frequency.Monthly, Amount = 500, DueDate = new DateTime(2023, 8, 5) }
            );
            #endregion

            #endregion

        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
        //#endregion
    }
}
