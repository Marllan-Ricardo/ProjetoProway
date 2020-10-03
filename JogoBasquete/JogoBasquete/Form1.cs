using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace JogoBasquete
{
    public partial class Inicio : Form
    {
        string placar = "";
        string scoreMin = "";
        string scoreMax = "";
        string pontuacaoMin = "";
        string pontuacaoMax = "";

        List<string> menoresTempos = new List<string>();
        List<string> maioresTempos = new List<string>();

        public Inicio()
        {
            InitializeComponent();
        }

        public class InserirPlacar
        {
            public string jogo, placar, minTemporada, maxTemporada, recordMin, recordMax;
        }

                     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSalvar_Click(object sender, EventArgs e)
        {
            InserirPlacar novoPlacar = new InserirPlacar();

            // Para receber os valores e é utilizado nas consultas de Placares / Recordes quebrados
            placar = txtPlacar.Text;
            scoreMax = txtRecordMax.Text;
            scoreMin = txtRecordMin.Text;

            menoresTempos.Add(txtMinTemp.Text);
            maioresTempos.Add(txtMaxTemp.Text);

            // Salva os dados informados em um Array para demostrar os Placares cadastrados
            novoPlacar.jogo = txtJogo.Text;
            novoPlacar.placar = txtPlacar.Text;
            novoPlacar.minTemporada = txtMinTemp.Text;
            novoPlacar.maxTemporada = txtMaxTemp.Text;
            novoPlacar.recordMin = txtRecordMin.Text;
            novoPlacar.recordMax = txtRecordMax.Text;
                                            
            txtPlacares.Text += novoPlacar.jogo + "\t";
            txtPlacares.Text += novoPlacar.placar + "\t";
            txtPlacares.Text += novoPlacar.minTemporada + "\t";
            txtPlacares.Text += novoPlacar.maxTemporada + "\t";
            txtPlacares.Text += novoPlacar.recordMin + "\t";
            txtPlacares.Text += novoPlacar.recordMax + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInserir_Click(object sender, EventArgs e)
        {
            // Ao clicar no inserir, vai limpar os dados nos campos.
            txtJogo.Clear();
            txtPlacar.Clear();
            txtMinTemp.Clear();
            txtMaxTemp.Clear();
            txtRecordMin.Clear();
            txtRecordMax.Clear();

            lblJogo.Visible = true;
            txtJogo.Visible = true;

            lblPlacar.Visible = true;
            txtPlacar.Visible = true;

            lblMinTemp.Visible = true;
            txtMinTemp.Visible = true;

            lblMaxTemp.Visible = true;
            txtMaxTemp.Visible = true;

            lblRecordeMin.Visible = true;
            txtRecordMin.Visible = true;

            lblRecordeMax.Visible = true;
            txtRecordMax.Visible = true;
        }

        private void frmConsultarRecordes_Click(object sender, EventArgs e)
        {


            int contador = 0;

            foreach(var registro in txtPlacares.Lines)
            {
                
                string x = scoreMax;
                string y = scoreMin;

                if (int.Parse(y) != 0)
                {
                    contador++;
                }
                else if(int.Parse(x) != 0)
                {
                    contador++;
                }

            }

            MessageBox.Show($"O recorde foi quebrado {contador} vezes");

        }

        //Faz a consulta do menor Placar
        private void consultarMenorTempo(object sender, EventArgs e)
        {
            List<int> menoresTemposInt = new List<int>();

            menoresTemposInt = menoresTempos.Select(int.Parse).ToList();
            int menorTempo = menoresTemposInt.Min();
                
            MessageBox.Show($"Placar mínimo {menorTempo} pontos");
        }

        //Faz a consulta do maior Placar
        private void consultarMaiorTempo(object sender, EventArgs e)
        {
            List<int> maioresTemposInt = new List<int>();

            maioresTemposInt = maioresTempos.Select(int.Parse).ToList();
            int maiorTempo = maioresTemposInt.Max();

            //string interpolation
            MessageBox.Show($"Placar mínimo {maiorTempo} pontos");
        }
    }
}
