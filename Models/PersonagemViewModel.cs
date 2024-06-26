using System.Text.Json.Serialization;
using RpgMvc.Models.Enuns;

namespace RpgMvc.Models
{
    public class PersonagemViewModel
    {
        //Atalho: PROP + TAB
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem { get; set; }
        public int? UsuarioId { get; set; }

        // [JsonIgnore]
        // public Usuario? Usuario { get; set; }

        // [JsonIgnore]
        // public Arma? Arma { get; set; }
        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }

        [JsonIgnore]
        public List<PersonagemHabilidadeViewModel>? PersonagemHabilidades { get; set; }
    }
}