using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Capa_Entidad
{
    class Registro
    {
        public enum TIPO_CATEGORIA
        {
            Quimicos = 1,
            Herramientas = 2,
            Insumos = 3,
            Oficina = 4,

        }

        public enum TIPO_SUBCATEGORIA
        {
            Inflamables = 1,
            No_inflamables = 2,
            Electricas = 3,
            No_electricas = 4,
            Tuberia_PVC = 5,
            Tuberia_metalica = 6,
            Accesorios = 7,
            Electronicos = 8,
            Inmuebles = 9,
        }

        public int id_registro { get; set; }
        public TIPO_CATEGORIA categoria { get; set; }
        public TIPO_SUBCATEGORIA sub_categoria { get; set; }
        public string nombre_registro { get; set; }
        public int cantidad { get; set; }
        public int stock_min { get; set; }
        public int stock_max { get; set; }
        public double precio { get; set; }
        public string detalle { get; set; }

        public Registro()
        {

        }

        public Registro(TIPO_CATEGORIA tc, TIPO_SUBCATEGORIA ts, string nr, int cant, int smin, int smax, int p, string d)
        {
            int cont = 1;

            id_registro = cont;
            categoria = tc;
            sub_categoria = ts;
            nombre_registro = nr;
            cantidad = cant;
            stock_min = smin;
            stock_max = smax;
            precio = p;
            detalle = d;

            cont++;
        }
    }
}
