using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Series
{
    public interface IRepository<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere (T entidade);
        void Exclui (int id);
        void Atualiza (int id, T entidade);
        int ProximoId();
    }
}