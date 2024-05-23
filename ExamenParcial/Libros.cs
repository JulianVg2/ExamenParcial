namespace ExamenParcial
{
    public class Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int AnioPublicacion { get; set; }

        public Libros()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            AnioPublicacion = 0;


        }

    }
}
