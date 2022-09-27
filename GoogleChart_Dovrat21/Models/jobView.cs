using System.ComponentModel.DataAnnotations;
namespace GoogleChart_Dovrat21.Models
{
    public class jobView
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Source { set; get; }

        [Required]
        public int? JobsViewsCounter { set; get; }
        public DateTime Date { set; get; }

    }
}
