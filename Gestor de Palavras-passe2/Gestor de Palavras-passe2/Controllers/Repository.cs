using Gestor_de_Palavras_passe2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Palavras_passe2.Controllers
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private List<T> _list = new List<T>();
        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Update(T item, int index)
        {
            _list[index] = item;
        }

        

        public bool Delete(T item)
        {
            return _list.Remove(item);
        }

        public T Get(T item)
        {
            return item;
        }

        public List<T> GetAll()
        {
            return _list;
        }
        public int tam() {

            return _list.Count();
        }
    }
}
