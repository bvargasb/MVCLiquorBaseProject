using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Licorera.Models;


namespace Licorera.Data
{
    public class Licorera1Context
    {

        public Licorera1Context(List<Cliente> dataCliente)
        {

            Cliente = dataCliente;

        }


        public List<Articulo> Articulo = new List<Articulo>();

        public List<Cliente> Cliente = new List<Cliente>();

        public List<Pedidos> Pedidos = new List<Pedidos>();
    }
}
