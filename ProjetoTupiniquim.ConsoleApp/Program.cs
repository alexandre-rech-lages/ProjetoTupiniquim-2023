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

    class Program
    {
        //variável é global, pode ser acessada dentro de todas as funções da classe Program

        static string[] comandos = new string[2] { "EMEMEMEMM", "MMDMMDMDDM" };
        static string[] localizacoes = new string[2] { "1 2 N", "3 3 L" };
        static int posicaoRobo = 0;

        static void Main(string[] args)
        {
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
        }

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




    }


}