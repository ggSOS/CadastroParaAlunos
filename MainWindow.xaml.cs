using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroParaAlunos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void nomeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nomeInput.Focus();
        }


        private void matriculaLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            matriculaInput.Focus();
        }


        private void nota1Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nota1Input.Focus();
        }


        private void nota2Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nota2Input.Focus();
        }


        private void cadastrarButton_Click(object sender, RoutedEventArgs e)
        {
            String nomeParaCadastro = nomeInput.Text;
            int matriculaParaCadastro = 0;
            double nota1ParaCadastro = 0.0;
            double nota2ParaCadastro = 0.0;
            bool check = true;

            if (String.IsNullOrWhiteSpace(nomeParaCadastro))
            {
                check = false;
                nomeErro.Text = "Insira um Nome válido";
            }
            else
            {
                nomeErro.Text = "";
            }

            // checar se da pra converter, se a lista de matriculas está vazia e, se nao, se nao existe la
            if (int.TryParse(matriculaInput.Text, out int matriculaConvertida) && (Aluno.Matriculas.Count == 0 || !Aluno.Matriculas.Contains(int.Parse(matriculaInput.Text))) )
            {
                matriculaParaCadastro = matriculaConvertida;
                matriculaErro.Text = "";
            }
            else {
                check = false; 
                matriculaErro.Text = "Insira uma Matrícula válida";
            }

            if (double.TryParse(nota1Input.Text, out double nota1Convertida))
            {
                nota1ParaCadastro = nota1Convertida;
                nota1Erro.Text = "";
            }
            else
            {
                check = false;
                nota1Erro.Text = "Insira uma Média válida";
            }

            if (double.TryParse(nota2Input.Text, out double nota2Convertida))
            {
                nota2ParaCadastro = nota2Convertida;
                nota2Erro.Text = "";
            }
            else
            {
                check = false;
                nota2Erro.Text = "Insira uma Média válida";
            }

            if (check)
            {
                Cadastro.Cadastrar(new Aluno(nomeParaCadastro, matriculaParaCadastro, nota1ParaCadastro, nota2ParaCadastro));
                cadastroConfirmado.Text = " Cadastro Realizado!";
                nomeInput.Text = "";
                matriculaInput.Text = "";
                nota1Input.Text = "";
                nota2Input.Text = "";
            }
            else
            {
                cadastroConfirmado.Text = "";
            }
        }



        private void paginaAlunosButton_Click(object sender, RoutedEventArgs e)
        {
            Exibir exibir = new Exibir();
            exibir.Show();
        }
    }
}