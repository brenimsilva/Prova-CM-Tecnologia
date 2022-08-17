using System;
using System.Collections.Generic;
using System.Diagnostics;
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
             */

            //Atividade 1:
            Console.WriteLine("Atividade 1: ");
            var msg = "Thales".ToLower();
            Console.WriteLine(msg);
            Console.WriteLine(wordIsUnique(msg)); // true
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
    }
}