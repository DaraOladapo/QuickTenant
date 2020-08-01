using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickTenant.Models
{
    public class Account
    {
        public Guid ID { get; set; }
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class CreateAccount
    {
        [Required, DataType(DataType.Text)]
        public string UserID { get; set; }
        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required, DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
