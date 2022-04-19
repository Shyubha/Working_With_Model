using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;
namespace Working_With_Model.Models
{
    public class Students
    {
        [Key]
        [ScaffoldColumn(false)]
        public int rollno { get; set; }


        [DisplayName("Student Name")]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Percentage is required")]

        public int percentage { get; set; }

    }
}

