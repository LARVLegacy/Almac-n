using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Empleado
    {
        public enum TIPO
        {
            Cedula_ciudadania = 1,
            cedula_extranjeria = 2,
            Tarjeta_identidad = 3,

        }
        public int id_empleado { get; set; }
        public string first_name { get; set; }   //nombre
        public string last_name { get; set; }    //apellido
        public TIPO tipo_documento { get; set; }
        public int num_documento { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }

        public Empleado()
        {

        }

        public Empleado(string fn, string ln, TIPO td, int nd, string correo, int tel)
        {
            int cont = 1;

            id_empleado = cont;
            first_name = fn;
            last_name = ln;
            tipo_documento = td;
            num_documento = nd;
            this.correo = correo;
            telefono = tel;

            cont++;
        }
    }
}
