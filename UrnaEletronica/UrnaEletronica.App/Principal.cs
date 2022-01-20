using UrnaEletronica.App.DataAccess;
using UrnaEletronica.App.Entities;

namespace UrnaEletronica.App
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private readonly string _path = Directory.GetCurrentDirectory();
        private Candidato candidato;

        private void btnClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;

            if (clickedButton == btn0)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "0";
                    ExibeCandidato();
                } 
                else
                    lblCodigo.Text = lblCodigo.Text + "0";
            }

            if (clickedButton == btn1)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "1";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "1";
            }

            if (clickedButton == btn2)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "2";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "2";
            }

            if (clickedButton == btn3)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "3";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "3";
            }

            if (clickedButton == btn4)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "4";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "4";
            }

            if (clickedButton == btn5)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "5";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "5";
            }

            if (clickedButton == btn6)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "6";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "6";
            }

            if (clickedButton == btn7)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "7";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "7";
            }

            if (clickedButton == btn8)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "8";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "8";
            }

            if (clickedButton == btn9)
            {
                if (lblCodigo.Text.Length == 1)
                {
                    lblCodigo.Text = lblCodigo.Text + "9";
                    ExibeCandidato();
                }
                else
                    lblCodigo.Text = lblCodigo.Text + "9";
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            pictureBoxCandidato.Image = null;
            lblNomeCandidato.Text = string.Empty;
            lblNomePartido.Text = string.Empty;
            lblCodigo.Text = string.Empty;
            AtivaBotoes();
        }

        private void ExibeCandidato()
        {
            UrnaEletronicaDataAccess _dataAccess = new UrnaEletronicaDataAccess();

            BloqueiaBotoes();

            var codigoCandidato = Convert.ToInt32(lblCodigo.Text);

            candidato = _dataAccess.ObterCandidatoPorId(Convert.ToInt32(lblCodigo.Text));

            try
            {
                pictureBoxCandidato.Image = Image.FromFile(_path + $"\\imagens\\{candidato.Codigo}.jpg");
                lblNomeCandidato.Text = candidato.Nome;
                lblNomePartido.Text = candidato.Partido.Nome;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Não foi possível localizar a foto do candidato. Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloqueiaBotoes()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnBranco.Enabled = false;
        }

        private void AtivaBotoes()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnBranco.Enabled = true;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            UrnaEletronicaDataAccess _dataAccess = new UrnaEletronicaDataAccess();

            _dataAccess.RegistrarVoto(new Voto(candidato));
            MessageBox.Show("Voto realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBoxCandidato.Image = null;
            lblCodigo.Text = string.Empty;
            AtivaBotoes();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxCandidato.Image = Image.FromFile(_path + "\\imagens\\branco.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível localizar a foto do candidato. Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
