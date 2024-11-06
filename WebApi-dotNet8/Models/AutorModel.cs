using System.Text.Json.Serialization;

namespace WebApi_dotNet8.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [JsonIgnore]//evita a lista de livros, para que na criação do autor, não tenha que inserir em seguida logo seus livros
        public ICollection<LivroModel> Livros { get; set; }
        
    }
}
