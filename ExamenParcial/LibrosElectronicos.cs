namespace ExamenParcial
{
    public class LibrosElectronicos : Libros
    {
        public string Formato { get; set; }
        public int TamañoArchivo { get; set; }

        public LibrosElectronicos()
        {
            Formato = string.Empty;
            TamañoArchivo = 0;
        }
    }
}
