using System.ComponentModel.DataAnnotations;

namespace GoogleChart_Dovrat21.Models
{
    public class PredictedJobView
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string? Name { set; get; }

        [Required]
        public int? PredictedJobViewCounter { set; get; }

        public DateTime Date { set; get; }

    }
}
