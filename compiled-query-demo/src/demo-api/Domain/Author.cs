using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo_api.Domain
{
    public class Author
    {
        /* Do not silance the compiler nullable warnings by assigning empty string 
        instead use constructor to initialize the required properties
        */

        public Author(string firstName, string lastName, string email, string phone, string address) =>
            (FirstName, LastName, Email, Phone, Address) = (firstName, lastName, email, phone, address);

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // Primary Key

        [Required]
        [MaxLength(50, ErrorMessage = "FirstName cannot be more than 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "LastName cannot be more than 50 characters")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Email cannot be more than 50 characters")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Phone cannot be more than 50 characters")]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Address cannot be more than 50 characters")]
        public string Address { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}