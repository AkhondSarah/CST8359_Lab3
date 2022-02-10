using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(100)]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public string LastName
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EmailAddress
        {
            get;
            set;
        }


        [Required]
        [StringLength(100)]
        public string Password
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public string Description
        {
            get;
            set;
        }


    }
}
