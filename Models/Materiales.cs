using System.ComponentModel.DataAnnotations;
namespace WorkTrackerApi.Models
{
    public class Materiales
    {
        [Key]
        public int ObraId { get; set; }

        public string? DuenoObra { get; set; }

        public DateTime? Fecha { get; set; }

        public string? Descripcion { get; set; }

        public int Cantidad { get; set; }

        public int CantRetirada { get; set; }

        public int CantFaltante { get; set; }

        public string? Suplidor { get; set; }

        public double? PrecioUd { get; set;}

    }
}
