
using System.Security.Cryptography;
using System.Text;

namespace UrnaEletronica.App.Entities
{
    public class Voto
    {
        public Voto(Candidato candidato)
        {
            Id = Guid.NewGuid();
            Candidato = candidato;
            VotadoEm = DateTime.Now;
            Hash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(Id.ToString() + Candidato + VotadoEm.ToString("s")));
        }
        public Guid Id { get; set; }
        public Candidato Candidato { get; set; }
        public DateTime VotadoEm { get; set; }
        public byte[] Hash{ get; set; }

        public override string ToString()
        {
            return "candidatoCodigo:" + Candidato.Codigo.ToString() + "; hash: " + ASCIIEncoding.ASCII.GetString(Hash) + "; dataHoraVoto: " + VotadoEm.ToString("s");
        }
    }
}
