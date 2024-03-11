namespace Cp1_Estoque_de_livro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Verity";
        public string Author { get; set; } = "Collen Hoover";
        public int QuntidadePaginas { get; set; } = 320;
        public CategoriaClass Class { get; set; } = CategoriaClass.Suspense;
    }
}
