using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRConectaAdmin.Clases
{
    public static class UserData
    {
        //Obtiene los siguientes datos del json
        //json[0].id
        //json[0].nombre
        //json[0].apellido
        //json[0].privilegios
        //json[0].usuario
        //json[0].contraseña
        //json[0].puesto
        //json[0].departamento
        //json[0].email
        //json[0].tbObraAsignada
        public static int id { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static int privilegios { get; set; }
        public static string usuario { get; set; }
        public static string contraseña { get; set; }
        public static string puesto { get; set; }
        public static string departamento { get; set; }
        public static string email { get; set; }
        public static List<int> tbObraAsignada { get; set; }
    }
}
