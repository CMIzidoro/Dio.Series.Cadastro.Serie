using System.Collections.Generic;
namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         
         T RetornaPorId(int id);

         void insere (T entidade);
         
         void Excluir(int id );

         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}