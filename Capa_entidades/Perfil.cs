using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Capa_Entidad
{
    public class Perfil
    {
        public enum TIPO
        {
            Supervisor = 1,
            Almacenista = 2,
            Otro = 3,

        }
        public int id_perfil { get; set; }
        public Empleado empleado { get; set; }
        public string user { get; set; }
        public int password { get; set; }
        public TIPO tipo_acceso { get; set; }

        public Perfil()
        {

        }

        public Perfil(Empleado emp, string user, int pass, TIPO ta)
        {
            int cont = 1;

            id_perfil = cont;
            empleado = emp;
            this.user = user;
            password = pass;
            tipo_acceso = ta;

            cont++;
        }
    }
}
