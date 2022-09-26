using System.ComponentModel.DataAnnotations;

namespace GoogleChart_Dovrat21.Models
{
    public class ActiveJob
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { set; get; }

        [Required]
        public int? ActiveJobCounter { set; get; }

        [Required]
        public string? Date { set; get; }

        //public DateTime Day { set; get; }
    }
}
