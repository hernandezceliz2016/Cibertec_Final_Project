using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("Person.Person")]
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [Display(Name = "Person Type")]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(2, ErrorMessage = "Length 2")]
        public string PersonType { get; set; }

        [Display(Name="Name Style")]
        public bool NameStyle { get; set; }

        [Display(Name="Title")]
        [StringLength(8, ErrorMessage="Length 8")]
        public string Title { get; set; }

        [Display(Name="First Name")]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage="Length 50")]
        public string FirstName { get; set; }

        [Display(Name="Middle Name")]
        [StringLength(50, ErrorMessage = "Length 50")]
        public string MiddleName { get; set; }

        [Display(Name="Last Name")]
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "Length 50")]
        public string LastName { get; set; }

        [Display(Name = "Modified Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }


        [StringLength(10, ErrorMessage="Length 10")]
        public string Suffix { get; set; }

        [Display(Name="Email Promotion")]
        public int EmailPromotion { get; set; }

        [Display(Name="Additional Contact Info")]
        [Column(TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }

        [Column(TypeName = "xml")]
        public string Demographics { get; set; }

        public Guid rowguid { get; set; }


        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }

        public virtual ICollection<EmailAddress> EmailAddress { get; set; }

        public virtual Password Password { get; set; }

        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
