using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Capa_Entidad
{
    class Pedido
    {
        public int id_pedido { get; set; }
        public List<Pedido_registro> registros { get; set; }
        public Perfil creador { get; set; }

        public Pedido()
        {

        }

        public Pedido(List<Pedido_registro> registros, Perfil creador)
        {
            int cont = 1;

            id_pedido = cont;
            this.registros = registros;
            this.creador = creador;

            cont++;
        }
    }
}