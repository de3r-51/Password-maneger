using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Palavras_passe2.Interfaces
{
    public interface IRepository<T>
    {
        public void Add(T item);
        public void Update(T item, int index);
        public bool Delete(T item);

        List <T> GetAll();

        public T Get(T item);

        public int  tam();

    }
}
