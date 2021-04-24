using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaOnline.Domain.Models;

namespace VentaOnline.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<int> Add(Categoria entity);
        Task<bool> Modify(Categoria entity);
        Task<bool> Delete(int id);
        Task<Categoria> Get(int id);
        Task<IEnumerable<Categoria>> Get(string name);
    }
}
