using System.ComponentModel.DataAnnotations;

namespace Licorera.Models
{
    public class Articulo
    {

        [Display(Name = "Identificacion del articulo")]
        public int ArticuloID { get; set; }

        [Display(Name = "Cantidad en Existencia")]

        public int cantidadExistencia { get; set; }

        [Display(Name = "Identificacion de la bodega")]

        public int IDBodega { get; set; }

        [Display(Name = "Fecha de Ingreso a Bodega")]
        public DateTime FechaIngresoBodega { get; set; }

        public DateTime FechaVencimiento { get; set; }

        [Display(Name = "Tipo de Licor")]
        [RegularExpression("(cerveza|Cerveza|Tequila|tequila|Ron|ron|Ginebra|ginebra|whiskey|whiskey|digestivo|Digestivo|agua|Agua|vino tino|Vino Tinto|Vino blanco|vino blanco|Vino rosado|vino rosado|Champagne|champagne)", ErrorMessage = "Unicos valores validos son: cerveza, tequila, ron, ginebra, whiskey, digestivo, agua ardiente,vino tinto, vino blanco, vino rosado, champagne")]

        public string? tipoLicor { get; set; }

        //constructor

        public Articulo() { }



    }
}
