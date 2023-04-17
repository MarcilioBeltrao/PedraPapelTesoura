namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        Image[] imgAdversario = new Image[]
        //Criação do Array para armazenamento das imagens
            {
                Properties.Resources.Pedra,
                Properties.Resources.Papel,
                Properties.Resources.Tesoura,

            };


        public Form1()
        {

            InitializeComponent();
        }


        private void ClickJogada(object sender, EventArgs e)
        {
            // Conversão do objeto para botão
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Joga jogaJogador = RetornaJogaJogador(Convert.ToInt32(bt.Tag)); //Armazena o valor da tag convertido em numeral
            Joga jogaAdversario = RetornaJogaAdversario(); //Armazena o valor do adversario
            Resultado resultado = RetornaGanhador(jogaJogador, jogaAdversario); // Armazena o ganhador de cada jogada

            if (resultado == Resultado.VitoriaAdversario)
            {
                LbAdversario.Text = (int.Parse(LbAdversario.Text) + 1).ToString();

            }
            else if (resultado == Resultado.VitoriaJogador)
            {
                lbjogador.Text = (int.Parse(lbjogador.Text) + 1).ToString();
            }
        }
        // Definição de Regras do jogo com o retorno do vencedor da jogada
        private Resultado RetornaGanhador(Joga jogador, Joga adversario)
        {
            if (jogador == Joga.Pedra)
            {
                if (adversario == Joga.Papel)
                {
                    return Resultado.VitoriaAdversario;
                }
                else if (adversario == Joga.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }
            else if (jogador == Joga.Papel)
            {
                if (adversario == Joga.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }
                else if (adversario == Joga.Tesoura)
                {
                    return Resultado.VitoriaAdversario;
                }
            }
            else
            {
                if (adversario == Joga.Pedra)
                {
                    return Resultado.VitoriaAdversario;
                }
                else if (adversario == Joga.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empate;

        }



        private Joga RetornaJogaJogador(int escolha)
        {
            return (Joga)escolha;

        }

        //Cria a jogada aleatoria quando o adversário é o computador baseado nas POSSÍVEIS JOGADAS do Joga
        private Joga RetornaJogaAdversario()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            PicAdversario.Image = imgAdversario[escolha];
            return (Joga)escolha;

        }

        private void LbDescricaoJogador2_Click(object sender, EventArgs e)
        {

        }
    }



    // Criação das POSSÍVEIS JOGADAS
    enum Joga
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2,
    }

    //Possíveis resultados
    enum Resultado
    {
        VitoriaJogador,
        VitoriaAdversario,
        Empate,

    }
}

