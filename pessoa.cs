using System.Data;
namespace Fluxograma;
 
 //CLASSE PAI//

 public class Pessoa
{
 protected Int64 id;
 protected string nome;
 protected string telefone;
 protected string cidade;
 protected string municipio;
 protected string uf;
 protected DateTime dn;


 public void SetNome (string NomeDaPessoa)
 {
   nome = NomeDaPessoa;
 }
 public string GetNome()
 {
    return nome;
 }
}