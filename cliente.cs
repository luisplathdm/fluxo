using System.Data;
namespace Fluxograma;

   //CLASSE FILHO//
  public class Cliente  
    {
      string cpf;

      public void SetCpf (string quandopedircpf) 
       {
        cpf = quandopedircpf;
       }
       public string GetCpf()
       {
        return cpf;
       }
    }