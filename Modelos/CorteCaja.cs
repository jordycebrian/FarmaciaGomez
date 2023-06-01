using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class CorteCaja:RepositorioMaestro
    {

        private int id_corte_caja;
        private int id_usuario;
        private int id_venta;
        private int total_corte;
        private DateTime fechaCreacion;

        public int ID_corte_caja { get { return id_corte_caja; } set { id_corte_caja = value; } }
        public int ID_usuario { get { return id_usuario; } set { id_usuario = value; } }
        public int ID_venta { get { return id_venta; } set { id_venta = value; } }
        public int Total_corte { get { return total_corte; } set { total_corte = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }


        public CorteCaja()
        {

            this.ID_corte_caja = id_corte_caja;
            this.ID_usuario = id_usuario;
            this.ID_venta = id_venta;
            this.Total_corte = total_corte;
            this.FechaCreacion = fechaCreacion;

        }




    }
}
