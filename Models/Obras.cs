using System.ComponentModel.DataAnnotations;
namespace WorkTrackerApi.Models
{
    public class Obras
    {
        [Key]
        public int ObraId { get; set; }

        public string? DuenoObra { get; set; }
    }
}
