using System.ComponentModel.DataAnnotations;

namespace Vilcu_Ana_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Category")]
        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
