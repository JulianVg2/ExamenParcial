namespace ExamenParcial
{
    public class Revistas : Libros
    {
        public int Volumen { get; set; }
        public int NumeroEjemplar { get; set; }

        public Revistas()
        {
            Volumen = 0;
            NumeroEjemplar = 0;
        }


    }
}
