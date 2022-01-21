namespace UrnaEletronica.App.Entities
{
    public class Voto
    {
        public Voto(Candidato candidato)
        {
            Id = Guid.NewGuid();
            Candidato = candidato;
            VotadoEm = DateTime.Now;
        }
        public Guid Id { get; set; }
        public Candidato Candidato { get; set; }
        public DateTime VotadoEm { get; set; }

        public override string ToString()
        {
            return "candidatoCodigo:" + Candidato.Codigo.ToString() + "; hash: " + GetHashCode() + "; dataHoraVoto: " + VotadoEm.ToString("s");
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Candidato, VotadoEm);
        }
    }
}
