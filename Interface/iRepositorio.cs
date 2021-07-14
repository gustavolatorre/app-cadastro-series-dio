using System.Collections.Generic;

namespace cadastro.series.Interface
{
    public interface iRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int Id);
         void Insere(T entidade);
         void Excluir(int Id );
         void Atualiza(int Id, T entidade);
         int ProximoId();

    }
}