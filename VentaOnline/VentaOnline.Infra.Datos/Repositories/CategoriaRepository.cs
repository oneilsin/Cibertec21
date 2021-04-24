using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnline.Domain.Models;
using VentaOnline.Domain.Repositories;

namespace VentaOnline.Infra.Datos.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Task<int> Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modify(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
