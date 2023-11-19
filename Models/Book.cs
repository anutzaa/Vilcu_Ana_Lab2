using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vilcu_Ana_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        [StringLengthAttribute(150, MinimumLength = 3, ErrorMessage = "Titlul cartii trebuie sa aiba intre 3 si 150 de caractere!")]
        public string? Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

       // public int? BorrowingID { get; set; }

       // [ForeignKey("BorrowingID")]
       // public Borrowing? Borrowing { get; set; }

        public ICollection<Author>? Authors { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
