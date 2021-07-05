using System.Collections.Generic;

namespace App1_CRUD.Interfaces
{
  public interface IRepositorio<T> //Tipo genérico, idependente do tipo da classe que estiver sendo implementada.
  {
    List<T> Lista();
    T RetornaPorId(int id);
    void Insere(T entidade);
    void Exclui(int id);
    void Atualiza(int id, T entidade);
    int ProximoId();

  }
}