using System.ComponentModel.DataAnnotations;

namespace Vilcu_Ana_Lab2.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }

        [Display(Name = "Category")]
        public Category? Category { get; set; }
    }
}
