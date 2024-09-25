using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Palavras_passe2.Models
{
    public class Users
    {
        public string? Nome {  get; set; }
        public string? Senha { get; set; }
        public List <Dados>? Dados { get; set; }

    }
}
