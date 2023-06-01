using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.CacheSoftware
{
    public static class Cache
    {

        public static int id_usuario { get; set; }
        public static string usuario { get; set; }
        public static int id_producto { get; set; }
        public static int id_proveedores { get; set; }
        public static int id_ventas { get; set; }
        public static int id_corte_caja { get; set; }
        public static int id_invercion { get; set; }
        public static decimal totalVenta { get; set; }

    }
}
