using Gestor_de_Palavras_passe2.Controllers;
using Gestor_de_Palavras_passe2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Palavras_passe2.Models
{
    public class Accounts
    {
        public IRepository<Users> repositorio_u = new Repository<Users>();

        public List<Dados> repositorio = new List<Dados>();
    }
}
