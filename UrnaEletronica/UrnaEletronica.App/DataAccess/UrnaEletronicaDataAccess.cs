using UrnaEletronica.App.Entities;

namespace UrnaEletronica.App.DataAccess
{
    public class UrnaEletronicaDataAccess
    {
        private List<Candidato> Candidatos = new ()
        {
            new Candidato(1, "Ciro Gomes", 12, new Partido(1, "PDT")),
            new Candidato(2, "Fernando Haddad", 13, new Partido(2, "PT")),
            new Candidato(3, "Jair Bolsonaro", 17, new Partido(3, "PSL")),
            new Candidato(4, "Marina Silva", 18, new Partido(4, "REDE")),
            new Candidato(5, "Alvaro Dias", 19, new Partido(5, "PODE"))
        };

        public Candidato ObterCandidatoPorId(int? codigo)
        {
            if (codigo != null) {
                try
                {
                    var candidato = Candidatos.FirstOrDefault(c => c.Codigo == codigo);

                    if (candidato == null) return new Candidato(0, "Nulo", 0, new Partido(0, "Nulo"));

                    return candidato;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return new Candidato(0, "Nulo", 0, new Partido(0, "Nulo"));
        }

        public void RegistrarVoto(Voto voto)
        {
            StreamWriter writer = File.AppendText(Directory.GetCurrentDirectory() + "\\resultadoVotacao.txt");

            try
            {
                writer.WriteLine(voto.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar o voto. Detalhe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
