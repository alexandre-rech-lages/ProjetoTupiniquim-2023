



/** Input:
    5 5

    1 2 N
    EMEMEMEMM

    3 3 L
    MMDMMDMDDM
 *//** Output:
   1 3 N
   5 1 L
 */ namespace ProjetoTupiniquim.ConsoleApp
{
    

    class Program
    {
        
        //variável é global, pode ser acessada dentro de todas as funções da classe Program

        static string[] comandos = new string[2] { "EMEMEMEMM", "MMDMMDMDDM" };
        static string[] localizacoes = new string[2] { "1 2 N", "3 3 L" };
        static int posicaoRobo = 0;

        static void MudarCorRoboParaVermelho(ref string cor)
        {
            cor = "Vermelho";
        }

        static void MudarCorRoboParaVermelhoEhPreto(Robo robo)
        {
            robo.cor = "Preto e Vermelho";
        }

        static int i = 0;
        private static void FazerAniversario(int[] idades)
        {
            idades[i++] = 10;
        }

        static void Main(string[] args) //tipos primitivos: string, double, int, decimal, bool, char, 
        {
            int[] idades = new int[10];

            FazerAniversario(idades);
            FazerAniversario(idades);
            FazerAniversario(idades);

            string corRoboBumblebee = "Amarelo";

            MudarCorRoboParaVermelho(ref corRoboBumblebee);           

            //Variáveis de Referências

            Robo bumblebee = new Robo();
            bumblebee.cor = "Amarelo";

            MudarCorRoboParaVermelhoEhPreto(bumblebee);

            Robo roboDaHavan = new Robo(); 
            roboDaHavan.cor = "Branco e Azul";

            MudarCorRoboParaVermelhoEhPreto(roboDaHavan);
            
            Console.WriteLine( "A cor do robo é: " + bumblebee.cor ); //???

            #region
            //ConfigurarArea();

            //ConfigurarLocalizacaoEhComando();

            //ConfigurarLocalizacaoEhComando();

            for (int j = 0; j < comandos.Length; j++)
            {
                Robo robocop = new Robo(); 
                robocop.Localizacao = localizacoes[j];                                 
                robocop.ExplorarArea(comandos[j]);
                Console.WriteLine(robocop.Localizacao);
            }

            Console.ReadLine();
            #endregion
        }

       
        #region
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

        #endregion


    }


}