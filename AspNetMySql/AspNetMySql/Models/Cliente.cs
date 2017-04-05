using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMySql.Models
{
    public class Cliente
    {
        public long ClienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}