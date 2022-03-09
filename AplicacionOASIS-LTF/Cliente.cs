using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionOASIS_LTF
{
    internal class Cliente
    {
        public string  Nombre { get; set; }
        public string  Direccion { get; set; }
        public int Telefono  { get; set; }
        public int IDCedula  { get; set; }
        public List<Producto> listaProductos = new List<Producto>();

    }
}
