using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTupiniquim.ConsoleApp
{
    public class Robo //projeto, receita, design, molde
    {
        //atributos
        private int posicaoX;
        private int posicaoY;
        private char direcao;

        //propriedades
        public string Localizacao
        {
            set  // modificar o valor dos atributos
            {
                string[] inputRobo = value.Split(" ");

                if (inputRobo.Length != 3)
                    Console.WriteLine("Localização inválida");
                else
                {                    
                    posicaoX = Convert.ToInt32(inputRobo[0]);
                    posicaoY = Convert.ToInt32(inputRobo[1]);
                    direcao = Convert.ToChar(inputRobo[2]);
                }
            }
            get
            {
                return posicaoX + " " + posicaoY + " " + direcao;
            }
        }

        //métodos públicos
        public void ExplorarArea(string comando)
        {            
            char[] instrucoes = comando.ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == 'M') //mover robo
                {
                    //posicaoX e posicaoY será passagem de parâmetros "por referência"
                    MoverRobo();
                }

                else if (instrucoes[i] == 'E')
                {
                    //direção será passagem de parâmetros "por valor"
                    VirarEsquerda();
                }

                else if (instrucoes[i] == 'D')
                {
                    //direção será passagem de parâmetros "por valor"
                    VirarDireita();
                }
            }
        }


        //métodos privados
        private void MoverRobo()
        {
            if (direcao == 'N')
                posicaoY = posicaoY + 1; //incrementar o Y

            else if (direcao == 'O')
                posicaoX = posicaoX - 1; //decrementar o X

            else if (direcao == 'S')
                posicaoY = posicaoY - 1; //decrementar o Y 

            else if (direcao == 'L')
                posicaoX = posicaoX + 1; //incrementar o X
        }

        private void VirarEsquerda()
        {
            if (direcao == 'N')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'N';
        }

        private void VirarDireita()
        {
            switch (direcao)
            {
                case 'N': direcao = 'L'; break;
                case 'O': direcao = 'N'; break;
                case 'S': direcao = 'O'; break;
                case 'L': direcao = 'S'; break;

                default:
                    break;
            }
        }

        
    }
}
