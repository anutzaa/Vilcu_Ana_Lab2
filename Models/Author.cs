using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vilcu_Ana_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Author Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Author")]
        [NotMapped]
        public string Name
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
