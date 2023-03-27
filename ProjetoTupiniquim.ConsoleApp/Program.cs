/** Input:
    5 5

    1 2 N
    EMEMEMEMM

    3 3 L
    MMDMMDMDDM
 */

/** Output:
   1 3 N
   5 1 L
 */

namespace ProjetoTupiniquim.ConsoleApp
{
    internal class Program
    {
        //variável é global, pode ser acessada dentro de todas as funções da classe Program

        static string[] comandos = new string[2];
        static string[] localizacoes = new string[2];
        static int posicaoRobo = 0; 

        static void Main(string[] args)
        {            
            ConfigurarArea();

            ConfigurarLocalizacaoEhComando();

            ConfigurarLocalizacaoEhComando();

            for (int j = 0; j < comandos.Length; j++)
            {
                string[] inputRobo = localizacoes[j].Split(" ");

                int posicaoX = Convert.ToInt32(inputRobo[0]);
                int posicaoY = Convert.ToInt32(inputRobo[1]);

                char direcao = Convert.ToChar(inputRobo[2]);

                string comando = comandos[j];

                ExplorarArea(comando, ref posicaoX, ref posicaoY, ref direcao);

                ApresentarLocalizacaoRobo(posicaoX, posicaoY, direcao);
            }

            Console.ReadLine();
        }

        /**
        * 1) Precisa ser "static"        
        * 2) Definir o tipo de retorno "void"
        * 3) Definir um nome "MoverRobo"
        * 4) Definir se terá ou não argumentos "(char direcao, int posicaoX, int posicaoY)"
        * 5) Definir um escopo
        */

        static void ConfigurarLocalizacaoEhComando()
        {
            Console.Write($"Informe a localição do robô {posicaoRobo + 1}: ");
            localizacoes[posicaoRobo] = Console.ReadLine(); //1 2 N

            Console.Write($"Informe o comando do robô {posicaoRobo + 1}: ");
            comandos[posicaoRobo] = Console.ReadLine();

            posicaoRobo++;
        }

        static void ConfigurarArea()
        {
            Console.Write("Digite o tamaho da área: ");
            string area = Console.ReadLine();
        }

        static void ExplorarArea(string comando, ref int posicaoX, ref int posicaoY, ref char direcao)
        {
            char[] instrucoes = comando.ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == 'M') //mover robo
                {
                    //posicaoX e posicaoY será passagem de parâmetros "por referência"
                    MoverRobo(direcao, ref posicaoX, ref posicaoY);
                }

                else if (instrucoes[i] == 'E')
                {
                    //direção será passagem de parâmetros "por valor"
                    direcao = VirarEsquerda(direcao);
                }

                else if (instrucoes[i] == 'D')
                {
                    //direção será passagem de parâmetros "por valor"
                    direcao = VirarDireita(direcao);
                }
            }
        }

        static void ApresentarLocalizacaoRobo(int posicaoX, int posicaoY, char direcao)
        {
            Console.WriteLine(posicaoX + " " + posicaoY + " " + direcao);
        }
       
        static void MoverRobo(char d, ref int pX, ref int pY)
        {
            if (d == 'N')
                pY = pY + 1; //incrementar o Y

            else if (d == 'O')
                pX = pX - 1; //decrementar o X

            else if (d == 'S')
                pY = pY - 1; //decrementar o Y 

            else if (d == 'L')
                pX = pX + 1; //incrementar o X
        }

        static char VirarEsquerda(char direcaoAtual)
        {
            char novaDirecao = direcaoAtual;

            if (direcaoAtual == 'N')
                novaDirecao = 'O';

            else if (direcaoAtual == 'O')
                novaDirecao = 'S';

            else if (direcaoAtual == 'S')
                novaDirecao = 'L';

            else if (direcaoAtual == 'L')
                novaDirecao = 'N';

            return novaDirecao;
        }

        static char VirarDireita(char direcaoAtual)
        {
            char novaDirecao;

            switch (direcaoAtual)
            {
                case 'N': novaDirecao = 'L'; break;
                case 'O': novaDirecao = 'N'; break;
                case 'S': novaDirecao = 'O'; break;
                case 'L': novaDirecao = 'S'; break;

                default:
                    novaDirecao = direcaoAtual;
                    break;
            }

            return novaDirecao;
        }
    }
}