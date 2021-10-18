using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>//tipo generico
    //Repositorio de séries
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atuaiza(int is, T entidade);

        int ProximoId();
    }
}