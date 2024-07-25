using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace Licorera.Models
{


    public class Pedidos
    {
        [Key]
        [Display(Name = "Identificacion del pedido")]
        public int IDpedido { get; set; }

        [Display(Name = "Identificacion del articulo")]
        public int IDarticulo { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = " Costo sin IVA 13%")]
        public float costoSinIVA { get; set; }

        [Display(Name = "Costo Total del producto con IVA 13%")]
        public float CostoTotalProducto { get; set; }

        [RegularExpression("(En proceso|en proceso|Facturado|facturado|Por entregar|por entregar|entregado|Entregado)", ErrorMessage = "Solo puede poner los siguientes estados En proceso, facturado, por entregar, entregado)")]
        [Display(Name = "Estado del pedido")]
        public string EstadoPedido { get; set; }

        public Pedidos() { }


    }
}
