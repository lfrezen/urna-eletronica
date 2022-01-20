namespace UrnaEletronica.App.Entities
{
    public class Candidato
    {
        public Candidato(int id, string nome, int codigo, Partido partido)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
            Partido = partido;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public Partido Partido { get; set; }
    }
}
