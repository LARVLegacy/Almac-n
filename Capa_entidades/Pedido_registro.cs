using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Capa_Entidad
{
    class Pedido_registro
    {
        public Registro registro { get; set; }
        public int cantidad { get; set; }

        public Pedido_registro()
        {

        }

        public Pedido_registro(Registro r, int c)
        {
            registro = r;
            cantidad = c;
        }
    }

}
