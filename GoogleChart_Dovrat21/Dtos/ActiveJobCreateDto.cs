using System.ComponentModel.DataAnnotations;

namespace GoogleChart_Dovrat21.Dtos
{
    public class ActiveJobCreateDto
    {

        public int Id { get; set; }
        [Required]
        public string? Name { set; get; }

        [Required]
        public int? ActiveJobCounter { set; get; }

        [Required]
        public DateTime Date { set; get; }

    }
}
