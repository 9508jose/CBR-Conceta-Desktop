using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CBRConectaAdmin.Clases
{
    public class LoginRequest
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }

    public class SingupRequest
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
    }

    public class AsignarTrabajadorRequest
    {
        public string obra { get; set;}
        public string usuario { get; set; }
    }

    public class UserInObraRequest
    {
        public int id { get; set; }
    }

    public class DocumentRequest
    {
        public int id { get; set; }
    }
}
