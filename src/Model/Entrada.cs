namespace MyGoodDiary.src.Model
{
    public class Entrada
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Texto { get; set; }
        public string Estado { get; set; } // feliz, triste, neutro
    }
}