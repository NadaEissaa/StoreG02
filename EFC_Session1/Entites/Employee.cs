//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EFC_Session1.Entites
//{

//    //EF core support 4 ways to mapping class in databases [ table , view , function]

//    // 1. By convention way --> default behaviour for EFC

//    //POCO
//    //plain OLD CLR object
//    // Entity
//    // Table
//    // 1. by convention
//    // 2. Date Annotations --> [set of Attributes used for data annotation
//    #region 1. by convention
//    //internal class Employee
//    //{

//    //    public int Id { get; set; }  // public numberic property 'id' | 'Employee' --> PK  Indentity ( 1 , 1)

//    //    public string Name { get; set; } // Reference Type  : nvarchar(max) - Requird
//    //    public double salary { get; set; } // float : value type - Required
//    //    public int? Age { get; set; } // Nullable - int : value type : int(Age) - Required 

//    //    public string? Address { get; set; } //Nullable Reference Type : Optional

//    //    public DateTime DateOfCreation { get; set; } // Datetime2 

//    //} 
//    #endregion

//    // 2. Date Annotations

//    [Table ("Employees" , Schema="dbo")]

//    class Employee
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.None)]
//        public int EmpId { get; set; }


//        [Required]
//        [Column("EmpName" ,TypeName ="varchar")]
//        [MaxLength(50)]
//        [StringLength(50, MinimumLength = 10)]

//        public string? Name { get; set; }

   
//        public double salary { get; set; }

//        [Range(20, 60)]
//        public int? Age { get; set; }
//        [Column(TypeName = "money")]

//        [EmailAddress]
//        [DataType(DataType.EmailAddress)]
//        public string? Email { get; set; }

//        public string PhoneNumber { get; set; }

//        [NotMapped]
//        public double TotalSalary { get; set; }
//        public DateTime DateOfCreation { get; set; } 

//    }
//}
