//Create Book class with properties like Id, Title, Author, Category, Price and Description.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo_api.Domain
{

    public class Book
    {
        //Create Book class with properties like Id, Title, Author, Category, Price and Description.
        
        public Book(string title, string author, string category, string price, string description) =>
            (Title, Author, Category, Price, Description) = (title, author, category, price, description);
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } // Primary Key

        [Required]
        [MaxLength(50, ErrorMessage = "Title cannot be more than 50 characters")]
        public string Title { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Author cannot be more than 50 characters")]
        public string Author { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Category cannot be more than 50 characters")]
        public string Category { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Price cannot be more than 50 characters")]
        public string Price { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Description cannot be more than 50 characters")]
        public string Description { get; set; }
    }
}
