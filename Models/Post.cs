namespace Ef.Models{
    public class Post{
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int AutorId { get; set; }
        public string Titlo { get; set; }
        public string Summario { get; set; }
        public string Corpo { get; set; }
        public string Slug { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }

    }
}