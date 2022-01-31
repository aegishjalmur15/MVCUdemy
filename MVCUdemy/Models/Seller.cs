using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCUdemy.Models
{
    public class Seller
    {
        public Seller()
        {

        }
        public Seller(int id, string name, string email, double salary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
            BirthDate = birthDate;
            Department = department;
        }

        public int Id { get; set; }

        [Required(ErrorMessage ="{0} Required")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        [Required(ErrorMessage = "{0} Required")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString ="{0:f2}")]
        [Range(100.00, 500000.00, ErrorMessage = "{0} must be from {2} to {1}")]
        [Required(ErrorMessage = "{0} Required")]
        public double Salary { get; set; }

        //customize the way that is displayed
        [Display(Name="Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Required")]

        public DateTime BirthDate { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

       
        public Department Department { get; set; }

        public int DepartmentId { get; set; }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);

        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(a => a.Amount);
        }
    }
}
