using System.ComponentModel.DataAnnotations;

namespace Licorera.Models
{
    public class Cliente
    {
        [Display(Name = "Identificacion del cliente")]
        public int ClienteID { get; set; }

        [Display(Name = "Nombre Completo")]

        public string NombreCompleto { get; set; }

        public string Provincia { get; set; }

        [Display(Name = "Cantón")]
        public string Canton { get; set; }

        public string Distrito { get; set; }

        [Display(Name = "Historial total del dinero")]
        public float HistorialTotalDinero { get; set; }

        [Display(Name = "Dinero del Ultimo año")]
        public float UltimoAnoDinero { get; set; }

        [Display(Name = "Cantidad de Dinero ultimos seis meses")]

        public float CantidadSeisMesesDinero { get; set; }



        public Cliente() { }


    }
}
