using System.ComponentModel.DataAnnotations;

namespace GoogleChart_Dovrat21.Dtos
{
    public class ActiveJobReadDto
    {
        public int Id { get; set; }
        public int? ActiveJobCounter { set; get; }
        public DateTime Date { set; get; }

    }
}
