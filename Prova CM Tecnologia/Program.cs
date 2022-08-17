using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnologia
{
    class Program
    {
        static void Main(String[] args){
            /*
              
            - Atividade 1:
                1. Implemente um algoritmo que determine se uma string tenha
                todos os caracteres únicos;
                Exemplo:
                input: Thales output: true.

           - Obs pessoais:
                a) Assumi que não haveria distinção de letras maiúsculas nem minúsculas 
                por isso o ToLower() logo após o ReadLine() onde o usuário digita seu texto

                b) Também assumi que não haveria necessidade de tratar os espaços " " 
                e fazer alguma limitação para que o usuário digite apenas 1 palavra.

             */

            //Atividade 1:
            Console.WriteLine("Atividade 1: ");
            var msg = "Thales".ToLower();
            Console.WriteLine(msg);
            Console.WriteLine(wordIsUnique(msg)); // true, false

            /*
             
             - Atividade 2:
                2. Dado duas strings, escreva um método que determine se uma
                é a permutação da outra;
                Exemplos:
                input: ("god", "dog") output: true
                input: ("god", "dog ") output: false

             */

            string[] palavras = new string[2];
            palavras[0] = "Dog".ToLower();
            palavras[1] = "God".ToLower();
            Console.WriteLine("==================");
            Console.WriteLine("Atividade 2: ");
            Console.WriteLine(palavras[0] +" / " + palavras[1]);
            Console.WriteLine(isPermutation(palavras[0], palavras[1]));
        }


        //Atividade 1
        private static bool letterIsUnique(string word, int letterIndex)
        {
            for (var i = 0; i < word.Length; i++)
            {
                if (i <= letterIndex)
                {
                    continue;
                }
                if (word[letterIndex] == word[i])
                {
                    return false;
                }
            }
            return true;
        }

        //Atividade 1
        private static bool wordIsUnique(string msg)
        {
            for (var i = 0; i < msg.Length; i++)
            {
                if (!letterIsUnique(msg, i))
                {
                    return false;
                }
            }
            return true;
        }

        //Atividade 2
        private static bool hasLetter(char letter, string word)
        {
            for(var i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    return true;
                }
            }
            return false;

        }

        //Atividade 2
        private static bool isPermutation(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            for (var i = 0; i < word1.Length; i++)
            {
                if (!hasLetter(word1[i], word2))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}