using System.Diagnostics;

namespace Primeira_API.Models
{
    public class JogosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CatalogoModel Categoria { get; set; }

    }

}