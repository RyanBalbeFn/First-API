using System.Data.Common;
using System.Text.Json.Serialization;

namespace Primeira_API.Models
{
    public class CatalogoModel

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        [JsonIgnore]
        public ICollection <JogosModel> Jogos {  get; set; }
        
        }
    }
